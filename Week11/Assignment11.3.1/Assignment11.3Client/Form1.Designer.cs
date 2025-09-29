namespace Assignment11._3Client
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
            bookGrid = new DataGridView();
            btnGetBook = new Button();
            btnAddBook = new Button();
            txtBoxID = new TextBox();
            txtBoxTitle = new TextBox();
            txtBoxAuthor = new TextBox();
            txtBoxDate = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)bookGrid).BeginInit();
            SuspendLayout();
            // 
            // bookGrid
            // 
            bookGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookGrid.Location = new Point(69, 10);
            bookGrid.Name = "bookGrid";
            bookGrid.Size = new Size(677, 293);
            bookGrid.TabIndex = 0;
            // 
            // btnGetBook
            // 
            btnGetBook.Location = new Point(69, 347);
            btnGetBook.Name = "btnGetBook";
            btnGetBook.Size = new Size(75, 23);
            btnGetBook.TabIndex = 1;
            btnGetBook.Text = "Get Books";
            btnGetBook.UseVisualStyleBackColor = true;
            btnGetBook.Click += btnGetBook_Click;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(69, 377);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(75, 23);
            btnAddBook.TabIndex = 3;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // txtBoxID
            // 
            txtBoxID.Location = new Point(244, 348);
            txtBoxID.Name = "txtBoxID";
            txtBoxID.Size = new Size(100, 23);
            txtBoxID.TabIndex = 4;
            txtBoxID.TextChanged += txtBoxID_TextChanged;
            // 
            // txtBoxTitle
            // 
            txtBoxTitle.Location = new Point(244, 377);
            txtBoxTitle.Name = "txtBoxTitle";
            txtBoxTitle.Size = new Size(100, 23);
            txtBoxTitle.TabIndex = 5;
            // 
            // txtBoxAuthor
            // 
            txtBoxAuthor.Location = new Point(431, 348);
            txtBoxAuthor.Name = "txtBoxAuthor";
            txtBoxAuthor.Size = new Size(100, 23);
            txtBoxAuthor.TabIndex = 6;
            // 
            // txtBoxDate
            // 
            txtBoxDate.Location = new Point(431, 377);
            txtBoxDate.Name = "txtBoxDate";
            txtBoxDate.Size = new Size(100, 23);
            txtBoxDate.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(200, 351);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 8;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(387, 353);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 9;
            label2.Text = "Author";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(200, 385);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 10;
            label3.Text = "Title";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(387, 385);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 11;
            label4.Text = "Date";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(596, 349);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBoxDate);
            Controls.Add(txtBoxAuthor);
            Controls.Add(txtBoxTitle);
            Controls.Add(txtBoxID);
            Controls.Add(btnAddBook);
            Controls.Add(btnGetBook);
            Controls.Add(bookGrid);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bookGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView bookGrid;
        private Button btnGetBook;
        private Button btnAddBook;
        private TextBox txtBoxID;
        private TextBox txtBoxTitle;
        private TextBox txtBoxAuthor;
        private TextBox txtBoxDate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnDelete;
    }
}
