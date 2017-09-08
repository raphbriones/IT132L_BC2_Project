using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Clinic_System
{
    public partial class Remove_Schedule : Form
    {
        public Remove_Schedule()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Form1 back = new Form1();
            back.Show();
            this.Hide();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            PatientName.Text = " ";
            Date.Text = " ";
            Time.Text = " ";
        }
    }
}
