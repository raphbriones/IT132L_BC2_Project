namespace Dental_Clinic_System
{
    partial class Add_Transaction
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
            this.PatientNumber = new System.Windows.Forms.ComboBox();
            this.Year = new System.Windows.Forms.ComboBox();
            this.Day = new System.Windows.Forms.ComboBox();
            this.Month = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ModePay = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AmountPayed = new System.Windows.Forms.TextBox();
            this.Balance = new System.Windows.Forms.TextBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Number ";
            // 
            // PatientNumber
            // 
            this.PatientNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PatientNumber.FormattingEnabled = true;
            this.PatientNumber.Location = new System.Drawing.Point(122, 13);
            this.PatientNumber.Name = "PatientNumber";
            this.PatientNumber.Size = new System.Drawing.Size(172, 21);
            this.PatientNumber.TabIndex = 1;
            this.PatientNumber.SelectedIndexChanged += new System.EventHandler(this.PatientNumber_SelectedIndexChanged);
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
            this.Year.Location = new System.Drawing.Point(231, 41);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(63, 21);
            this.Year.TabIndex = 17;
            this.Year.SelectedIndexChanged += new System.EventHandler(this.Year_SelectedIndexChanged);
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
            this.Day.Location = new System.Drawing.Point(169, 41);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(58, 21);
            this.Day.TabIndex = 16;
            this.Day.SelectedIndexChanged += new System.EventHandler(this.Day_SelectedIndexChanged);
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
            this.Month.Location = new System.Drawing.Point(122, 41);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(41, 21);
            this.Month.TabIndex = 15;
            this.Month.SelectedIndexChanged += new System.EventHandler(this.Month_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mode Of Payment";
            // 
            // ModePay
            // 
            this.ModePay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModePay.FormattingEnabled = true;
            this.ModePay.Items.AddRange(new object[] {
            "Cash",
            "Check"});
            this.ModePay.Location = new System.Drawing.Point(122, 67);
            this.ModePay.Name = "ModePay";
            this.ModePay.Size = new System.Drawing.Size(172, 21);
            this.ModePay.TabIndex = 19;
            this.ModePay.SelectedIndexChanged += new System.EventHandler(this.ModePay_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Amount Payed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Balance";
            // 
            // AmountPayed
            // 
            this.AmountPayed.Location = new System.Drawing.Point(122, 94);
            this.AmountPayed.Name = "AmountPayed";
            this.AmountPayed.Size = new System.Drawing.Size(172, 20);
            this.AmountPayed.TabIndex = 22;
            this.AmountPayed.TextChanged += new System.EventHandler(this.AmountPayed_TextChanged);
            // 
            // Balance
            // 
            this.Balance.Location = new System.Drawing.Point(122, 121);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(172, 20);
            this.Balance.TabIndex = 23;
            this.Balance.TextChanged += new System.EventHandler(this.Balance_TextChanged);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(117, 162);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 26;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // CancelBTN
            // 
            this.CancelBTN.Location = new System.Drawing.Point(25, 162);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(75, 23);
            this.CancelBTN.TabIndex = 25;
            this.CancelBTN.Text = "Cancel";
            this.CancelBTN.UseVisualStyleBackColor = true;
            this.CancelBTN.Click += new System.EventHandler(this.CancelBTN_Click);
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.Location = new System.Drawing.Point(207, 162);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(75, 23);
            this.ConfirmBtn.TabIndex = 24;
            this.ConfirmBtn.Text = "Confirm";
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // Add_Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 192);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.AmountPayed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ModePay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PatientNumber);
            this.Controls.Add(this.label1);
            this.Name = "Add_Transaction";
            this.Text = "Add_Transaction";
            this.Load += new System.EventHandler(this.Add_Transaction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PatientNumber;
        private System.Windows.Forms.ComboBox Year;
        private System.Windows.Forms.ComboBox Day;
        private System.Windows.Forms.ComboBox Month;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ModePay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AmountPayed;
        private System.Windows.Forms.TextBox Balance;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.Button ConfirmBtn;
    }
}