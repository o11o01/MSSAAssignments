using System.Data;

namespace Assignment4._1._1
{
    public partial class Form1 : Form
    {
        Person userData = new Person();
        Dictionary<string, Person> people = Data.CreateData();
        public Form1()
        {
            InitializeComponent();
            Person temp = new Person("John", "Smith", "(555)555-5555", "(555)555-5555", "123 Easy Way");
            dataGridView1.DataSource = personBindingSource;
            personBindingSource.DataSource = people.Values.ToList();

        }
        public void Delete()
        {
            people.Remove(textBox3.Text + textBox2.Text);
            personBindingSource.DataSource = people.Values.ToList();
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMobilePhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxWorkPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddData_Click(object sender, EventArgs e)
        {

            people.Add(textBoxFirstName.Text + textBoxLastName.Text, new Person(textBoxFirstName.Text, textBoxLastName.Text, textBoxMobilePhone.Text, textBoxWorkPhone.Text, textBoxAddress.Text));
            personBindingSource.DataSource = people.Values.ToList();
            dataGridView1.Refresh();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            if(form2.Confirm == true)
            {
                 people.Remove(textBox3.Text + textBox2.Text);
                 personBindingSource.DataSource = people.Values.ToList();
                 dataGridView1.Refresh();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                personBindingSource1.DataSource = people.GetValueOrDefault(textBox4.Text);
                dataGridView1.DataSource = personBindingSource1;
            }
            else
            {
                dataGridView1.DataSource = personBindingSource;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                dataGridView1.DataSource = personBindingSource;
            }
        }
    }
}
