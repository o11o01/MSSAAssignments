namespace Assignment4._1._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mobilePhoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            workPhoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            personBindingSource1 = new BindingSource(components);
            personBindingSource = new BindingSource(components);
            buttonAddData = new Button();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            textBoxAddress = new TextBox();
            textBoxWorkPhone = new TextBox();
            textBoxMobilePhone = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            buttonDelete = new Button();
            textBox4 = new TextBox();
            buttonSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, mobilePhoneDataGridViewTextBoxColumn, workPhoneDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn });
            dataGridView1.DataSource = personBindingSource1;
            dataGridView1.Location = new Point(80, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(632, 150);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // mobilePhoneDataGridViewTextBoxColumn
            // 
            mobilePhoneDataGridViewTextBoxColumn.DataPropertyName = "MobilePhone";
            mobilePhoneDataGridViewTextBoxColumn.HeaderText = "MobilePhone";
            mobilePhoneDataGridViewTextBoxColumn.Name = "mobilePhoneDataGridViewTextBoxColumn";
            // 
            // workPhoneDataGridViewTextBoxColumn
            // 
            workPhoneDataGridViewTextBoxColumn.DataPropertyName = "WorkPhone";
            workPhoneDataGridViewTextBoxColumn.HeaderText = "WorkPhone";
            workPhoneDataGridViewTextBoxColumn.Name = "workPhoneDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // personBindingSource1
            // 
            personBindingSource1.DataSource = typeof(Person);
            // 
            // personBindingSource
            // 
            personBindingSource.DataSource = typeof(Person);
            // 
            // buttonAddData
            // 
            buttonAddData.Location = new Point(672, 217);
            buttonAddData.Name = "buttonAddData";
            buttonAddData.Size = new Size(75, 23);
            buttonAddData.TabIndex = 6;
            buttonAddData.Text = "Add Data";
            buttonAddData.UseVisualStyleBackColor = true;
            buttonAddData.Click += buttonAddData_Click;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.AccessibleDescription = "";
            textBoxFirstName.Location = new Point(115, 217);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.PlaceholderText = "First Name";
            textBoxFirstName.Size = new Size(100, 23);
            textBoxFirstName.TabIndex = 1;
            textBoxFirstName.Tag = "";
            textBoxFirstName.TextChanged += textBoxFirstName_TextChanged;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(221, 217);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.PlaceholderText = "Last Name";
            textBoxLastName.Size = new Size(100, 23);
            textBoxLastName.TabIndex = 2;
            textBoxLastName.TextChanged += textBoxLastName_TextChanged;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(539, 216);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.PlaceholderText = "Address";
            textBoxAddress.Size = new Size(100, 23);
            textBoxAddress.TabIndex = 5;
            textBoxAddress.TextChanged += textBoxAddress_TextChanged;
            // 
            // textBoxWorkPhone
            // 
            textBoxWorkPhone.Location = new Point(433, 217);
            textBoxWorkPhone.Name = "textBoxWorkPhone";
            textBoxWorkPhone.PlaceholderText = "Work Phone";
            textBoxWorkPhone.Size = new Size(100, 23);
            textBoxWorkPhone.TabIndex = 4;
            textBoxWorkPhone.TextChanged += textBoxWorkPhone_TextChanged;
            // 
            // textBoxMobilePhone
            // 
            textBoxMobilePhone.Location = new Point(327, 217);
            textBoxMobilePhone.Name = "textBoxMobilePhone";
            textBoxMobilePhone.PlaceholderText = "Mobile Phone";
            textBoxMobilePhone.Size = new Size(100, 23);
            textBoxMobilePhone.TabIndex = 3;
            textBoxMobilePhone.TextChanged += textBoxMobilePhone_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(221, 281);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Last Name";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 8;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(115, 281);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "First Name";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 9;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(327, 281);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 10;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(115, 343);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Name";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 11;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(327, 342);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 23);
            buttonSearch.TabIndex = 12;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSearch);
            Controls.Add(textBox4);
            Controls.Add(buttonDelete);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(textBoxMobilePhone);
            Controls.Add(textBoxWorkPhone);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(buttonAddData);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)personBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)personBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource personBindingSource;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mobilePhoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn workPhoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private Button buttonAddData;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private TextBox textBoxAddress;
        private TextBox textBoxWorkPhone;
        private TextBox textBoxMobilePhone;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button buttonDelete;
        private TextBox textBox4;
        private Button buttonSearch;
        private BindingSource personBindingSource1;
    }
}
