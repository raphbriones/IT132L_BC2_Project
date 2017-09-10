using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dental_Clinic_System
{
    public partial class Edit_Treatment : Form
    {
        int Pnum;
        SqlConnection connection = new SqlConnection(@"Data Source=ASUS-PC\SQLEXPRESS01;Initial Catalog=IT132L;Integrated Security=True");

        public Edit_Treatment(int x)
        {
            InitializeComponent();
            Pnum = x;
        }

        private void Edit_Treatment_Load(object sender, EventArgs e)
        {
            ConfirmBtn.Enabled = false;
            PatientNumber.Enabled = false;
            PatientNumber.Text = Pnum.ToString();
            connection.Open();
            Date.Items.Clear();
            SqlCommand cmd = new SqlCommand("Select Date from TreatmentHistoryTable where PatientNo = " + Pnum.ToString() , connection);
            SqlDataReader reader1 = cmd.ExecuteReader();
            while (reader1.Read())
            {
                Date.Items.Add(reader1[0]);
            }
            connection.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            View_Detailed_Patient back = new View_Detailed_Patient(Pnum);
            back.Show();
            this.Hide();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Date.SelectedItem = null;
            status.SelectedItem = null;
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand com = new SqlCommand("Update TreatmentHistoryTable set status = '" + status.Text + "' where PatientNo =" + Pnum.ToString() + "and Date = '" + Date.Text + "'", connection);

            com.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Treatment Successfuly Updated!");
            View_Detailed_Patient back = new View_Detailed_Patient(Pnum);
            back.Show();
            this.Hide();
           
        }

        private void Date_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Date.SelectedItem!= null && status.SelectedItem!=null)
                ConfirmBtn.Enabled = true;
        }

        private void status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Date.SelectedItem != null && status.SelectedItem != null)
                ConfirmBtn.Enabled = true;
        }
    }
}
