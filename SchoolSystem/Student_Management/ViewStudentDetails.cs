using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SchoolSystem
{
    public partial class ViewStudentDetails : Form
    {
        public SchoolSystemEntities1 database = new SchoolSystemEntities1();
        public ViewStudentDetails()
        {
            InitializeComponent();
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            this.SchoolNameLabel.Text = config.AppSettings.Settings["School_Name"].Value;
        }

        private void ImageUploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog SelectFile = new OpenFileDialog();
            SelectFile.AddExtension = true;
            SelectFile.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            SelectFile.ShowDialog();
        }
    }
}
