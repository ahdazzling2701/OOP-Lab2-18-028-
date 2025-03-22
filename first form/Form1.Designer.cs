namespace first_form
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            txtRoll = new TextBox();
            txtId = new TextBox();
            txtSemester = new TextBox();
            txtBlood = new TextBox();
            btnSave = new Button();
            rbtnmale = new RadioButton();
            rbtnfemale = new RadioButton();
            imagePictureBox = new PictureBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            imagepathlabel1 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)imagePictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Thistle;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 48);
            label1.Name = "label1";
            label1.Size = new Size(119, 21);
            label1.TabIndex = 0;
            label1.Text = "Student_Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Thistle;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 82);
            label2.Name = "label2";
            label2.Size = new Size(245, 21);
            label2.TabIndex = 1;
            label2.Text = "Roll_ without space or underscore";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Thistle;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 121);
            label3.Name = "label3";
            label3.Size = new Size(258, 21);
            label3.TabIndex = 2;
            label3.Text = "Reg_Id without space or underscore";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Thistle;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(32, 160);
            label4.Name = "label4";
            label4.Size = new Size(86, 21);
            label4.TabIndex = 3;
            label4.Text = "Semester _";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Thistle;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(32, 205);
            label5.Name = "label5";
            label5.Size = new Size(108, 21);
            label5.TabIndex = 4;
            label5.Text = "Blood_Group_";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Thistle;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(32, 242);
            label6.Name = "label6";
            label6.Size = new Size(68, 21);
            label6.TabIndex = 5;
            label6.Text = "Gender_";
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.ButtonFace;
            txtName.Location = new Point(300, 48);
            txtName.Name = "txtName";
            txtName.Size = new Size(301, 23);
            txtName.TabIndex = 6;
            // 
            // txtRoll
            // 
            txtRoll.BackColor = SystemColors.ButtonFace;
            txtRoll.Location = new Point(300, 80);
            txtRoll.Name = "txtRoll";
            txtRoll.Size = new Size(301, 23);
            txtRoll.TabIndex = 7;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ButtonFace;
            txtId.Location = new Point(300, 121);
            txtId.Name = "txtId";
            txtId.Size = new Size(301, 23);
            txtId.TabIndex = 8;
            // 
            // txtSemester
            // 
            txtSemester.BackColor = SystemColors.ButtonFace;
            txtSemester.Location = new Point(300, 162);
            txtSemester.Name = "txtSemester";
            txtSemester.Size = new Size(301, 23);
            txtSemester.TabIndex = 9;
            // 
            // txtBlood
            // 
            txtBlood.BackColor = SystemColors.ButtonFace;
            txtBlood.Location = new Point(300, 205);
            txtBlood.Name = "txtBlood";
            txtBlood.Size = new Size(301, 23);
            txtBlood.TabIndex = 10;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Green;
            btnSave.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(365, 307);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(169, 43);
            btnSave.TabIndex = 11;
            btnSave.Text = "Submit";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // rbtnmale
            // 
            rbtnmale.AutoSize = true;
            rbtnmale.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbtnmale.Location = new Point(300, 245);
            rbtnmale.Name = "rbtnmale";
            rbtnmale.Size = new Size(54, 21);
            rbtnmale.TabIndex = 12;
            rbtnmale.TabStop = true;
            rbtnmale.Text = "male";
            rbtnmale.UseVisualStyleBackColor = true;
            // 
            // rbtnfemale
            // 
            rbtnfemale.AutoSize = true;
            rbtnfemale.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbtnfemale.Location = new Point(476, 245);
            rbtnfemale.Name = "rbtnfemale";
            rbtnfemale.Size = new Size(67, 21);
            rbtnfemale.TabIndex = 13;
            rbtnfemale.TabStop = true;
            rbtnfemale.Text = "Female";
            rbtnfemale.UseVisualStyleBackColor = true;
            // 
            // imagePictureBox
            // 
            imagePictureBox.Location = new Point(666, 62);
            imagePictureBox.Name = "imagePictureBox";
            imagePictureBox.Size = new Size(149, 138);
            imagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            imagePictureBox.TabIndex = 14;
            imagePictureBox.TabStop = false;
            imagePictureBox.Click += imagePictureBox_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(666, 44);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 15;
            label7.Text = "image";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(657, 203);
            label8.Name = "label8";
            label8.Size = new Size(77, 17);
            label8.TabIndex = 16;
            label8.Text = "image path:";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(764, 202);
            label9.Name = "label9";
            label9.Size = new Size(51, 17);
            label9.TabIndex = 17;
            label9.Text = "browse";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(601, 200);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 18;
            // 
            // imagepathlabel1
            // 
            imagepathlabel1.AutoSize = true;
            imagepathlabel1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            imagepathlabel1.Location = new Point(709, 264);
            imagepathlabel1.Name = "imagepathlabel1";
            imagepathlabel1.Size = new Size(89, 17);
            imagepathlabel1.TabIndex = 19;
            imagepathlabel1.Text = "Upload Photo";
            imagepathlabel1.Click += imagepathlabel1_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label11.Location = new Point(300, 8);
            label11.Name = "label11";
            label11.Size = new Size(189, 30);
            label11.TabIndex = 20;
            label11.Text = "Registration Form";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(827, 362);
            Controls.Add(label11);
            Controls.Add(imagepathlabel1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(imagePictureBox);
            Controls.Add(rbtnfemale);
            Controls.Add(rbtnmale);
            Controls.Add(btnSave);
            Controls.Add(txtBlood);
            Controls.Add(txtSemester);
            Controls.Add(txtId);
            Controls.Add(txtRoll);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Registration Form";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)imagePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnSave;
        private PictureBox imagePictureBox;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label imagepathlabel1;
        public TextBox txtName;
        public TextBox txtRoll;
        public TextBox txtId;
        public TextBox txtSemester;
        public TextBox txtBlood;
        public RadioButton rbtnmale;
        public RadioButton rbtnfemale;
        private Label label11;
    }
}
