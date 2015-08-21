namespace SchoolSystem.StartAndLoginScreen
{
    partial class StartScreen
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
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnStudentManagement = new System.Windows.Forms.Button();
            this.BtnFeeManagement = new System.Windows.Forms.Button();
            this.BtnExamManagement = new System.Windows.Forms.Button();
            this.BtnHRManagement = new System.Windows.Forms.Button();
            this.BtnAccountManagement = new System.Windows.Forms.Button();
            this.PasswordShowHide = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.Location = new System.Drawing.Point(155, 154);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(113, 25);
            this.UserNameLabel.TabIndex = 0;
            this.UserNameLabel.Text = "UserName";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(155, 207);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(106, 25);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Password";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameTextBox.Location = new System.Drawing.Point(281, 154);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(207, 30);
            this.UserNameTextBox.TabIndex = 1;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(281, 201);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(207, 30);
            this.PasswordTextBox.TabIndex = 2;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(413, 248);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(75, 23);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnStudentManagement
            // 
            this.BtnStudentManagement.Location = new System.Drawing.Point(40, 61);
            this.BtnStudentManagement.Name = "BtnStudentManagement";
            this.BtnStudentManagement.Size = new System.Drawing.Size(199, 47);
            this.BtnStudentManagement.TabIndex = 5;
            this.BtnStudentManagement.Text = "Student Management";
            this.BtnStudentManagement.UseVisualStyleBackColor = true;
            this.BtnStudentManagement.Click += new System.EventHandler(this.BtnStudentManagement_Click);
            // 
            // BtnFeeManagement
            // 
            this.BtnFeeManagement.Location = new System.Drawing.Point(445, 61);
            this.BtnFeeManagement.Name = "BtnFeeManagement";
            this.BtnFeeManagement.Size = new System.Drawing.Size(199, 47);
            this.BtnFeeManagement.TabIndex = 6;
            this.BtnFeeManagement.Text = "Fee Management";
            this.BtnFeeManagement.UseVisualStyleBackColor = true;
            this.BtnFeeManagement.Click += new System.EventHandler(this.BtnFeeManagement_Click);
            // 
            // BtnExamManagement
            // 
            this.BtnExamManagement.Location = new System.Drawing.Point(40, 351);
            this.BtnExamManagement.Name = "BtnExamManagement";
            this.BtnExamManagement.Size = new System.Drawing.Size(199, 47);
            this.BtnExamManagement.TabIndex = 7;
            this.BtnExamManagement.Text = "Exam Managent";
            this.BtnExamManagement.UseVisualStyleBackColor = true;
            this.BtnExamManagement.Click += new System.EventHandler(this.BtnExamManagement_Click);
            // 
            // BtnHRManagement
            // 
            this.BtnHRManagement.Location = new System.Drawing.Point(445, 351);
            this.BtnHRManagement.Name = "BtnHRManagement";
            this.BtnHRManagement.Size = new System.Drawing.Size(199, 47);
            this.BtnHRManagement.TabIndex = 8;
            this.BtnHRManagement.Text = "HR Management";
            this.BtnHRManagement.UseVisualStyleBackColor = true;
            this.BtnHRManagement.Click += new System.EventHandler(this.BtnHRManagement_Click);
            // 
            // BtnAccountManagement
            // 
            this.BtnAccountManagement.Location = new System.Drawing.Point(267, 199);
            this.BtnAccountManagement.Name = "BtnAccountManagement";
            this.BtnAccountManagement.Size = new System.Drawing.Size(199, 47);
            this.BtnAccountManagement.TabIndex = 9;
            this.BtnAccountManagement.Text = "Account Management";
            this.BtnAccountManagement.UseVisualStyleBackColor = true;
            this.BtnAccountManagement.Click += new System.EventHandler(this.BtnAccountManagement_Click);
            // 
            // PasswordShowHide
            // 
            this.PasswordShowHide.AutoSize = true;
            this.PasswordShowHide.Location = new System.Drawing.Point(495, 217);
            this.PasswordShowHide.Name = "PasswordShowHide";
            this.PasswordShowHide.Size = new System.Drawing.Size(82, 13);
            this.PasswordShowHide.TabIndex = 10;
            this.PasswordShowHide.TabStop = true;
            this.PasswordShowHide.Text = "Show password";
            this.PasswordShowHide.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(702, 430);
            this.Controls.Add(this.PasswordShowHide);
            this.Controls.Add(this.BtnAccountManagement);
            this.Controls.Add(this.BtnHRManagement);
            this.Controls.Add(this.BtnExamManagement);
            this.Controls.Add(this.BtnFeeManagement);
            this.Controls.Add(this.BtnStudentManagement);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Location = new System.Drawing.Point(100, 100);
            this.MaximumSize = new System.Drawing.Size(718, 469);
            this.MinimumSize = new System.Drawing.Size(718, 469);
            this.Name = "StartScreen";
            this.Text = "StartScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnStudentManagement;
        private System.Windows.Forms.Button BtnFeeManagement;
        private System.Windows.Forms.Button BtnExamManagement;
        private System.Windows.Forms.Button BtnHRManagement;
        private System.Windows.Forms.Button BtnAccountManagement;
        public System.Windows.Forms.TextBox UserNameTextBox;
        public System.Windows.Forms.TextBox PasswordTextBox;
        public System.Windows.Forms.Label PasswordLabel;
        public System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.LinkLabel PasswordShowHide;
    }
}