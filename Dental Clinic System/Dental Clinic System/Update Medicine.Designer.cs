namespace Dental_Clinic_System
{
    partial class Update_Medicine
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
            this.Confirm = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.ItemNo = new System.Windows.Forms.ComboBox();
            this.Status = new System.Windows.Forms.TextBox();
            this.ExpirationDate = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.Size = new System.Windows.Forms.TextBox();
            this.GenericName = new System.Windows.Forms.TextBox();
            this.MedicalName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NQuantity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(197, 244);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(75, 23);
            this.Confirm.TabIndex = 33;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(105, 244);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 32;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(12, 244);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 31;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // ItemNo
            // 
            this.ItemNo.FormattingEnabled = true;
            this.ItemNo.Location = new System.Drawing.Point(105, 11);
            this.ItemNo.Name = "ItemNo";
            this.ItemNo.Size = new System.Drawing.Size(167, 21);
            this.ItemNo.TabIndex = 30;
            this.ItemNo.SelectedIndexChanged += new System.EventHandler(this.ItemNo_SelectedIndexChanged);
            // 
            // Status
            // 
            this.Status.Enabled = false;
            this.Status.Location = new System.Drawing.Point(105, 156);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(167, 20);
            this.Status.TabIndex = 29;
            // 
            // ExpirationDate
            // 
            this.ExpirationDate.Enabled = false;
            this.ExpirationDate.Location = new System.Drawing.Point(105, 126);
            this.ExpirationDate.Name = "ExpirationDate";
            this.ExpirationDate.Size = new System.Drawing.Size(167, 20);
            this.ExpirationDate.TabIndex = 28;
            // 
            // Quantity
            // 
            this.Quantity.Enabled = false;
            this.Quantity.Location = new System.Drawing.Point(105, 182);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(167, 20);
            this.Quantity.TabIndex = 27;
            // 
            // Size
            // 
            this.Size.Enabled = false;
            this.Size.Location = new System.Drawing.Point(105, 100);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(167, 20);
            this.Size.TabIndex = 26;
            // 
            // GenericName
            // 
            this.GenericName.Enabled = false;
            this.GenericName.Location = new System.Drawing.Point(105, 70);
            this.GenericName.Name = "GenericName";
            this.GenericName.Size = new System.Drawing.Size(167, 20);
            this.GenericName.TabIndex = 25;
            // 
            // MedicalName
            // 
            this.MedicalName.Enabled = false;
            this.MedicalName.Location = new System.Drawing.Point(105, 40);
            this.MedicalName.Name = "MedicalName";
            this.MedicalName.Size = new System.Drawing.Size(167, 20);
            this.MedicalName.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Expiration Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Generic Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Medical Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Item No.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "New Quantity";
            // 
            // NQuantity
            // 
            this.NQuantity.Location = new System.Drawing.Point(105, 213);
            this.NQuantity.Name = "NQuantity";
            this.NQuantity.Size = new System.Drawing.Size(167, 20);
            this.NQuantity.TabIndex = 35;
            this.NQuantity.TextChanged += new System.EventHandler(this.NQuantity_TextChanged);
            // 
            // Update_Medicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 279);
            this.Controls.Add(this.NQuantity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.ItemNo);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.ExpirationDate);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Size);
            this.Controls.Add(this.GenericName);
            this.Controls.Add(this.MedicalName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Update_Medicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update_Medicine";
            this.Load += new System.EventHandler(this.Update_Medicine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ComboBox ItemNo;
        private System.Windows.Forms.TextBox Status;
        private System.Windows.Forms.TextBox ExpirationDate;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.TextBox Size;
        private System.Windows.Forms.TextBox GenericName;
        private System.Windows.Forms.TextBox MedicalName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NQuantity;
    }
}