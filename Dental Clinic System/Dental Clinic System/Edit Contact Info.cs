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
    public partial class Edit_Contact_Info : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=ASUS-PC\SQLEXPRESS01;Initial Catalog=IT132L;Integrated Security=True");

        int Pnum;
        public Edit_Contact_Info(int x)
        {
            InitializeComponent();
            Pnum = x;
        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            View_Detailed_Patient back = new View_Detailed_Patient(Pnum);
            back.Show();
            this.Hide();
        }

        private void Edit_Contact_Info_Load(object sender, EventArgs e)
        {
            ConfirmBtn.Enabled = false;
            PatientNumber.Text = Pnum.ToString();
            connection.Open();
            SqlCommand com4 = new SqlCommand("select Address from ContactInformationTable where PatientNo = " + Pnum.ToString() + "", connection);
            SqlDataReader reader4 = com4.ExecuteReader();

            while (reader4.Read())
            {
                Address.Text = reader4[0].ToString();
            }
            connection.Close();
            connection.Open();
            SqlCommand com5 = new SqlCommand("select EmailAdd from ContactInformationTable where PatientNo = " + Pnum.ToString() + "", connection);
            SqlDataReader reader5 = com5.ExecuteReader();

            while (reader5.Read())
            {
                EmailAdd.Text = reader5[0].ToString();
            }
            connection.Close();
            connection.Open();
            SqlCommand com6 = new SqlCommand("select ContactNo from ContactInformationTable where PatientNo = " + Pnum.ToString() + "", connection);
            SqlDataReader reader6 = com6.ExecuteReader();

            while (reader6.Read())
            {
                ContactNo.Text = reader6[0].ToString();
            }
            connection.Close();

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Address.Text = "";
            EmailAdd.Text = "";
            ContactNo.Text = "";
        }

        private void Address_TextChanged(object sender, EventArgs e)
        {
            ConfirmBtn.Enabled = true;
        }

        private void EmailAdd_TextChanged(object sender, EventArgs e)
        {
            ConfirmBtn.Enabled = true;
        }

        private void ContactNo_TextChanged(object sender, EventArgs e)
        {
            ConfirmBtn.Enabled = true;
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand com = new SqlCommand("Update ContactInformationTable set Address = '" + Address.Text + "' where PatientNo =" + Pnum.ToString(), connection);
            com.ExecuteNonQuery();

            connection.Close();
            connection.Open();
            SqlCommand com0 = new SqlCommand("Update  ContactInformationTable set EmailAdd= '" + EmailAdd.Text + "' where PatientNo =" + Pnum.ToString(), connection);
            com0.ExecuteNonQuery();

            connection.Close();
            connection.Open();
            SqlCommand com1 = new SqlCommand("Update ContactInformationTable set ContactNo = '" + ContactNo.Text + "' where PatientNo =" + Pnum.ToString(), connection);
            com1.ExecuteNonQuery();

            connection.Close();
            MessageBox.Show("Contact Info Successfully Edited!");
            View_Detailed_Patient back2 = new View_Detailed_Patient(Pnum);
            back2.Show();
            this.Hide();
        }
    }
}
