using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4._1._1
{
    public partial class Form2 : Form
    {
        public bool Confirm
        { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            Confirm = true;
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            form1.Delete();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            Confirm = false;
            this.Close();
        }
    }
}
