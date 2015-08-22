using SchoolSystem.Exam_Management;
using SchoolSystem.Fee_Management;
using SchoolSystem.Staff_Management;
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
        private void Form1Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        static SchoolSystemEntities1 database = new SchoolSystemEntities1();
        public Form1()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            this.treeView1.Width = this.treeView1.Width - 20;
            this.FormClosed += Form1Closed;
            this.Refresh();
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
            else if (treeView1.SelectedNode.Name.Equals("btn_Fee_Management"))
            {
                FeeManagementMainPage RequiredScreen = new FeeManagementMainPage();
                this.splitContainer1.Panel2.Controls.Clear();
                this.splitContainer1.Panel2.Controls.Add(RequiredScreen);
            }
            else if (treeView1.SelectedNode.Name.Equals("btn_Class_Wise_Fee_Structure"))
            {
                ClassWiseFeeStructure RequiredScreen = new ClassWiseFeeStructure();
                this.splitContainer1.Panel2.Controls.Clear();
                this.splitContainer1.Panel2.Controls.Add(RequiredScreen);
            }
            else if (treeView1.SelectedNode.Name.Equals("btn_Fee_Voucher"))
            {
                FeeVoucher RequiredScreen = new FeeVoucher();
                this.splitContainer1.Panel2.Controls.Clear();
                this.splitContainer1.Panel2.Controls.Add(RequiredScreen);
            }
            else if (treeView1.SelectedNode.Name.Equals("btn_Fee_Collection_Report"))
            {
                FeeCollectionReport RequiredScreen = new FeeCollectionReport();
                this.splitContainer1.Panel2.Controls.Clear();
                this.splitContainer1.Panel2.Controls.Add(RequiredScreen);
            }
            else if (treeView1.SelectedNode.Name.Equals("btn_Auto_Fee_Calculation"))
            {
                FeeCalculation RequiredScreen = new FeeCalculation();
                this.splitContainer1.Panel2.Controls.Clear();
                this.splitContainer1.Panel2.Controls.Add(RequiredScreen);
            }
            else if (treeView1.SelectedNode.Name.Equals("btn_Defaulter_List"))
            {
                DefaulterList RequiredScreen = new DefaulterList();
                this.splitContainer1.Panel2.Controls.Clear();
                this.splitContainer1.Panel2.Controls.Add(RequiredScreen);
            }
            else if (treeView1.SelectedNode.Name.Equals("btn_Concession_Report"))
            {
                ConcessionReport RequiredScreen = new ConcessionReport();
                this.splitContainer1.Panel2.Controls.Clear();
                this.splitContainer1.Panel2.Controls.Add(RequiredScreen);
            }
            else if (treeView1.SelectedNode.Name.Equals("btn_Customizable_Fee_Structure"))
            {
                FeeStructure RequiredScreen = new FeeStructure();
                this.splitContainer1.Panel2.Controls.Clear();
                this.splitContainer1.Panel2.Controls.Add(RequiredScreen);
            }
            else if (treeView1.SelectedNode.Name.Equals("btn_Student_Fee_History"))
            {
                StudentFeeHistory RequiredScreen = new StudentFeeHistory();
                this.splitContainer1.Panel2.Controls.Clear();
                this.splitContainer1.Panel2.Controls.Add(RequiredScreen);
            }
            else if (treeView1.SelectedNode.Name.Equals("btn_Income_Report"))
            {
                MonthlyIncomeReport RequiredScreen = new MonthlyIncomeReport();
                this.splitContainer1.Panel2.Controls.Clear();
                this.splitContainer1.Panel2.Controls.Add(RequiredScreen);
            }
            else if (treeView1.SelectedNode.Name.Equals("btn_Other_Fee_Support"))
            {
                OtherFeeSupport RequiredScreen = new OtherFeeSupport();
                this.splitContainer1.Panel2.Controls.Clear();
                this.splitContainer1.Panel2.Controls.Add(RequiredScreen);
            }
            else if (treeView1.SelectedNode.Name.Equals("btn_Fee_Change_System"))
            {
                FeeChangeSystem RequiredScreen = new FeeChangeSystem();
                this.splitContainer1.Panel2.Controls.Clear();
                this.splitContainer1.Panel2.Controls.Add(RequiredScreen);
            }
            else if (treeView1.SelectedNode.Name.Equals("btn_SMS_To_Defaulters"))
            {
                SMSToDefaulters RequiredScreen = new SMSToDefaulters();
                this.splitContainer1.Panel2.Controls.Clear();
                this.splitContainer1.Panel2.Controls.Add(RequiredScreen);
            }
            else if (treeView1.SelectedNode.Name.Equals("btn_Exam_Management"))
            {
                ExamManagementMainPage RequiredScreen = new ExamManagementMainPage();
                this.splitContainer1.Panel2.Controls.Clear();
                this.splitContainer1.Panel2.Controls.Add(RequiredScreen);
            }
            else if (treeView1.SelectedNode.Name.Equals("btn_ClassWise_Schedule"))
            {
                ClassWiseExamSchedule RequiredScreen = new ClassWiseExamSchedule();
                this.splitContainer1.Panel2.Controls.Clear();
                this.splitContainer1.Panel2.Controls.Add(RequiredScreen);
            }
            else if (treeView1.SelectedNode.Name.Equals("btn_ClassWise_Result"))
            {
                ClassWiseResult RequiredScreen = new ClassWiseResult();
                this.splitContainer1.Panel2.Controls.Clear();
                this.splitContainer1.Panel2.Controls.Add(RequiredScreen);
            }
            else if (treeView1.SelectedNode.Name.Equals("btn_ClassWise_Best_Student"))
            {
                ClassWIseBestStudent RequiredScreen = new ClassWIseBestStudent();
                this.splitContainer1.Panel2.Controls.Clear();
                this.splitContainer1.Panel2.Controls.Add(RequiredScreen);
            }
            else if (treeView1.SelectedNode.Name.Equals("btn_TermWise_Result_Card"))
            {
                TermWiseResultCard RequiredScreen = new TermWiseResultCard();
                this.splitContainer1.Panel2.Controls.Clear();
                this.splitContainer1.Panel2.Controls.Add(RequiredScreen);
            }
            else if (treeView1.SelectedNode.Name.Equals("btn_Result_Card_Generation"))
            {
                OverallResultCard RequiredScreen = new OverallResultCard();
                this.splitContainer1.Panel2.Controls.Clear();
                this.splitContainer1.Panel2.Controls.Add(RequiredScreen);
            }
            else if (treeView1.SelectedNode.Name.Equals("btn_Progress_Report"))
            {
                ProgressReport RequiredScreen = new ProgressReport();
                this.splitContainer1.Panel2.Controls.Clear();
                this.splitContainer1.Panel2.Controls.Add(RequiredScreen);
            }
            else if (treeView1.SelectedNode.Name.Equals("btn_Overall_Result_Of_School"))
            {
                OverallResultOfSchool RequiredScreen = new OverallResultOfSchool();
                this.splitContainer1.Panel2.Controls.Clear();
                this.splitContainer1.Panel2.Controls.Add(RequiredScreen);
            }
            else if (treeView1.SelectedNode.Name.Equals("btn_DateSheet_Of_Examination"))
            {
                DateSheet RequiredScreen = new DateSheet();
                this.splitContainer1.Panel2.Controls.Clear();
                this.splitContainer1.Panel2.Controls.Add(RequiredScreen);
            }
            else if (treeView1.SelectedNode.Name.Equals("btn_Staff_Management"))
            {
                StaffManagementMainPage RequiredScreen = new StaffManagementMainPage();
                this.splitContainer1.Panel2.Controls.Clear();
                this.splitContainer1.Panel2.Controls.Add(RequiredScreen);
            }
            else if (treeView1.SelectedNode.Name.Equals("btn_Staff_Attandance"))
            {
                StaffAttandance RequiredScreen = new StaffAttandance();
                this.splitContainer1.Panel2.Controls.Clear();
                this.splitContainer1.Panel2.Controls.Add(RequiredScreen);
            }
            else if (treeView1.SelectedNode.Name.Equals("btn_Staff_Registration"))
            {
                RegistrationForm RequiredScreen = new RegistrationForm();
                this.splitContainer1.Panel2.Controls.Clear();
                this.splitContainer1.Panel2.Controls.Add(RequiredScreen);
            }
            else if (treeView1.SelectedNode.Name.Equals("btn_Monthly_Attandance_Report"))
            {
                MonthlyAttandanceReport RequiredScreen = new MonthlyAttandanceReport();
                this.splitContainer1.Panel2.Controls.Clear();
                this.splitContainer1.Panel2.Controls.Add(RequiredScreen);
            }
            else if (treeView1.SelectedNode.Name.Equals("btn_Employee_Salary"))
            {
                EmployeeSalary RequiredScreen = new EmployeeSalary();
                this.splitContainer1.Panel2.Controls.Clear();
                this.splitContainer1.Panel2.Controls.Add(RequiredScreen);
            }
            else if (treeView1.SelectedNode.Name.Equals("btn_Staff_Salary_Sheet"))
            {
                StaffSalarySheet RequiredScreen = new StaffSalarySheet();
                this.splitContainer1.Panel2.Controls.Clear();
                this.splitContainer1.Panel2.Controls.Add(RequiredScreen);
            }
            else if (treeView1.SelectedNode.Name.Equals("btn_Experience_Certificate"))
            {
                ExperienceCertificate RequiredScreen = new ExperienceCertificate();
                this.splitContainer1.Panel2.Controls.Clear();
                this.splitContainer1.Panel2.Controls.Add(RequiredScreen);
            }
            else if (treeView1.SelectedNode.Name.Equals("btn_Time_Table_Of_Employee"))
            {
                TimeTableOfEmployees RequiredScreen = new TimeTableOfEmployees();
                this.splitContainer1.Panel2.Controls.Clear();
                this.splitContainer1.Panel2.Controls.Add(RequiredScreen);
            }
        }
    }
}