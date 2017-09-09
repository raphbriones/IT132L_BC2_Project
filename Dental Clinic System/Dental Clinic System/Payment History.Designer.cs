namespace Dental_Clinic_System
{
    partial class Payment_History
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.SchedBtn = new System.Windows.Forms.Button();
            this.StockBtn = new System.Windows.Forms.Button();
            this.PatientBtn = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.AddTransBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.YearCmbBox = new System.Windows.Forms.ComboBox();
            this.DayCmbBox = new System.Windows.Forms.ComboBox();
            this.MonthCmbBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.modePay = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.SchedBtn);
            this.panel1.Controls.Add(this.StockBtn);
            this.panel1.Controls.Add(this.PatientBtn);
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Controls.Add(this.AddTransBtn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 453);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(73, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "label2";
            // 
            // SchedBtn
            // 
            this.SchedBtn.Location = new System.Drawing.Point(11, 90);
            this.SchedBtn.Name = "SchedBtn";
            this.SchedBtn.Size = new System.Drawing.Size(221, 24);
            this.SchedBtn.TabIndex = 13;
            this.SchedBtn.Text = "Schedule";
            this.SchedBtn.UseVisualStyleBackColor = true;
            this.SchedBtn.Click += new System.EventHandler(this.SchedBtn_Click);
            // 
            // StockBtn
            // 
            this.StockBtn.Location = new System.Drawing.Point(11, 150);
            this.StockBtn.Name = "StockBtn";
            this.StockBtn.Size = new System.Drawing.Size(221, 24);
            this.StockBtn.TabIndex = 12;
            this.StockBtn.Text = "Stock";
            this.StockBtn.UseVisualStyleBackColor = true;
            this.StockBtn.Click += new System.EventHandler(this.StockBtn_Click);
            // 
            // PatientBtn
            // 
            this.PatientBtn.Location = new System.Drawing.Point(11, 120);
            this.PatientBtn.Name = "PatientBtn";
            this.PatientBtn.Size = new System.Drawing.Size(221, 24);
            this.PatientBtn.TabIndex = 11;
            this.PatientBtn.Text = "Patient";
            this.PatientBtn.UseVisualStyleBackColor = true;
            this.PatientBtn.Click += new System.EventHandler(this.PatientBtn_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.monthCalendar1.Location = new System.Drawing.Point(9, 278);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // AddTransBtn
            // 
            this.AddTransBtn.Location = new System.Drawing.Point(11, 60);
            this.AddTransBtn.Name = "AddTransBtn";
            this.AddTransBtn.Size = new System.Drawing.Size(221, 24);
            this.AddTransBtn.TabIndex = 8;
            this.AddTransBtn.Text = "Add Transaction";
            this.AddTransBtn.UseVisualStyleBackColor = true;
            this.AddTransBtn.Click += new System.EventHandler(this.AddTransBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(12, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.modePay);
            this.panel2.Controls.Add(this.YearCmbBox);
            this.panel2.Controls.Add(this.DayCmbBox);
            this.panel2.Controls.Add(this.MonthCmbBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(256, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(478, 86);
            this.panel2.TabIndex = 4;
            // 
            // YearCmbBox
            // 
            this.YearCmbBox.FormattingEnabled = true;
            this.YearCmbBox.Items.AddRange(new object[] {
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
            this.YearCmbBox.Location = new System.Drawing.Point(400, 14);
            this.YearCmbBox.Name = "YearCmbBox";
            this.YearCmbBox.Size = new System.Drawing.Size(71, 21);
            this.YearCmbBox.TabIndex = 5;
            this.YearCmbBox.SelectedIndexChanged += new System.EventHandler(this.YearCmbBox_SelectedIndexChanged);
            // 
            // DayCmbBox
            // 
            this.DayCmbBox.FormattingEnabled = true;
            this.DayCmbBox.Items.AddRange(new object[] {
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
            this.DayCmbBox.Location = new System.Drawing.Point(346, 14);
            this.DayCmbBox.Name = "DayCmbBox";
            this.DayCmbBox.Size = new System.Drawing.Size(48, 21);
            this.DayCmbBox.TabIndex = 4;
            this.DayCmbBox.SelectedIndexChanged += new System.EventHandler(this.DayCmbBox_SelectedIndexChanged);
            // 
            // MonthCmbBox
            // 
            this.MonthCmbBox.FormattingEnabled = true;
            this.MonthCmbBox.Items.AddRange(new object[] {
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
            this.MonthCmbBox.Location = new System.Drawing.Point(289, 14);
            this.MonthCmbBox.Name = "MonthCmbBox";
            this.MonthCmbBox.Size = new System.Drawing.Size(51, 21);
            this.MonthCmbBox.TabIndex = 3;
            this.MonthCmbBox.SelectedIndexChanged += new System.EventHandler(this.MonthCmbBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "PAYMENT HISTORY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // modePay
            // 
            this.modePay.FormattingEnabled = true;
            this.modePay.Items.AddRange(new object[] {
            "Cash",
            "Check"});
            this.modePay.Location = new System.Drawing.Point(289, 42);
            this.modePay.Name = "modePay";
            this.modePay.Size = new System.Drawing.Size(182, 21);
            this.modePay.TabIndex = 6;
            this.modePay.SelectedIndexChanged += new System.EventHandler(this.modePay_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.Location = new System.Drawing.Point(256, 70);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(478, 384);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Patient Number";
            this.columnHeader1.Width = 91;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date";
            this.columnHeader2.Width = 97;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mode Of Payment";
            this.columnHeader3.Width = 103;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Amount Payed";
            this.columnHeader4.Width = 96;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Balance";
            this.columnHeader5.Width = 86;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Status";
            this.columnHeader6.Width = 172;
            // 
            // Payment_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 458);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(256, 1);
            this.Name = "Payment_History";
            this.Text = "Payment_History";
            this.Load += new System.EventHandler(this.Payment_History_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SchedBtn;
        private System.Windows.Forms.Button StockBtn;
        private System.Windows.Forms.Button PatientBtn;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button AddTransBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox YearCmbBox;
        private System.Windows.Forms.ComboBox DayCmbBox;
        private System.Windows.Forms.ComboBox MonthCmbBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox modePay;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}