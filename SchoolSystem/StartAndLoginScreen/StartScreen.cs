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

            if (database.Users.Where(X => X.UserName.Equals(UserName) && X.Password.Equals(Password)).Count() == 0)
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
                this.PasswordShowHide.Visible = false;

                this.BtnAccountManagement.Visible = true;
                this.BtnExamManagement.Visible = true;
                this.BtnFeeManagement.Visible = true;
                this.BtnHRManagement.Visible = true;
                this.BtnStudentManagement.Visible = true;
                this.Refresh();
            }
        }

        private void BtnStudentManagement_Click(object sender, EventArgs e)
        {
            Form1 MainScreen = new Form1();
            MainScreen.treeView1.SelectedNode = MainScreen.treeView1.Nodes[0];
            this.Hide();
            MainScreen.Show();
        }

        private void BtnFeeManagement_Click(object sender, EventArgs e)
        {
            Form1 MainScreen = new Form1();
            MainScreen.treeView1.SelectedNode = MainScreen.treeView1.Nodes[1];
            this.Hide();
            MainScreen.Show();
        }

        private void BtnAccountManagement_Click(object sender, EventArgs e)
        {
            Form1 MainScreen = new Form1();
            MainScreen.treeView1.SelectedNode = MainScreen.treeView1.Nodes[4];
            this.Hide();
            MainScreen.Show();
        }

        private void BtnExamManagement_Click(object sender, EventArgs e)
        {
            Form1 MainScreen = new Form1();
            MainScreen.treeView1.SelectedNode = MainScreen.treeView1.Nodes[2];
            this.Hide();
            MainScreen.Show();
        }

        private void BtnHRManagement_Click(object sender, EventArgs e)
        {
            Form1 MainScreen = new Form1();
            MainScreen.treeView1.SelectedNode = MainScreen.treeView1.Nodes[3];
            this.Hide();
            MainScreen.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.PasswordTextBox.PasswordChar == '*')
            {
                this.PasswordTextBox.PasswordChar = '\0';
                this.PasswordShowHide.Text = "Hide Password";
                this.Refresh();
            }
            else if (this.PasswordTextBox.PasswordChar == '\0')
            {
                this.PasswordTextBox.PasswordChar = '*';
                this.PasswordShowHide.Text = "Hide Password";
                this.Refresh();
            }
        }
    }
}
