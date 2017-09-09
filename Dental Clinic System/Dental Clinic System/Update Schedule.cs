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
    public partial class Update_Schedule : Form
    {

        SqlConnection connection = new SqlConnection(@"Data Source=ASUS-PC\SQLEXPRESS01;Initial Catalog=IT132L;Integrated Security=True");

        public Update_Schedule()
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
            Status.Text = " ";

        }

        private void Update_Schedule_Load(object sender, EventArgs e)
        {
            Date.Enabled = false;
            Status.Enabled = false;
            PatientName.Items.Clear();
            connection.Open();
            ConfirmBtn.Enabled = false;

            SqlCommand com = new SqlCommand("select PatientName from ScheduleTable", connection);
            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                PatientName.Items.Add(reader[0]);
            }




            connection.Close();
        }

        private void PatientName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Date.Enabled = true;
            Status.Enabled = true;
            connection.Open();
            Date.Items.Clear();
            SqlCommand cmd = new SqlCommand("Select Date from ScheduleTable where PatientName = '" + PatientName.SelectedItem.ToString() + "'", connection);
            SqlDataReader reader1 = cmd.ExecuteReader();
            while (reader1.Read())
            {
                Date.Items.Add(reader1[0]);
            }
            connection.Close();
        }

        private void Date_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Date.Text != "" && Status.Text != "")
                ConfirmBtn.Enabled = true;
        }

        private void Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Date.Text != "" && Status.Text != "")
                ConfirmBtn.Enabled = true;
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("update ScheduleTable Set status = '" + Status.SelectedItem.ToString()+ "' where PatientName = '" + PatientName.SelectedItem.ToString() + "' and Date ='" + Date.SelectedItem.ToString()+ "'", connection);

            cmd.ExecuteNonQuery();
            connection.Close();

          
            Date.Text = null;
            Status.Text = null;
        }
    }
}
