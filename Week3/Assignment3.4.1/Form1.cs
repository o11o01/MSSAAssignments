namespace Assignment3._4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<Coffee> coffees = Data.CreateData();
            coffeeBindingSource.DataSource = coffees;
        }

        private void coffeeBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
