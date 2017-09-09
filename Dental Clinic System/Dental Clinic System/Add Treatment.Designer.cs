namespace Dental_Clinic_System
{
    partial class Add_Treatment
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.ComboBox();
            this.PatientNumber = new System.Windows.Forms.TextBox();
            this.Condition = new System.Windows.Forms.TextBox();
            this.treatment = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.TextBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Month = new System.Windows.Forms.ComboBox();
            this.Day = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Condition";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Treatment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Status";
            // 
            // Year
            // 
            this.Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Year.FormattingEnabled = true;
            this.Year.Items.AddRange(new object[] {
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.Year.Location = new System.Drawing.Point(209, 103);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(63, 21);
            this.Year.TabIndex = 13;
            this.Year.SelectedIndexChanged += new System.EventHandler(this.Year_SelectedIndexChanged);
            // 
            // PatientNumber
            // 
            this.PatientNumber.Enabled = false;
            this.PatientNumber.Location = new System.Drawing.Point(100, 10);
            this.PatientNumber.Name = "PatientNumber";
            this.PatientNumber.Size = new System.Drawing.Size(172, 20);
            this.PatientNumber.TabIndex = 14;
            // 
            // Condition
            // 
            this.Condition.Location = new System.Drawing.Point(100, 40);
            this.Condition.Name = "Condition";
            this.Condition.Size = new System.Drawing.Size(172, 20);
            this.Condition.TabIndex = 15;
            this.Condition.TextChanged += new System.EventHandler(this.Condition_TextChanged);
            // 
            // treatment
            // 
            this.treatment.Location = new System.Drawing.Point(100, 71);
            this.treatment.Name = "treatment";
            this.treatment.Size = new System.Drawing.Size(172, 20);
            this.treatment.TabIndex = 16;
            this.treatment.TextChanged += new System.EventHandler(this.treatment_TextChanged);
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(100, 135);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(172, 20);
            this.status.TabIndex = 17;
            this.status.TextChanged += new System.EventHandler(this.status_TextChanged);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(104, 167);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 20;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // CancelBTN
            // 
            this.CancelBTN.Location = new System.Drawing.Point(12, 167);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(75, 23);
            this.CancelBTN.TabIndex = 19;
            this.CancelBTN.Text = "Cancel";
            this.CancelBTN.UseVisualStyleBackColor = true;
            this.CancelBTN.Click += new System.EventHandler(this.CancelBTN_Click);
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.Location = new System.Drawing.Point(194, 167);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(75, 23);
            this.ConfirmBtn.TabIndex = 18;
            this.ConfirmBtn.Text = "Confirm";
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date";
            // 
            // Month
            // 
            this.Month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Month.FormattingEnabled = true;
            this.Month.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.Month.Location = new System.Drawing.Point(100, 103);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(41, 21);
            this.Month.TabIndex = 11;
            this.Month.SelectedIndexChanged += new System.EventHandler(this.Month_SelectedIndexChanged);
            // 
            // Day
            // 
            this.Day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Day.FormattingEnabled = true;
            this.Day.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.Day.Location = new System.Drawing.Point(147, 103);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(58, 21);
            this.Day.TabIndex = 12;
            this.Day.SelectedIndexChanged += new System.EventHandler(this.Day_SelectedIndexChanged);
            // 
            // Add_Treatment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 197);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.status);
            this.Controls.Add(this.treatment);
            this.Controls.Add(this.Condition);
            this.Controls.Add(this.PatientNumber);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add_Treatment";
            this.Text = "Add_Treatment";
            this.Load += new System.EventHandler(this.Add_Treatment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Year;
        private System.Windows.Forms.TextBox PatientNumber;
        private System.Windows.Forms.TextBox Condition;
        private System.Windows.Forms.TextBox treatment;
        private System.Windows.Forms.TextBox status;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.Button ConfirmBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Month;
        private System.Windows.Forms.ComboBox Day;
    }
}