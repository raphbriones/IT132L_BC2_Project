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
    public partial class Add_Schedule : Form
    {
        public Add_Schedule()
        {
            InitializeComponent();
        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            Form1 back = new Form1();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            back.Show();
            this.Hide();

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            PatientName.Clear();
            Month.Text = " ";
            Day.Text = " ";
            Year.Text = " ";
            Hour.Text = " ";
            Minute.Text = " ";
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
