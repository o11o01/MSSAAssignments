using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4._2._1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {


            List<Student> students = Data.BuildList();
            studentBindingSource1.DataSource = students;

        }

        private void AddStudent_Click(object sender, EventArgs e)
        {
            Form3 newForm3 = new Form3();
            newForm3.Show();
        }
        public List<Student> RefreshTable()
        {

            List<Student> students = Data.SortList(Data.BuildList());
            studentBindingSource1.DataSource = students;
            Data.WriteFile(students, "StudentData.txt");
            return students;

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void studentBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void studentBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            List<Student> students = Data.BuildList();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells[4].Value))
                {
                    students[row.Index].Selected = true;
                }
            }
            for (int i = students.Count - 1; i >= 0; i--)
            {
                if (students[i].Selected == true)
                {
                    students.RemoveAt(i);
                }
            }
            Data.WriteFile(students, "StudentData.txt");
            RefreshTable();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            List<Student> students = Data.BuildList();
            List<Student> export = new List<Student>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells[4].Value))
                {
                    students[row.Index].Selected = true;
                }
            }
                for (int i = students.Count - 1; i >= 0; i--)
                {
                    if (students[i].Selected == true)
                    {
                        export.Add(students[i]);
                    }
                }

            
            Data.WriteFile(export, "Export.txt");

        }
    }
}
