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
using System.Globalization;

namespace Dental_Clinic_System
{
    public partial class Remove_Patient : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=ASUS-PC\SQLEXPRESS01;Initial Catalog=IT132L;Integrated Security=True");

        public Remove_Patient()
        {
            InitializeComponent();
        }

        private void Remove_Patient_Load(object sender, EventArgs e)
        {
            ConfirmBtn.Enabled = false;

            PatientNumber.Items.Clear();
            connection.Open();
    

            SqlCommand com = new SqlCommand("select PatientNo from PatientTable", connection);
            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                PatientNumber.Items.Add(reader[0]);
            }
            connection.Close();
        }

        private void PatientNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfirmBtn.Enabled = true;
            if(PatientNumber.SelectedItem != null)
            {
                connection.Open();
                SqlCommand com = new SqlCommand("select LastName + ', '+ FirstName+' '+MiddleName+' ' from PatientTable where PatientNo = " + PatientNumber.Text + "", connection);
                SqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    PatientName.Text = reader[0].ToString();
                }                                    
                connection.Close();
                connection.Open();
                SqlCommand com0 = new SqlCommand("select Birthday from PatientTable where PatientNo = " + PatientNumber.Text + "", connection);
                SqlDataReader reader0 = com0.ExecuteReader();

                while (reader0.Read())
                {
                    birthday.Text = Convert.ToDateTime(reader0[0]).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                }
                connection.Close();
                connection.Open();
                SqlCommand com1 = new SqlCommand("select Age from PatientTable where PatientNo = " + PatientNumber.Text + "", connection);
                SqlDataReader reader1 = com1.ExecuteReader();

                while (reader1.Read())
                {
                    Age.Text = reader1[0].ToString();
                }
                connection.Close();
                connection.Open();
                SqlCommand com2 = new SqlCommand("select Occupation from PatientTable where PatientNo = " + PatientNumber.Text + "", connection);
                SqlDataReader reader2 = com2.ExecuteReader();

                while (reader2.Read())
                {
                    Occupation.Text = reader2[0].ToString();
                }
                connection.Close();
                connection.Open();
                SqlCommand com3 = new SqlCommand("select status from PatientTable where PatientNo = " + PatientNumber.Text + "", connection);
                SqlDataReader reader3 = com3.ExecuteReader();

                while (reader3.Read())
                {
                    Status.Text = reader3[0].ToString();
                }
                connection.Close();
            }

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            PatientNumber.SelectedItem = null;
            PatientName.Text = "";
            birthday.Text = "";
            Age.Text = "";
            Occupation.Text = "";
            Status.Text = "";
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
          
            connection.Open();
            SqlCommand com = new SqlCommand("Delete from PatientTable where PatientNo = '" + PatientNumber.Text + "'", connection);
            com.ExecuteNonQuery();

            connection.Close();
            connection.Open();
            SqlCommand com0 = new SqlCommand("Delete from ContactInformationTable where PatientNo = '" + PatientNumber.Text + "'", connection);
            com0.ExecuteNonQuery();

            connection.Close();
            connection.Open();
            SqlCommand com1 = new SqlCommand("Delete from TreatmentHistoryTable where PatientNo = '" + PatientNumber.Text + "'", connection);
            com1.ExecuteNonQuery();

            connection.Close();
            connection.Open();
            SqlCommand com2 = new SqlCommand("Delete from PaymentTable where PatientNo = '" + PatientNumber.Text+ "'", connection);
            com2.ExecuteNonQuery();

            connection.Close();

            MessageBox.Show("Patient Successfuly Removed!");
            PatientNumber.SelectedItem = null;
            PatientName.Text = "";
            birthday.Text = "";
            Age.Text = "";
            Occupation.Text = "";
            Status.Text = "";
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Patient back = new Patient();
            back.Show();
            this.Hide();
        }
    }
}
