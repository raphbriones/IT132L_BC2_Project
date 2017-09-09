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
    public partial class Remove_Schedule : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=ASUS-PC\SQLEXPRESS01;Initial Catalog=IT132L;Integrated Security=True");
        
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

        private void Remove_Schedule_Load(object sender, EventArgs e)
        {
            PatientName.Items.Clear();
            connection.Open();
            ConfirmBtn.Enabled = false;

            SqlCommand com = new SqlCommand("select PatientName from ScheduleTable", connection);
            SqlDataReader reader = com.ExecuteReader();

            while(reader.Read())
            {
                PatientName.Items.Add(reader[0]);
            }

            


            connection.Close();
        }

        private void PatientName_SelectedIndexChanged(object sender, EventArgs e)
        {

            Date.Enabled = true;
            Time.Enabled = true;
            Date.Items.Clear();
            Time.Items.Clear();
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select Date from ScheduleTable where PatientName = '" + PatientName.SelectedItem.ToString()+"'",connection);
            SqlDataReader reader1 = cmd.ExecuteReader();
            while (reader1.Read())
            {
                Date.Items.Add(reader1[0]);
            }
            connection.Close();
            connection.Open();
            SqlCommand cmd1 = new SqlCommand("select Time from scheduleTable where PatientName = '" + PatientName.SelectedItem.ToString()+"'",connection);
           
            SqlDataReader reader2 = cmd1.ExecuteReader();
           
            while (reader2.Read())
            {
                Time.Items.Add(reader2[0]);
            }
            connection.Close();
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand delcom = new SqlCommand("Delete from ScheduleTable where PatientName = '" + PatientName.SelectedItem.ToString() + "' and Date = '" + Date.SelectedItem.ToString() + "' and Time  = '" + Time.SelectedItem.ToString() + "'", connection);

            delcom.ExecuteNonQuery();
            
            connection.Close();


            PatientName.Text = " ";
            Date.Text = " ";
            Time.Text = " ";

            PatientName.Items.Clear();
            connection.Open();


            SqlCommand com = new SqlCommand("select PatientName from ScheduleTable", connection);
            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                PatientName.Items.Add(reader[0]);
            }




            connection.Close();
            Date.Enabled = false;
            Time.Enabled = false;
          
        }

        private void Date_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Date.Text!=""&&Time.Text!="")
                ConfirmBtn.Enabled = true;
        }

        private void Time_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Date.Text != "" && Time.Text != "")
                ConfirmBtn.Enabled = true;
        }



 
    }

}
