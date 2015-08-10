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
    public partial class AbsentReport : UserControl
    {
        static SchoolSystemEntities1 database = new SchoolSystemEntities1();
        static List<Attandance> getRequiredAttandances(String Date)
        {
            List<Attandance> Result = new List<Attandance>();
            foreach(Attandance A in database.Attandances)
            {
                DateTime AttndanceDate = (DateTime)A.AttandanceDate;
                String AttandaceDateString = AttndanceDate.ToString("dd-MM-yyyy");
                if(AttandaceDateString.Equals(Date))
                {
                    Result.Add(A);
                }
            }
            return Result;
        }
        public AbsentReport()
        {
            InitializeComponent();
        }

        private void BtnGenerateAbsentReport_Click(object sender, EventArgs e)
        {
            this.AbsentReporTable.Controls.Clear();
            String SelectedDate = this.dateTimePicker1.Value.ToString("dd-MM-yyyy");
            List<Attandance> RequiredAttandance = getRequiredAttandances(SelectedDate).Where(x => x.Status == 0).ToList();
            int RowNnumberTrace = 2;
            this.AbsentReporTable.Controls.Add(new TextBox() { Text = "Roll Number" }, 0, 0);
            this.AbsentReporTable.Controls.Add(new TextBox() { Text = "Name", Width = 150}, 1, 0);
            this.AbsentReporTable.Controls.Add(new TextBox() { Text = "FatherName" , Width = 150 }, 2, 0);
            this.AbsentReporTable.Controls.Add(new TextBox() { Text = "Contact Number", Width = 150 }, 3, 0);
            this.AbsentReporTable.Controls.Add(new TextBox() { Text = "Number Of Absents",Width = 180}, 4, 0);
            this.AbsentReporTable.RowCount++;
            foreach (Attandance A in RequiredAttandance)
            {
                this.AbsentReporTable.Controls.Add(new TextBox() { Text = A.Student.RollNumber }, 0, RowNnumberTrace);
                this.AbsentReporTable.Controls.Add(new TextBox() { Text = A.Student.Name,Width = 150 }, 1, RowNnumberTrace);
                this.AbsentReporTable.Controls.Add(new TextBox() { Text = A.Student.FatherName, Width = 150 }, 2, RowNnumberTrace);
                this.AbsentReporTable.Controls.Add(new TextBox() { Text = A.Student.PhoneNumber, Width = 150 }, 3, RowNnumberTrace);
                this.AbsentReporTable.Controls.Add(new TextBox() { Text = database.Attandances.Where(x => x.StudentID == A.StudentID).Count().ToString(), Width = 180 }, 4, RowNnumberTrace);
                this.AbsentReporTable.RowCount++;
                RowNnumberTrace++;
            }
        }
    }
}
