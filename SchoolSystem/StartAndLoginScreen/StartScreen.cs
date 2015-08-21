using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SchoolSystem.StartAndLoginScreen
{
    public partial class StartScreen : Form
    {
        SchoolSystemEntities1 database = new SchoolSystemEntities1();
        
        public StartScreen()
        {
            InitializeComponent();
            this.BtnAccountManagement.Visible = false;
            this.BtnExamManagement.Visible = false;
            this.BtnFeeManagement.Visible = false;
            this.BtnHRManagement.Visible = false;
            this.BtnStudentManagement.Visible = false;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            String UserName = this.UserNameTextBox.Text;
            String Password = this.PasswordTextBox.Text;

            if (database.Users.Where(X => X.UserName.Equals(UserName) && X.Password.Equals(Password)).First() == null)
            {
                MessageBox.Show("Username or password is not correct");
            }
            else
            {
                this.PasswordTextBox.Visible = false;
                this.UserNameTextBox.Visible = false;
                this.UserNameLabel.Visible = false;
                this.PasswordLabel.Visible = false;
                this.BtnLogin.Visible = false;

                this.BtnAccountManagement.Visible = true;
                this.BtnExamManagement.Visible = true;
                this.BtnFeeManagement.Visible = true;
                this.BtnHRManagement.Visible = true;
                this.BtnStudentManagement.Visible = true;
                this.Refresh();
            }
        }
    }
}
