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
    public partial class Add_Transaction : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=ASUS-PC\SQLEXPRESS01;Initial Catalog=IT132L;Integrated Security=True");
        string Cstatus;
        public Add_Transaction()
        {
            InitializeComponent();
        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            Payment_History back = new Payment_History();
            back.Show();
            this.Hide();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Day.SelectedItem = null;
            Month.SelectedItem = null;
            Year.SelectedItem = null;
            ModePay.SelectedItem = null;
            AmountPayed.Text = "";
            Balance.Text = "";
        }

        private void Add_Transaction_Load(object sender, EventArgs e)
        {
            ConfirmBtn.Enabled = false;
            connection.Open();
            SqlCommand com = new SqlCommand("Select PatientNo From PatientTable", connection);
            SqlDataReader r = com.ExecuteReader();

            while(r.Read())
            {
                PatientNumber.Items.Add(r[0]);
            }



            connection.Close();
        }

        private void PatientNumber_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Day.SelectedItem != null && Month.SelectedItem != null && Year.SelectedItem != null && ModePay.SelectedItem != null && AmountPayed.Text != "" && Balance.Text != "")
                ConfirmBtn.Enabled = true;
        }

        private void Day_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Day.SelectedItem != null && Month.SelectedItem != null && Year.SelectedItem != null && ModePay.SelectedItem != null && AmountPayed.Text != "" && Balance.Text != "")
                ConfirmBtn.Enabled = true;
        }

        private void Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Day.SelectedItem != null && Month.SelectedItem != null && Year.SelectedItem != null && ModePay.SelectedItem != null && AmountPayed.Text != "" && Balance.Text != "")
                ConfirmBtn.Enabled = true;
        }

        private void ModePay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Day.SelectedItem != null && Month.SelectedItem != null && Year.SelectedItem != null && ModePay.SelectedItem != null && AmountPayed.Text != "" && Balance.Text != "")
                ConfirmBtn.Enabled = true;
        }

        private void AmountPayed_TextChanged(object sender, EventArgs e)
        {
            if (Day.SelectedItem != null && Month.SelectedItem != null && Year.SelectedItem != null && ModePay.SelectedItem != null && AmountPayed.Text != "" && Balance.Text != "")
                ConfirmBtn.Enabled = true;
        }

        private void Balance_TextChanged(object sender, EventArgs e)
        {
            if (Day.SelectedItem != null && Month.SelectedItem != null && Year.SelectedItem != null && ModePay.SelectedItem != null && AmountPayed.Text != "" && Balance.Text != "")
                ConfirmBtn.Enabled = true;
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(AmountPayed.Text) == 0 && Convert.ToInt32(Balance.Text)!=0)
                Cstatus="Not Payed";
            else if(Convert.ToInt32(AmountPayed.Text) != 0 && Convert.ToInt32(Balance.Text)!=0)
                Cstatus="Not Fully Payed";
            else if(Convert.ToInt32(AmountPayed.Text) == 0 && Convert.ToInt32(Balance.Text)==0)
                Cstatus="Fully Payed";
            else if(Convert.ToInt32(AmountPayed.Text) != 0 && Convert.ToInt32(Balance.Text)==0)
                Cstatus="Fully Payed";

            connection.Open();
            SqlCommand com = new SqlCommand("Insert Into PaymentTable values ('" + PatientNumber.Text + "','" + Month.Text + "/" + Day.Text + "/" + Year.Text + "','" + ModePay.Text + "'," + AmountPayed.Text + "," + Balance.Text + ",'" + Cstatus + "')", connection);
            com.ExecuteNonQuery();

            MessageBox.Show("Transaction Succesfully Added!");
            Day.SelectedItem = null;
            Month.SelectedItem = null;
            Year.SelectedItem = null;
            ModePay.SelectedItem = null;
            AmountPayed.Text = "";
            Balance.Text = "";

            connection.Close();
        }
    }
}
