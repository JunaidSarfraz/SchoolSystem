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
        public Form1()
        {
            InitializeComponent();
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Name.Equals("btn_Class_Wise_Strngth"))
            {
                TableLayoutPanel result = new TableLayoutPanel();
                result.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
                this.splitContainer1.Panel2.AutoScroll = true;
                result.AutoScroll = true;
                result.ColumnCount = 3;
                result.RowCount = 2;
                result.Dock = System.Windows.Forms.DockStyle.Fill;
                result.Controls.Add(new Label() { Text = "Class" }, 0, 0);
                result.Controls.Add(new Label() { Text = "Section" }, 1, 0);
                result.Controls.Add(new Label() { Text = "Number_Of_Students" }, 2, 0);

                for (int i = 0; i < 50; i++)
                {
                    result.RowCount++;
                    result.Controls.Add(new Label() { Text = "5th" }, 0, 1);
                    result.Controls.Add(new Label() { Text = "A" }, 1, 1);
                    result.Controls.Add(new Label() { Text = "40" }, 2, 1);
                }

                result.RowCount++;
                result.Controls.Add(new Button() { Text = "Export To PDF", AutoSize = true }, 2, result.RowCount - 1);
                this.splitContainer1.Panel2.Controls.Clear();
                this.splitContainer1.Panel2.Controls.Add(result);
            }
            else if(treeView1.SelectedNode.Name.Equals("btn_New_Admission"))
            {
                MessageBox.Show("Hello");
                this.splitContainer1.Panel2.Controls.Clear();
                UserControl AdmissionForm = new UserControl();
                AdmissionForm.Show();
                this.splitContainer1.Panel2.Controls.Add(AdmissionForm);
            }
        }
    }
}