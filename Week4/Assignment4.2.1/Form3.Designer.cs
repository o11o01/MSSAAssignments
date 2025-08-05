namespace Assignment4._2._1
{
    partial class Form3
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
            inputID = new TextBox();
            inputFirstName = new TextBox();
            inputLastName = new TextBox();
            inputGPA = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            addStudent = new Button();
            SuspendLayout();
            // 
            // inputID
            // 
            inputID.Location = new Point(103, 41);
            inputID.Name = "inputID";
            inputID.Size = new Size(125, 23);
            inputID.TabIndex = 0;
            inputID.TextChanged += inputID_TextChanged;
            // 
            // inputFirstName
            // 
            inputFirstName.Location = new Point(103, 70);
            inputFirstName.Name = "inputFirstName";
            inputFirstName.Size = new Size(125, 23);
            inputFirstName.TabIndex = 1;
            // 
            // inputLastName
            // 
            inputLastName.Location = new Point(103, 99);
            inputLastName.Name = "inputLastName";
            inputLastName.Size = new Size(125, 23);
            inputLastName.TabIndex = 2;
            inputLastName.TextChanged += textBox3_TextChanged;
            // 
            // inputGPA
            // 
            inputGPA.Location = new Point(103, 128);
            inputGPA.Name = "inputGPA";
            inputGPA.Size = new Size(125, 23);
            inputGPA.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 49);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 4;
            label1.Text = "StudentID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 78);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 5;
            label2.Text = "First Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 107);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 6;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 136);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 7;
            label4.Text = "GPA";
            // 
            // addStudent
            // 
            addStudent.Location = new Point(262, 128);
            addStudent.Name = "addStudent";
            addStudent.Size = new Size(75, 23);
            addStudent.TabIndex = 8;
            addStudent.Text = "Add";
            addStudent.UseVisualStyleBackColor = true;
            addStudent.Click += addStudent_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 237);
            Controls.Add(addStudent);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(inputGPA);
            Controls.Add(inputLastName);
            Controls.Add(inputFirstName);
            Controls.Add(inputID);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputID;
        private TextBox inputFirstName;
        private TextBox inputLastName;
        private TextBox inputGPA;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button addStudent;
    }
}