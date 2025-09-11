namespace Assignment_10._3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Crud.GetCars();
        }

        private void buttonAddCar_Click(object sender, EventArgs e)
        {
            if (textBoxVin.Text != "")
            {
                Car temp = new Car()
                {
                    Vin = textBoxVin.Text,
                    Manufacture = textBoxManufacture.Text,
                    Model = textBoxModel.Text,
                    Price = Convert.ToInt32(textBoxPrice.Text)

                };
                Crud.addCar(temp);
                dataGridView1.DataSource = Crud.GetCars();
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Crud.DeleteCar(textBoxVin.Text);
            dataGridView1.DataSource = Crud.GetCars();
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Car selectedCar = new Car();
            selectedCar.Vin = textBoxVin.Text;
            selectedCar.Manufacture = textBoxManufacture.Text;
            selectedCar.Price = Convert.ToInt32(textBoxPrice.Text);
            selectedCar.Model = textBoxModel.Text;

            Crud.UpdateCar(textBoxVin.Text, selectedCar);
            dataGridView1.DataSource = Crud.GetCars();
        }
    }
}
