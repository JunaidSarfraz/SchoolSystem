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
        public NewAdmission()
        {
            InitializeComponent();
            this.BMITextBox.GotFocus += BMITextBox_GotFocus;
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
    }
}
