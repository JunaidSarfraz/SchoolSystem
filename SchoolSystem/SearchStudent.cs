using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SchoolSystem
{
    public partial class SearchStudent : UserControl
    {
        static SchoolSystemEntities1 database = new SchoolSystemEntities1();
        public SearchStudent()
        {
            InitializeComponent();
            this.label5.Text = "";
        }

        private void BtnSearchStudent_Click(object sender, EventArgs e)
        {
            this.label5.Text = "Please Wait..."; // Label with no record Found
            this.tableLayoutPanel1.Controls.Clear();
            this.Refresh();
            String RollNumber = this.TxtRollNumber.Text;
            String Name = this.TxtName.Text;
            String FatherName = this.TxtFatherName.Text;
            String Phone = this.TxtPhoneNumber.Text;
            String ClassName = "";
            if(this.ClassComboBox.SelectedItem != null)
                ClassName = this.ClassComboBox.SelectedItem.ToString();
            String SectionName = "";
            if(this.SectionComboBox.SelectedItem != null)
                SectionName = this.SectionComboBox.SelectedItem.ToString();
            List<Student> RequiredStudents = database.Students.ToList();
            if(!RollNumber.Equals(""))
            {
                RequiredStudents = RequiredStudents.Where(x => x.RollNumber == RollNumber).ToList();
            }
            if(!Name.Equals(""))
            {
                RequiredStudents = RequiredStudents.Where(x => x.Name == Name).ToList();
            }
            if (!FatherName.Equals(""))
            {
                RequiredStudents = RequiredStudents.Where(x => x.FatherName == FatherName).ToList();
            }
            if (!Phone.Equals(""))
            {
                RequiredStudents = RequiredStudents.Where(x => x.PhoneNumber == Phone).ToList();
            }
            if(!ClassName.Equals(""))
            {
                if(SectionName.Equals(""))
                {
                    RequiredStudents = RequiredStudents.Where(x => x.Section.Class.Name == ClassName).ToList();
                }
                else
                {
                    RequiredStudents = RequiredStudents.Where(x => x.Section.Class.Name == ClassName && x.Section.Title == SectionName).ToList();
                }
            }
            if (RequiredStudents.Count == 0)
                this.label5.Text = "No Record Found";
            else
            {
                this.tableLayoutPanel1.Hide();
                this.Refresh();
                RequiredStudents.Sort();
                int RowNnumberTrace = 1;
                this.tableLayoutPanel1.Controls.Add(new MaskedTextBox() { Text = "RollNumber" }, 0, 0);
                this.tableLayoutPanel1.Controls.Add(new MaskedTextBox() { Text = "Name" }, 1, 0);
                this.tableLayoutPanel1.Controls.Add(new MaskedTextBox() { Text = "FatherName" }, 2, 0);
                this.tableLayoutPanel1.Controls.Add(new MaskedTextBox() { Text = "DateOfBirth" }, 3, 0);
                this.tableLayoutPanel1.Controls.Add(new MaskedTextBox() { Text = "Class" }, 4, 0);
                this.tableLayoutPanel1.Controls.Add(new MaskedTextBox() { Text = "Section" }, 5, 0);
                this.tableLayoutPanel1.Controls.Add(new MaskedTextBox() { Text = "Admission Date" }, 6, 0);
                this.tableLayoutPanel1.Controls.Add(new MaskedTextBox() { Text = "Phone Number" }, 7, 0);
                this.tableLayoutPanel1.Controls.Add(new MaskedTextBox() { Text = "Address" }, 8, 0);
                this.tableLayoutPanel1.Controls.Add(new MaskedTextBox() { Text = "Religion" }, 9, 0);
                this.tableLayoutPanel1.Controls.Add(new MaskedTextBox() { Text = "Leave Date" }, 10, 0);
                foreach (Student std in RequiredStudents)
                {
                    this.tableLayoutPanel1.RowCount++;
                    this.tableLayoutPanel1.Controls.Add(new MaskedTextBox() { Text = std.RollNumber }, 0, RowNnumberTrace);
                    this.tableLayoutPanel1.Controls.Add(new MaskedTextBox() { Text = std.Name }, 1, RowNnumberTrace);
                    this.tableLayoutPanel1.Controls.Add(new MaskedTextBox() { Text = std.FatherName }, 2, RowNnumberTrace);
                    this.tableLayoutPanel1.Controls.Add(new MaskedTextBox() { Text = std.DateOfBirth.ToString() }, 3, RowNnumberTrace);
                    this.tableLayoutPanel1.Controls.Add(new MaskedTextBox() { Text = std.Section.Class.Name }, 4, RowNnumberTrace);
                    this.tableLayoutPanel1.Controls.Add(new MaskedTextBox() { Text = std.Section.Title }, 5, RowNnumberTrace);
                    this.tableLayoutPanel1.Controls.Add(new MaskedTextBox() { Text = std.AdmissionDate.ToString() }, 6, RowNnumberTrace);
                    this.tableLayoutPanel1.Controls.Add(new MaskedTextBox() { Text = std.PhoneNumber }, 7, RowNnumberTrace);
                    this.tableLayoutPanel1.Controls.Add(new MaskedTextBox() { Text = std.Address }, 8, RowNnumberTrace);
                    this.tableLayoutPanel1.Controls.Add(new MaskedTextBox() { Text = std.Religion }, 9, RowNnumberTrace);
                    this.tableLayoutPanel1.Controls.Add(new MaskedTextBox() { Text = std.LeaveDate.ToString() }, 10, RowNnumberTrace);
                    RowNnumberTrace++;
                    this.label5.Text = RequiredStudents.Count+" Numbers of student Found";
                    this.tableLayoutPanel1.Show();
                    this.Refresh();
                }
            }
        }

        private void SearchStudent_Load(object sender, EventArgs e)
        {
            foreach(Class c in database.Classes)
            {
                this.ClassComboBox.Items.Add(c.Name);
            }
        }

        private void ClassComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Section> RequiredSections = database.Sections.Where(X => X.Class.Name == this.ClassComboBox.SelectedItem.ToString()).ToList();
            this.SectionComboBox.Items.Clear();
            this.SectionComboBox.SelectedItem = null;
            this.Refresh();
            foreach(Section s in RequiredSections)
            {
                this.SectionComboBox.Items.Add(s.Title);
            }
            this.Refresh();
        }

    }
}
