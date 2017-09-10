namespace Dental_Clinic_System
{
    partial class View_Detailed_Patient
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PatientNumber = new System.Windows.Forms.ComboBox();
            this.status = new System.Windows.Forms.TextBox();
            this.occupation = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.TextBox();
            this.birthday = new System.Windows.Forms.TextBox();
            this.PatientName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ContactNo = new System.Windows.Forms.TextBox();
            this.EmailAdd = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.EditContactInfoBtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Condition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Treatment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tstatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.AddTreatment = new System.Windows.Forms.Button();
            this.EditTreatment = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Number :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PatientNumber);
            this.groupBox1.Controls.Add(this.status);
            this.groupBox1.Controls.Add(this.occupation);
            this.groupBox1.Controls.Add(this.Age);
            this.groupBox1.Controls.Add(this.birthday);
            this.groupBox1.Controls.Add(this.PatientName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 194);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Information";
            // 
            // PatientNumber
            // 
            this.PatientNumber.FormattingEnabled = true;
            this.PatientNumber.Location = new System.Drawing.Point(108, 22);
            this.PatientNumber.Name = "PatientNumber";
            this.PatientNumber.Size = new System.Drawing.Size(194, 21);
            this.PatientNumber.TabIndex = 12;
            this.PatientNumber.SelectedIndexChanged += new System.EventHandler(this.PatientNumber_SelectedIndexChanged);
            // 
            // status
            // 
            this.status.Enabled = false;
            this.status.Location = new System.Drawing.Point(108, 157);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(194, 20);
            this.status.TabIndex = 11;
            // 
            // occupation
            // 
            this.occupation.Enabled = false;
            this.occupation.Location = new System.Drawing.Point(108, 130);
            this.occupation.Name = "occupation";
            this.occupation.Size = new System.Drawing.Size(194, 20);
            this.occupation.TabIndex = 10;
            // 
            // Age
            // 
            this.Age.Enabled = false;
            this.Age.Location = new System.Drawing.Point(108, 103);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(194, 20);
            this.Age.TabIndex = 9;
            // 
            // birthday
            // 
            this.birthday.Enabled = false;
            this.birthday.Location = new System.Drawing.Point(108, 76);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(194, 20);
            this.birthday.TabIndex = 8;
            // 
            // PatientName
            // 
            this.PatientName.Enabled = false;
            this.PatientName.Location = new System.Drawing.Point(108, 49);
            this.PatientName.Name = "PatientName";
            this.PatientName.Size = new System.Drawing.Size(194, 20);
            this.PatientName.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Status :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Occupation :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Birthday :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patient Name :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ContactNo);
            this.groupBox2.Controls.Add(this.EmailAdd);
            this.groupBox2.Controls.Add(this.Address);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 124);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Patient Contact Information";
            // 
            // ContactNo
            // 
            this.ContactNo.Enabled = false;
            this.ContactNo.Location = new System.Drawing.Point(108, 88);
            this.ContactNo.Name = "ContactNo";
            this.ContactNo.Size = new System.Drawing.Size(194, 20);
            this.ContactNo.TabIndex = 5;
            // 
            // EmailAdd
            // 
            this.EmailAdd.Enabled = false;
            this.EmailAdd.Location = new System.Drawing.Point(108, 54);
            this.EmailAdd.Name = "EmailAdd";
            this.EmailAdd.Size = new System.Drawing.Size(194, 20);
            this.EmailAdd.TabIndex = 4;
            // 
            // Address
            // 
            this.Address.Enabled = false;
            this.Address.Location = new System.Drawing.Point(108, 19);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(194, 20);
            this.Address.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Contact Number :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Email Address : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Address :";
            // 
            // EditContactInfoBtn
            // 
            this.EditContactInfoBtn.Location = new System.Drawing.Point(11, 390);
            this.EditContactInfoBtn.Name = "EditContactInfoBtn";
            this.EditContactInfoBtn.Size = new System.Drawing.Size(323, 23);
            this.EditContactInfoBtn.TabIndex = 3;
            this.EditContactInfoBtn.Text = "Edit Contact Information";
            this.EditContactInfoBtn.UseVisualStyleBackColor = true;
            this.EditContactInfoBtn.Click += new System.EventHandler(this.EditContactInfoBtn_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Condition,
            this.Treatment,
            this.Tstatus,
            this.date});
            this.listView1.Location = new System.Drawing.Point(351, 34);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(379, 181);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Condition
            // 
            this.Condition.Text = "Condition";
            this.Condition.Width = 161;
            // 
            // Treatment
            // 
            this.Treatment.Text = "Treatment";
            this.Treatment.Width = 198;
            // 
            // Tstatus
            // 
            this.Tstatus.Text = "Status";
            this.Tstatus.Width = 72;
            // 
            // date
            // 
            this.date.Text = "Date";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(351, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 51);
            this.panel1.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(154, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Treatment History";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView2.Location = new System.Drawing.Point(351, 253);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(379, 190);
            this.listView2.TabIndex = 6;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Date";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mode Of Payment";
            this.columnHeader2.Width = 104;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Amount Payed";
            this.columnHeader3.Width = 83;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Balance";
            this.columnHeader4.Width = 59;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Status";
            this.columnHeader5.Width = 121;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(351, 221);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 51);
            this.panel2.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(154, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Payment History";
            // 
            // AddTreatment
            // 
            this.AddTreatment.Location = new System.Drawing.Point(12, 332);
            this.AddTreatment.Name = "AddTreatment";
            this.AddTreatment.Size = new System.Drawing.Size(322, 23);
            this.AddTreatment.TabIndex = 1;
            this.AddTreatment.Text = "Add Treatment";
            this.AddTreatment.UseVisualStyleBackColor = true;
            this.AddTreatment.Click += new System.EventHandler(this.AddTreatment_Click);
            // 
            // EditTreatment
            // 
            this.EditTreatment.Location = new System.Drawing.Point(12, 361);
            this.EditTreatment.Name = "EditTreatment";
            this.EditTreatment.Size = new System.Drawing.Size(323, 23);
            this.EditTreatment.TabIndex = 2;
            this.EditTreatment.Text = "Edit Treatment";
            this.EditTreatment.UseVisualStyleBackColor = true;
            this.EditTreatment.Click += new System.EventHandler(this.EditTreatment_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(323, 22);
            this.button1.TabIndex = 8;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // View_Detailed_Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 458);
            this.Controls.Add(this.EditTreatment);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddTreatment);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.EditContactInfoBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "View_Detailed_Patient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Detailed_Patient";
            this.Load += new System.EventHandler(this.View_Detailed_Patient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox status;
        private System.Windows.Forms.TextBox occupation;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.TextBox birthday;
        private System.Windows.Forms.TextBox PatientName;
        private System.Windows.Forms.ComboBox PatientNumber;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button EditContactInfoBtn;
        private System.Windows.Forms.TextBox ContactNo;
        private System.Windows.Forms.TextBox EmailAdd;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Condition;
        private System.Windows.Forms.ColumnHeader Treatment;
        private System.Windows.Forms.ColumnHeader Tstatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button EditTreatment;
        private System.Windows.Forms.Button AddTreatment;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}