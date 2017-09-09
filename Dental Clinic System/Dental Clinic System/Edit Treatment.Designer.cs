namespace Dental_Clinic_System
{
    partial class Edit_Treatment
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PatientNumber = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.ComboBox();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.Date = new System.Windows.Forms.ComboBox();
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Date";
            // 
            // PatientNumber
            // 
            this.PatientNumber.Location = new System.Drawing.Point(100, 13);
            this.PatientNumber.Name = "PatientNumber";
            this.PatientNumber.Size = new System.Drawing.Size(172, 20);
            this.PatientNumber.TabIndex = 24;
            // 
            // status
            // 
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "Incomplete",
            "Completed"});
            this.status.Location = new System.Drawing.Point(100, 78);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(172, 21);
            this.status.TabIndex = 25;
            this.status.SelectedIndexChanged += new System.EventHandler(this.status_SelectedIndexChanged);
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.Location = new System.Drawing.Point(191, 129);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(75, 23);
            this.ConfirmBtn.TabIndex = 28;
            this.ConfirmBtn.Text = "Confirm";
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(100, 129);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 27;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(10, 129);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 26;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // Date
            // 
            this.Date.FormattingEnabled = true;
            this.Date.Location = new System.Drawing.Point(100, 44);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(172, 21);
            this.Date.TabIndex = 29;
            this.Date.SelectedIndexChanged += new System.EventHandler(this.Date_SelectedIndexChanged);
            // 
            // Edit_Treatment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 164);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.status);
            this.Controls.Add(this.PatientNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Edit_Treatment";
            this.Text = "Edit_Treatment";
            this.Load += new System.EventHandler(this.Edit_Treatment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PatientNumber;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.Button ConfirmBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.ComboBox Date;
    }
}