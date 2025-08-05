namespace Assignment4._2._1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            AddStudent = new Button();
            dataGridView1 = new DataGridView();
            studentIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewCheckBoxColumn();
            studentBindingSource1 = new BindingSource(components);
            studentBindingSource = new BindingSource(components);
            Refresh = new Button();
            buttonDelete = new Button();
            buttonExport = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            SuspendLayout();
            // 
            // AddStudent
            // 
            AddStudent.Location = new Point(569, 383);
            AddStudent.Name = "AddStudent";
            AddStudent.Size = new Size(101, 55);
            AddStudent.TabIndex = 0;
            AddStudent.Text = "AddStudent";
            AddStudent.UseVisualStyleBackColor = true;
            AddStudent.Click += AddStudent_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { studentIDDataGridViewTextBoxColumn, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, Column1 });
            dataGridView1.DataSource = studentBindingSource1;
            dataGridView1.Location = new Point(12, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(539, 438);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            studentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "FirstName";
            dataGridViewTextBoxColumn1.HeaderText = "FirstName";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "LastName";
            dataGridViewTextBoxColumn2.HeaderText = "LastName";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "GradeAverage";
            dataGridViewTextBoxColumn3.HeaderText = "GradeAverage";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Delete";
            Column1.Name = "Column1";
            Column1.Resizable = DataGridViewTriState.True;
            Column1.Width = 50;
            // 
            // studentBindingSource1
            // 
            studentBindingSource1.DataSource = typeof(Student);
            studentBindingSource1.CurrentChanged += studentBindingSource1_CurrentChanged;
            // 
            // studentBindingSource
            // 
            studentBindingSource.DataSource = typeof(Student);
            studentBindingSource.CurrentChanged += studentBindingSource_CurrentChanged;
            // 
            // Refresh
            // 
            Refresh.Location = new Point(690, 383);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(98, 55);
            Refresh.TabIndex = 2;
            Refresh.Text = "Sort";
            Refresh.UseVisualStyleBackColor = true;
            Refresh.Click += Refresh_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(690, 322);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(101, 55);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonExport
            // 
            buttonExport.Location = new Point(569, 322);
            buttonExport.Name = "buttonExport";
            buttonExport.Size = new Size(101, 55);
            buttonExport.TabIndex = 4;
            buttonExport.Text = "Export";
            buttonExport.UseVisualStyleBackColor = true;
            buttonExport.Click += buttonExport_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonExport);
            Controls.Add(buttonDelete);
            Controls.Add(Refresh);
            Controls.Add(dataGridView1);
            Controls.Add(AddStudent);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button AddStudent;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gradeAverageDataGridViewTextBoxColumn;
        private BindingSource studentBindingSource;
        private BindingSource studentBindingSource1;
        private Button Refresh;
        public DataGridView dataGridView1;
        private Button buttonDelete;
        private DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewCheckBoxColumn Column1;
        private Button buttonExport;
    }
}