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
    public partial class NewAdmission : UserControl
    {
        static SchoolSystemEntities1 database = new SchoolSystemEntities1();
        static int SerialNumberOfAddedStudent; 
        public NewAdmission()
        {
            InitializeComponent();
            this.BMITextBox.GotFocus += BMITextBox_GotFocus;
            this.SectionComboBox.LostFocus += AssignRegistrationNumber;
        }

        private void AssignRegistrationNumber(object sender, EventArgs e)
        {
            if (this.ClassComboBox.SelectedItem == null)
                return;
            else
            {
                String ClassName = this.ClassComboBox.SelectedItem.ToString();
                String SectionName = this.SectionComboBox.SelectedItem.ToString();
                this.RegistrationNumberTextBox.Text = database.Students.Where(X => X.Section.Class.Name.Equals(ClassName) && X.Section.Title.Equals(SectionName)).Count() + "";
            }
        }

        private void BMITextBox_GotFocus(object sender, EventArgs e)
        {
            int Feet = (int) (double.Parse(this.HeightTextBox.Text));
            int Inches = (int) ((double.Parse(this.HeightTextBox.Text) - Feet) * 100);
            int HeightInInches = (Feet * 12) + Inches;
            double Weight = double.Parse(this.WeightTextBox.Text);
            double BMI = (Height / (Weight*Weight))*720;
            this.BMITextBox.Text = BMI + "";
        }

        private void FatherCNICTextBox_TextChanged(object sender, EventArgs e)
        {
            String FatherCNIC = this.FatherCNICTextBox.Text;
            double FatherCNICTest;
            if (!double.TryParse(FatherCNIC,out FatherCNICTest))
                MessageBox.Show("Enter CNIC without Dashes");
        }

        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
            double heightTest;
            if (!double.TryParse(this.HeightTextBox.Text, out heightTest))
                MessageBox.Show("Invalid height... Write in the form of feet comma inches like 5.11");
        }

        private void WeightTextBox_TextChanged(object sender, EventArgs e)
        {
            double WeightTest;
            if (!double.TryParse(this.HeightTextBox.Text, out WeightTest))
                MessageBox.Show("Invalid Weight");
            else if(WeightTest < 0)
                MessageBox.Show("Invalid Weight...Can't Enter negative Weight");
        }

        private void NewAdmission_Load(object sender, EventArgs e)
        {
            Student std = new Student();
            std.Name = "123456789";
            database.Students.Add(std);
            database.SaveChanges();
            std = database.Students.Where(X => X.Name.Equals("123456789")).First();
            SerialNumberOfAddedStudent = std.id;
            this.SerialNumberTextBox.Text = std.id + "";
            this.ClassComboBox.Items.AddRange(database.Classes.Select(X => X.Name).ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            database.Students.Remove(database.Students.Where(X => X.id == SerialNumberOfAddedStudent).First());
        }

        private void ClassComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Section> RequiredSections = database.Sections.Where(X => X.Class.Name == this.ClassComboBox.SelectedItem.ToString()).ToList();
            this.SectionComboBox.Items.Clear();
            this.SectionComboBox.SelectedItem = null;
            this.Refresh();
            foreach (Section s in RequiredSections)
            {
                this.SectionComboBox.Items.Add(s.Title);
            }
            this.Refresh();
        }
    }
}
