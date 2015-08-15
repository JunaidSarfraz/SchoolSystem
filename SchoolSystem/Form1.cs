using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolSystem
{
    public partial class Form1 : Form
    {
        static SchoolSystemEntities1 database = new SchoolSystemEntities1();
        public Form1()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.treeView1.SelectedNode.Expand();
            if(treeView1.SelectedNode.Name.Equals("btn_Student_Management"))
            {
                SearchStudent RequiredScreen = new SearchStudent();
                RequiredScreen.Header.Width = this.splitContainer1.Panel2.Width;
                this.splitContainer1.Panel2.Controls.Clear();
                this.splitContainer1.Panel2.Controls.Add(RequiredScreen);
            }
            else if(treeView1.SelectedNode.Name.Equals("btn_New_Admission"))
            {
                NewAdmission RequiredScreen = new NewAdmission();
                this.splitContainer1.Panel2.Controls.Clear();
                this.splitContainer1.Panel2.Controls.Add(RequiredScreen);
            }
            else if (treeView1.SelectedNode.Name.Equals("btn_Class_Wise_Strngth"))
            { 
                ClassWiseStrength RequiredScreen = new ClassWiseStrength();
                int RowNnumberTrace = 2;
                List<Class> AllClasses = database.Classes.ToList();
                AllClasses.Sort();
                RequiredScreen.tableLayoutPanel1.Controls.Add(new TextBox() { Text = "Class" }, 0, 0);
                RequiredScreen.tableLayoutPanel1.Controls.Add(new TextBox() { Text = "Section" }, 1, 0);
                RequiredScreen.tableLayoutPanel1.Controls.Add(new TextBox() { Text = "Number Of Students", Width=220 }, 2, 0);
                RequiredScreen.tableLayoutPanel1.RowCount++;
                foreach (Class c in AllClasses)
                {
                    foreach(Section s in c.Sections)
                    {
                        RequiredScreen.tableLayoutPanel1.Controls.Add(new TextBox() { Text = s.Class.Name }, 0, RowNnumberTrace);
                        RequiredScreen.tableLayoutPanel1.Controls.Add(new TextBox() { Text = s.Title }, 1, RowNnumberTrace);
                        RequiredScreen.tableLayoutPanel1.Controls.Add(new TextBox() { Text = s.Students.Count.ToString(), Width = 220 }, 2, RowNnumberTrace);
                        RequiredScreen.tableLayoutPanel1.RowCount++;
                        RowNnumberTrace++;
                    }
                }
                this.splitContainer1.Panel2.Controls.Clear();
                this.splitContainer1.Panel2.Controls.Add(RequiredScreen.tableLayoutPanel1);
            }
            else if (treeView1.SelectedNode.Name.Equals("btn_Left_Student_Details"))
            {
                this.splitContainer1.Panel2.Controls.Clear();
                leftStudentsDetail RequiredScreen = new leftStudentsDetail();
                RequiredScreen.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                List<Student> RequiredStudents = database.Students.Where(x => x.Status == false).ToList();
                RequiredStudents.Sort();
                int RowNnumberTrace = 1;
                RequiredScreen.tableLayoutPanel1.Controls.Add(new TextBox() { Text = "RollNumber" }, 0, 0);
                RequiredScreen.tableLayoutPanel1.Controls.Add(new TextBox() { Text = "Name" }, 1, 0);
                RequiredScreen.tableLayoutPanel1.Controls.Add(new TextBox() { Text = "FatherName" }, 2, 0);
                RequiredScreen.tableLayoutPanel1.Controls.Add(new TextBox() { Text = "DateOfBirth" }, 3, 0);
                RequiredScreen.tableLayoutPanel1.Controls.Add(new TextBox() { Text = "Class" }, 4, 0);
                RequiredScreen.tableLayoutPanel1.Controls.Add(new TextBox() { Text = "Section" }, 5, 0);
                RequiredScreen.tableLayoutPanel1.Controls.Add(new TextBox() { Text = "Admission Date" }, 6, 0);
                RequiredScreen.tableLayoutPanel1.Controls.Add(new TextBox() { Text = "Phone Number" }, 7, 0);
                RequiredScreen.tableLayoutPanel1.Controls.Add(new TextBox() { Text = "Address" }, 8, 0);
                RequiredScreen.tableLayoutPanel1.Controls.Add(new TextBox() { Text = "Religion" }, 9, 0);
                RequiredScreen.tableLayoutPanel1.Controls.Add(new TextBox() { Text = "Leave Date" }, 10, 0);
                foreach(Student std in RequiredStudents)
                {
                    RequiredScreen.tableLayoutPanel1.RowCount++;
                    RequiredScreen.tableLayoutPanel1.Controls.Add(new TextBox() { Text = std.RollNumber }, 0, RowNnumberTrace);
                    RequiredScreen.tableLayoutPanel1.Controls.Add(new TextBox() { Text = std.Name }, 1, RowNnumberTrace);
                    RequiredScreen.tableLayoutPanel1.Controls.Add(new TextBox() { Text = std.FatherName }, 2, RowNnumberTrace);
                    RequiredScreen.tableLayoutPanel1.Controls.Add(new TextBox() { Text = std.DateOfBirth.ToString() }, 3, RowNnumberTrace);
                    RequiredScreen.tableLayoutPanel1.Controls.Add(new TextBox() { Text = std.Section.Class.Name }, 4, RowNnumberTrace);
                    RequiredScreen.tableLayoutPanel1.Controls.Add(new TextBox() { Text = std.Section.Title }, 5, RowNnumberTrace);
                    RequiredScreen.tableLayoutPanel1.Controls.Add(new TextBox() { Text = std.AdmissionDate.ToString() }, 6, RowNnumberTrace);
                    RequiredScreen.tableLayoutPanel1.Controls.Add(new TextBox() { Text = std.PhoneNumber }, 7, RowNnumberTrace);
                    RequiredScreen.tableLayoutPanel1.Controls.Add(new TextBox() { Text = std.Address }, 8, RowNnumberTrace);
                    RequiredScreen.tableLayoutPanel1.Controls.Add(new TextBox() { Text = std.Religion }, 9, RowNnumberTrace);
                    RequiredScreen.tableLayoutPanel1.Controls.Add(new TextBox() { Text = std.LeaveDate.ToString() }, 10, RowNnumberTrace);
                    RowNnumberTrace++;
                }
                this.splitContainer1.Panel2.Controls.Add(RequiredScreen.tableLayoutPanel1);
                RequiredScreen.AutoSize = true;
                RequiredScreen.AutoScroll = true;
                RequiredScreen.tableLayoutPanel1.AutoSize = true;
                RequiredScreen.tableLayoutPanel1.AutoScroll = true;
            }
            else if (treeView1.SelectedNode.Name.Equals("btn_Attandance"))
            {
                AttandanceScreen RequiredScreen = new AttandanceScreen();
                this.splitContainer1.Panel2.Controls.Clear();
                this.splitContainer1.Panel2.Controls.Add(RequiredScreen);
            }
            else if (treeView1.SelectedNode.Name.Equals("btn_Absent_Report"))
            {
                AbsentReport RequiredScreen = new AbsentReport();
                this.splitContainer1.Panel2.Controls.Clear();
                this.splitContainer1.Panel2.Controls.Add(RequiredScreen);
            }
            else if (treeView1.SelectedNode.Name.Equals("btn_School_Leaving_Certificate"))
            {
                SchoolLeavingCertificate RequiredScreen = new SchoolLeavingCertificate();
                this.splitContainer1.Panel2.Controls.Clear();
                this.splitContainer1.Panel2.Controls.Add(RequiredScreen);
            }
            else if (treeView1.SelectedNode.Name.Equals("btn_Student_Contact"))
            {
                StudentContacts RequiredScreen = new StudentContacts();
                this.splitContainer1.Panel2.Controls.Clear();
                this.splitContainer1.Panel2.Controls.Add(RequiredScreen);
            }
            else if (treeView1.SelectedNode.Name.Equals("btn_Character_Certificate"))
            {
                CharacterCertificate RequiredScreen = new CharacterCertificate();
                this.splitContainer1.Panel2.Controls.Clear();
                this.splitContainer1.Panel2.Controls.Add(RequiredScreen);
            }
        }
    }
}