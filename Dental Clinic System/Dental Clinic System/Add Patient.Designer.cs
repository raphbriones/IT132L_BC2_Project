namespace Dental_Clinic_System
{
    partial class Add_Patient
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.MiddleName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.Occupation = new System.Windows.Forms.TextBox();
            this.Status = new System.Windows.Forms.TextBox();
            this.Month = new System.Windows.Forms.ComboBox();
            this.Day = new System.Windows.Forms.ComboBox();
            this.Year = new System.Windows.Forms.ComboBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.TextBox();
            this.EmailAddress = new System.Windows.Forms.TextBox();
            this.ContactNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Middle Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Birthday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Occupation";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Status";
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(91, 13);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(181, 20);
            this.FirstName.TabIndex = 6;
            this.FirstName.TextChanged += new System.EventHandler(this.FirstName_TextChanged);
            // 
            // MiddleName
            // 
            this.MiddleName.Location = new System.Drawing.Point(91, 42);
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Size = new System.Drawing.Size(181, 20);
            this.MiddleName.TabIndex = 7;
            this.MiddleName.TextChanged += new System.EventHandler(this.MiddleName_TextChanged);
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(91, 69);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(181, 20);
            this.LastName.TabIndex = 8;
            this.LastName.TextChanged += new System.EventHandler(this.LastName_TextChanged);
            // 
            // Occupation
            // 
            this.Occupation.Location = new System.Drawing.Point(91, 126);
            this.Occupation.Name = "Occupation";
            this.Occupation.Size = new System.Drawing.Size(181, 20);
            this.Occupation.TabIndex = 9;
            this.Occupation.TextChanged += new System.EventHandler(this.Occupation_TextChanged);
            // 
            // Status
            // 
            this.Status.Location = new System.Drawing.Point(91, 156);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(181, 20);
            this.Status.TabIndex = 10;
            this.Status.TextChanged += new System.EventHandler(this.Status_TextChanged);
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
            this.Month.Location = new System.Drawing.Point(91, 96);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(55, 21);
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
            this.Day.Location = new System.Drawing.Point(153, 96);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(51, 21);
            this.Day.TabIndex = 12;
            this.Day.SelectedIndexChanged += new System.EventHandler(this.Day_SelectedIndexChanged);
            // 
            // Year
            // 
            this.Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Year.FormattingEnabled = true;
            this.Year.Location = new System.Drawing.Point(211, 96);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(61, 21);
            this.Year.TabIndex = 13;
            this.Year.SelectedIndexChanged += new System.EventHandler(this.Year_SelectedIndexChanged);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(468, 231);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 16;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.Location = new System.Drawing.Point(549, 231);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(75, 23);
            this.ConfirmBtn.TabIndex = 15;
            this.ConfirmBtn.Text = "Confirm";
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(13, 231);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 14;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Age";
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(91, 188);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(178, 20);
            this.Age.TabIndex = 18;
            this.Age.TextChanged += new System.EventHandler(this.Age_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(289, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Address ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(289, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Email Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(289, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Contact Number";
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(380, 19);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(247, 20);
            this.Address.TabIndex = 22;
            this.Address.TextChanged += new System.EventHandler(this.Address_TextChanged);
            // 
            // EmailAddress
            // 
            this.EmailAddress.Location = new System.Drawing.Point(380, 52);
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.Size = new System.Drawing.Size(244, 20);
            this.EmailAddress.TabIndex = 23;
            this.EmailAddress.TextChanged += new System.EventHandler(this.EmailAddress_TextChanged);
            // 
            // ContactNo
            // 
            this.ContactNo.Location = new System.Drawing.Point(380, 85);
            this.ContactNo.Name = "ContactNo";
            this.ContactNo.Size = new System.Drawing.Size(244, 20);
            this.ContactNo.TabIndex = 24;
            this.ContactNo.TextChanged += new System.EventHandler(this.ContactNo_TextChanged);
            // 
            // Add_Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 266);
            this.Controls.Add(this.ContactNo);
            this.Controls.Add(this.EmailAddress);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Occupation);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.MiddleName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add_Patient";
            this.Text = "Add_Patient";
            this.Load += new System.EventHandler(this.Add_Patient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox MiddleName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox Occupation;
        private System.Windows.Forms.TextBox Status;
        private System.Windows.Forms.ComboBox Month;
        private System.Windows.Forms.ComboBox Day;
        private System.Windows.Forms.ComboBox Year;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button ConfirmBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox EmailAddress;
        private System.Windows.Forms.TextBox ContactNo;
    }
}