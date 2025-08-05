namespace Assignment3._4._1
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
            bevIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bevNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            expDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cofRoastDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isDecafDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            bevContainerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sizeInOzDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            coffeeBindingSource1 = new BindingSource(components);
            coffeeBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coffeeBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coffeeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { bevIDDataGridViewTextBoxColumn, bevNameDataGridViewTextBoxColumn, expDateDataGridViewTextBoxColumn, cofRoastDataGridViewTextBoxColumn, isDecafDataGridViewCheckBoxColumn, bevContainerDataGridViewTextBoxColumn, sizeInOzDataGridViewTextBoxColumn });
            dataGridView1.DataSource = coffeeBindingSource1;
            dataGridView1.Location = new Point(12, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(745, 279);
            dataGridView1.TabIndex = 0;
            // 
            // bevIDDataGridViewTextBoxColumn
            // 
            bevIDDataGridViewTextBoxColumn.DataPropertyName = "BevID";
            bevIDDataGridViewTextBoxColumn.HeaderText = "BevID";
            bevIDDataGridViewTextBoxColumn.Name = "bevIDDataGridViewTextBoxColumn";
            // 
            // bevNameDataGridViewTextBoxColumn
            // 
            bevNameDataGridViewTextBoxColumn.DataPropertyName = "BevName";
            bevNameDataGridViewTextBoxColumn.HeaderText = "BevName";
            bevNameDataGridViewTextBoxColumn.Name = "bevNameDataGridViewTextBoxColumn";
            // 
            // expDateDataGridViewTextBoxColumn
            // 
            expDateDataGridViewTextBoxColumn.DataPropertyName = "ExpDate";
            expDateDataGridViewTextBoxColumn.HeaderText = "ExpDate";
            expDateDataGridViewTextBoxColumn.Name = "expDateDataGridViewTextBoxColumn";
            // 
            // cofRoastDataGridViewTextBoxColumn
            // 
            cofRoastDataGridViewTextBoxColumn.DataPropertyName = "CofRoast";
            cofRoastDataGridViewTextBoxColumn.HeaderText = "CofRoast";
            cofRoastDataGridViewTextBoxColumn.Name = "cofRoastDataGridViewTextBoxColumn";
            // 
            // isDecafDataGridViewCheckBoxColumn
            // 
            isDecafDataGridViewCheckBoxColumn.DataPropertyName = "IsDecaf";
            isDecafDataGridViewCheckBoxColumn.HeaderText = "IsDecaf";
            isDecafDataGridViewCheckBoxColumn.Name = "isDecafDataGridViewCheckBoxColumn";
            // 
            // bevContainerDataGridViewTextBoxColumn
            // 
            bevContainerDataGridViewTextBoxColumn.DataPropertyName = "BevContainer";
            bevContainerDataGridViewTextBoxColumn.HeaderText = "BevContainer";
            bevContainerDataGridViewTextBoxColumn.Name = "bevContainerDataGridViewTextBoxColumn";
            // 
            // sizeInOzDataGridViewTextBoxColumn
            // 
            sizeInOzDataGridViewTextBoxColumn.DataPropertyName = "SizeInOz";
            sizeInOzDataGridViewTextBoxColumn.HeaderText = "SizeInOz";
            sizeInOzDataGridViewTextBoxColumn.Name = "sizeInOzDataGridViewTextBoxColumn";
            // 
            // coffeeBindingSource1
            // 
            coffeeBindingSource1.DataSource = typeof(Coffee);
            // 
            // coffeeBindingSource
            // 
            coffeeBindingSource.DataSource = typeof(Coffee);
            coffeeBindingSource.CurrentChanged += coffeeBindingSource_CurrentChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)coffeeBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)coffeeBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource coffeeBindingSource;
        private DataGridViewTextBoxColumn bevIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bevNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cofRoastDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isDecafDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn bevContainerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sizeInOzDataGridViewTextBoxColumn;
        private BindingSource coffeeBindingSource1;
    }
}
