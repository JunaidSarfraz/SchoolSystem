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
            InitializeComponent();
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(treeView1.SelectedNode.Name.Equals("btn_New_Admission"))
            {
                NewAdmission RequiredScreen = new NewAdmission();
                this.splitContainer1.Panel2.Controls.Clear();
                this.splitContainer1.Panel2.Controls.Add(RequiredScreen);
            }
            else if (treeView1.SelectedNode.Name.Equals("btn_Class_Wise_Strngth"))
            { 
                ClassWiseStrength ReportResult = new ClassWiseStrength();
                int RowNnumberTrace = 0;
                List<Class> AllClasses = database.Classes.ToList();
                AllClasses.Sort();
                foreach (Class c in AllClasses)
                {
                    foreach(Section s in c.Sections)
                    {
                        ReportResult.tableLayoutPanel1.RowCount++;
                        ReportResult.tableLayoutPanel1.Controls.Add(new Label { Text = s.Class.Name} , 0, RowNnumberTrace);
                        ReportResult.tableLayoutPanel1.Controls.Add(new Label { Text = s.Title }, 1, RowNnumberTrace);
                        ReportResult.tableLayoutPanel1.Controls.Add(new Label { Text = s.Students.Count.ToString() }, 2, RowNnumberTrace);
                        RowNnumberTrace++;
                    }
                }
                this.splitContainer1.Panel2.Controls.Clear();
                this.splitContainer1.Panel2.Controls.Add(ReportResult);
            }
            else if (treeView1.SelectedNode.Name.Equals("btn_Left_Student_Details"))
            {
                leftStudentsDetail RequiredScreen = new leftStudentsDetail();
                this.splitContainer1.Panel2.Controls.Clear();
                this.splitContainer1.Panel2.Controls.Add(RequiredScreen);
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