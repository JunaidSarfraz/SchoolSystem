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
            DateTime SelectedDate = this.dateTimePicker1.Value;
            String SelectedDateString = SelectedDate.ToString("dd-MM-yyyy");
            List<Attandance> RequiredAttandance = getRequiredAttandances(SelectedDateString).Where(x => x.Status == 0).ToList();
            int RowNnumberTrace = 2;
            this.AbsentReporTable.Hide();
            this.AbsentReporTable.Controls.Add(new Label() { Text = "Roll Number", AutoSize = true }, 0, 0);
            this.AbsentReporTable.Controls.Add(new Label() { Text = "Name", AutoSize = true }, 1, 0);
            this.AbsentReporTable.Controls.Add(new Label() { Text = "FatherName", AutoSize = true }, 2, 0);
            this.AbsentReporTable.Controls.Add(new Label() { Text = "Contact Number", AutoSize = true }, 3, 0);
            this.AbsentReporTable.Controls.Add(new Label() { Text = "Number Of Absents", AutoSize = true }, 4, 0);
            this.AbsentReporTable.RowCount++;
            foreach (Attandance A in RequiredAttandance)
            {
                this.AbsentReporTable.Controls.Add(new Label() { Text = A.Student.RollNumber, AutoSize = true }, 0, RowNnumberTrace);
                this.AbsentReporTable.Controls.Add(new Label() { Text = A.Student.Name, AutoSize = true }, 1, RowNnumberTrace);
                this.AbsentReporTable.Controls.Add(new Label() { Text = A.Student.FatherName, AutoSize = true }, 2, RowNnumberTrace);
                this.AbsentReporTable.Controls.Add(new Label() { Text = A.Student.PhoneNumber, AutoSize = true }, 3, RowNnumberTrace);
                this.AbsentReporTable.Controls.Add(new Label() { Text = database.Attandances.Where(x => (x.StudentID == A.StudentID) && (x.AttandanceDate.Value.Month == SelectedDate.Month)).Count().ToString(), AutoSize = true }, 4, RowNnumberTrace);
                this.AbsentReporTable.RowCount++;
                RowNnumberTrace++;
            }
            this.AbsentReporTable.Show();
        }
    }
}
