using System.Net.Http.Json;
using System.Text.Json;
namespace Assignment11._3Client
{
    public partial class Form1 : Form
    {
        HttpClient booksClient = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            booksClient.BaseAddress = new Uri("http://localhost:5234/api/Books");
        }

        private async void btnGetBook_Click(object sender, EventArgs e)
        {
            var books = await booksClient.GetAsync(booksClient.BaseAddress);
            if (books.IsSuccessStatusCode)
            {
                var booksList = await books.Content.ReadFromJsonAsync<List<Book>>();
                bookGrid.DataSource = booksList;
            }
            else
            {
                MessageBox.Show("Error" + books.StatusCode);
            }
        }

        private async void btnAddBook_Click(object sender, EventArgs e)
        {
            using StringContent content = new(JsonSerializer.Serialize(new Book
            {
                Id = Convert.ToInt32(txtBoxID.Text),
                Title = txtBoxTitle.Text,
                Author = txtBoxAuthor.Text,
                PublishDate = Convert.ToInt32(txtBoxDate.Text)
            }
                ), System.Text.Encoding.UTF8, "application/json");

            using var response = booksClient.PostAsync(booksClient.BaseAddress, content).Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Book added successfully");
            }
            else
            {
                MessageBox.Show("Error:" + response.StatusCode);
            }
        }

        private void txtBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string ID = $"/{txtBoxID.Text}";
            using var response = booksClient.DeleteAsync(booksClient.BaseAddress + ID ).Result;
        }
    }
}
