namespace Assignment_10._3._1
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
            dataGridView1 = new DataGridView();
            textBoxVin = new TextBox();
            labelVin = new Label();
            labelManufacture = new Label();
            labelModel = new Label();
            textBoxManufacture = new TextBox();
            textBoxModel = new TextBox();
            labelPrice = new Label();
            textBoxPrice = new TextBox();
            buttonSearch = new Button();
            buttonAddCar = new Button();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(522, 310);
            dataGridView1.TabIndex = 0;
            
            // 
            // textBoxVin
            // 
            textBoxVin.Location = new Point(620, 9);
            textBoxVin.Name = "textBoxVin";
            textBoxVin.Size = new Size(100, 23);
            textBoxVin.TabIndex = 1;
            
            // 
            // labelVin
            // 
            labelVin.AutoSize = true;
            labelVin.Location = new Point(561, 17);
            labelVin.Name = "labelVin";
            labelVin.Size = new Size(26, 15);
            labelVin.TabIndex = 2;
            labelVin.Text = "VIN";
            // 
            // labelManufacture
            // 
            labelManufacture.AutoSize = true;
            labelManufacture.Location = new Point(556, 46);
            labelManufacture.Name = "labelManufacture";
            labelManufacture.Size = new Size(36, 15);
            labelManufacture.TabIndex = 3;
            labelManufacture.Text = "Make";
            // 
            // labelModel
            // 
            labelModel.AutoSize = true;
            labelModel.Location = new Point(554, 83);
            labelModel.Name = "labelModel";
            labelModel.Size = new Size(41, 15);
            labelModel.TabIndex = 4;
            labelModel.Text = "Model";
            // 
            // textBoxManufacture
            // 
            textBoxManufacture.Location = new Point(620, 38);
            textBoxManufacture.Name = "textBoxManufacture";
            textBoxManufacture.Size = new Size(100, 23);
            textBoxManufacture.TabIndex = 5;
            // 
            // textBoxModel
            // 
            textBoxModel.Location = new Point(620, 75);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(100, 23);
            textBoxModel.TabIndex = 6;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(559, 119);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(33, 15);
            labelPrice.TabIndex = 7;
            labelPrice.Text = "Price";
            
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(620, 111);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(100, 23);
            textBoxPrice.TabIndex = 8;
            
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(677, 415);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 23);
            buttonSearch.TabIndex = 9;
            buttonSearch.Text = "SearchVin";
            buttonSearch.UseVisualStyleBackColor = true;
            
            // 
            // buttonAddCar
            // 
            buttonAddCar.Location = new Point(645, 193);
            buttonAddCar.Name = "buttonAddCar";
            buttonAddCar.Size = new Size(75, 23);
            buttonAddCar.TabIndex = 10;
            buttonAddCar.Text = "AddCar";
            buttonAddCar.UseVisualStyleBackColor = true;
            buttonAddCar.Click += buttonAddCar_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(554, 193);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 11;
            buttonDelete.Text = "DeleteCar";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(554, 231);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(75, 23);
            buttonUpdate.TabIndex = 12;
            buttonUpdate.Text = "UpdateCar";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAddCar);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxPrice);
            Controls.Add(labelPrice);
            Controls.Add(textBoxModel);
            Controls.Add(textBoxManufacture);
            Controls.Add(labelModel);
            Controls.Add(labelManufacture);
            Controls.Add(labelVin);
            Controls.Add(textBoxVin);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBoxVin;
        private Label labelVin;
        private Label labelManufacture;
        private Label labelModel;
        private TextBox textBoxManufacture;
        private TextBox textBoxModel;
        private Label labelPrice;
        private TextBox textBoxPrice;
        private Button buttonSearch;
        private Button buttonAddCar;
        private Button buttonDelete;
        private Button buttonUpdate;
    }
}
