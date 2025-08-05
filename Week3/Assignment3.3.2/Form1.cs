namespace Assignment3._3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<Student> students = DataSource.CreateData();
            studentBindingSource.DataSource = students;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void studentBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
