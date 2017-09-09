namespace Dental_Clinic_System
{
    partial class Edit_Contact_Info
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
            this.ContactNo = new System.Windows.Forms.TextBox();
            this.EmailAdd = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PatientNumber = new System.Windows.Forms.TextBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Number";
            // 
            // ContactNo
            // 
            this.ContactNo.Location = new System.Drawing.Point(98, 105);
            this.ContactNo.Name = "ContactNo";
            this.ContactNo.Size = new System.Drawing.Size(194, 20);
            this.ContactNo.TabIndex = 11;
            this.ContactNo.TextChanged += new System.EventHandler(this.ContactNo_TextChanged);
            // 
            // EmailAdd
            // 
            this.EmailAdd.Location = new System.Drawing.Point(98, 71);
            this.EmailAdd.Name = "EmailAdd";
            this.EmailAdd.Size = new System.Drawing.Size(194, 20);
            this.EmailAdd.TabIndex = 10;
            this.EmailAdd.TextChanged += new System.EventHandler(this.EmailAdd_TextChanged);
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(98, 36);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(194, 20);
            this.Address.TabIndex = 9;
            this.Address.TextChanged += new System.EventHandler(this.Address_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Contact Number :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Email Address : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Address :";
            // 
            // PatientNumber
            // 
            this.PatientNumber.Enabled = false;
            this.PatientNumber.Location = new System.Drawing.Point(98, 6);
            this.PatientNumber.Name = "PatientNumber";
            this.PatientNumber.Size = new System.Drawing.Size(194, 20);
            this.PatientNumber.TabIndex = 12;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(113, 146);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 17;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // CancelBTN
            // 
            this.CancelBTN.Location = new System.Drawing.Point(21, 146);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(75, 23);
            this.CancelBTN.TabIndex = 16;
            this.CancelBTN.Text = "Cancel";
            this.CancelBTN.UseVisualStyleBackColor = true;
            this.CancelBTN.Click += new System.EventHandler(this.CancelBTN_Click);
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.Location = new System.Drawing.Point(203, 146);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(75, 23);
            this.ConfirmBtn.TabIndex = 15;
            this.ConfirmBtn.Text = "Confirm";
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // Edit_Contact_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 177);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.PatientNumber);
            this.Controls.Add(this.ContactNo);
            this.Controls.Add(this.EmailAdd);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "Edit_Contact_Info";
            this.Text = "Edit_Contact_Info";
            this.Load += new System.EventHandler(this.Edit_Contact_Info_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ContactNo;
        private System.Windows.Forms.TextBox EmailAdd;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PatientNumber;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.Button ConfirmBtn;
    }
}