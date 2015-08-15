namespace SchoolSystem
{
    partial class AbsentReport
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnGenerateAbsentReport = new System.Windows.Forms.Button();
            this.AbsentReporTable = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(93, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Date";
            // 
            // BtnGenerateAbsentReport
            // 
            this.BtnGenerateAbsentReport.Location = new System.Drawing.Point(170, 74);
            this.BtnGenerateAbsentReport.Name = "BtnGenerateAbsentReport";
            this.BtnGenerateAbsentReport.Size = new System.Drawing.Size(123, 23);
            this.BtnGenerateAbsentReport.TabIndex = 2;
            this.BtnGenerateAbsentReport.Text = "Generate Report";
            this.BtnGenerateAbsentReport.UseVisualStyleBackColor = true;
            this.BtnGenerateAbsentReport.Click += new System.EventHandler(this.BtnGenerateAbsentReport_Click);
            // 
            // AbsentReporTable
            // 
            this.AbsentReporTable.AutoScroll = true;
            this.AbsentReporTable.AutoSize = true;
            this.AbsentReporTable.ColumnCount = 5;
            this.AbsentReporTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.AbsentReporTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.AbsentReporTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.AbsentReporTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.AbsentReporTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.AbsentReporTable.Location = new System.Drawing.Point(17, 160);
            this.AbsentReporTable.Name = "AbsentReporTable";
            this.AbsentReporTable.RowCount = 2;
            this.AbsentReporTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.AbsentReporTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.AbsentReporTable.Size = new System.Drawing.Size(73, 10);
            this.AbsentReporTable.TabIndex = 3;
            // 
            // AbsentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.Controls.Add(this.AbsentReporTable);
            this.Controls.Add(this.BtnGenerateAbsentReport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "AbsentReport";
            this.Size = new System.Drawing.Size(672, 271);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGenerateAbsentReport;
        private System.Windows.Forms.TableLayoutPanel AbsentReporTable;

    }
}
