namespace Dental_Clinic_System
{
    partial class Stock
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
            this.PaymentHistoryBtn = new System.Windows.Forms.Button();
            this.ScheduleBtn = new System.Windows.Forms.Button();
            this.PatientBtn = new System.Windows.Forms.Button();
            this.UpdateMdcnBtn = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.RemoveMdcnBtn = new System.Windows.Forms.Button();
            this.AddMdcnBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ItemNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MedName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GenName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExpirationDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.PaymentHistoryBtn);
            this.panel1.Controls.Add(this.ScheduleBtn);
            this.panel1.Controls.Add(this.PatientBtn);
            this.panel1.Controls.Add(this.UpdateMdcnBtn);
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Controls.Add(this.RemoveMdcnBtn);
            this.panel1.Controls.Add(this.AddMdcnBtn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 453);
            this.panel1.TabIndex = 1;
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
            // PaymentHistoryBtn
            // 
            this.PaymentHistoryBtn.Location = new System.Drawing.Point(11, 210);
            this.PaymentHistoryBtn.Name = "PaymentHistoryBtn";
            this.PaymentHistoryBtn.Size = new System.Drawing.Size(221, 24);
            this.PaymentHistoryBtn.TabIndex = 13;
            this.PaymentHistoryBtn.Text = "Payment History";
            this.PaymentHistoryBtn.UseVisualStyleBackColor = true;
            // 
            // ScheduleBtn
            // 
            this.ScheduleBtn.Location = new System.Drawing.Point(11, 181);
            this.ScheduleBtn.Name = "ScheduleBtn";
            this.ScheduleBtn.Size = new System.Drawing.Size(221, 24);
            this.ScheduleBtn.TabIndex = 12;
            this.ScheduleBtn.Text = "Schedule";
            this.ScheduleBtn.UseVisualStyleBackColor = true;
            this.ScheduleBtn.Click += new System.EventHandler(this.ScheduleBtn_Click);
            // 
            // PatientBtn
            // 
            this.PatientBtn.Location = new System.Drawing.Point(11, 150);
            this.PatientBtn.Name = "PatientBtn";
            this.PatientBtn.Size = new System.Drawing.Size(221, 24);
            this.PatientBtn.TabIndex = 11;
            this.PatientBtn.Text = "Patient";
            this.PatientBtn.UseVisualStyleBackColor = true;
            this.PatientBtn.Click += new System.EventHandler(this.PatientBtn_Click);
            // 
            // UpdateMdcnBtn
            // 
            this.UpdateMdcnBtn.Location = new System.Drawing.Point(11, 120);
            this.UpdateMdcnBtn.Name = "UpdateMdcnBtn";
            this.UpdateMdcnBtn.Size = new System.Drawing.Size(221, 24);
            this.UpdateMdcnBtn.TabIndex = 10;
            this.UpdateMdcnBtn.Text = "Update Medicine";
            this.UpdateMdcnBtn.UseVisualStyleBackColor = true;
            this.UpdateMdcnBtn.Click += new System.EventHandler(this.UpdateMdcnBtn_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.monthCalendar1.Location = new System.Drawing.Point(9, 278);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // RemoveMdcnBtn
            // 
            this.RemoveMdcnBtn.Location = new System.Drawing.Point(11, 90);
            this.RemoveMdcnBtn.Name = "RemoveMdcnBtn";
            this.RemoveMdcnBtn.Size = new System.Drawing.Size(221, 24);
            this.RemoveMdcnBtn.TabIndex = 9;
            this.RemoveMdcnBtn.Text = "Remove Medicine";
            this.RemoveMdcnBtn.UseVisualStyleBackColor = true;
            this.RemoveMdcnBtn.Click += new System.EventHandler(this.RemoveMdcnBtn_Click);
            // 
            // AddMdcnBtn
            // 
            this.AddMdcnBtn.Location = new System.Drawing.Point(11, 60);
            this.AddMdcnBtn.Name = "AddMdcnBtn";
            this.AddMdcnBtn.Size = new System.Drawing.Size(221, 24);
            this.AddMdcnBtn.TabIndex = 8;
            this.AddMdcnBtn.Text = "Add Medicine";
            this.AddMdcnBtn.UseVisualStyleBackColor = true;
            this.AddMdcnBtn.Click += new System.EventHandler(this.AddMdcnBtn_Click);
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
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemNo,
            this.MedName,
            this.GenName,
            this.Size,
            this.Quantity,
            this.Price,
            this.ExpirationDate,
            this.Status});
            this.listView1.Location = new System.Drawing.Point(256, 46);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(478, 405);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ItemNo
            // 
            this.ItemNo.Text = "Item Number";
            this.ItemNo.Width = 69;
            // 
            // MedName
            // 
            this.MedName.Text = "Medical Name";
            this.MedName.Width = 96;
            // 
            // GenName
            // 
            this.GenName.Text = "Generic Name";
            this.GenName.Width = 98;
            // 
            // Size
            // 
            this.Size.Text = "Size";
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            // 
            // Price
            // 
            this.Price.Text = "Price";
            // 
            // ExpirationDate
            // 
            this.ExpirationDate.Text = "Expiration Date";
            this.ExpirationDate.Width = 112;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 122;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(256, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(478, 72);
            this.panel2.TabIndex = 4;
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
            this.label1.Size = new System.Drawing.Size(169, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "MEDICINE STOCK";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(295, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Dental_Clinic_System.Properties.Resources.search1600;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(445, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 458);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Location = new System.Drawing.Point(456, 40);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "medicine stock";
            this.Load += new System.EventHandler(this.Stock_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PaymentHistoryBtn;
        private System.Windows.Forms.Button ScheduleBtn;
        private System.Windows.Forms.Button PatientBtn;
        private System.Windows.Forms.Button UpdateMdcnBtn;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button RemoveMdcnBtn;
        private System.Windows.Forms.Button AddMdcnBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader ItemNo;
        private System.Windows.Forms.ColumnHeader MedName;
        private System.Windows.Forms.ColumnHeader GenName;
        private System.Windows.Forms.ColumnHeader Size;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader ExpirationDate;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
    }
}