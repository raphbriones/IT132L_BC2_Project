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
    public partial class Add_Treatment : Form
    {
        int pnum;

        SqlConnection connection = new SqlConnection(@"Data Source=ASUS-PC\SQLEXPRESS01;Initial Catalog=IT132L;Integrated Security=True");

        public Add_Treatment(int x)
        {
            InitializeComponent();
            pnum = x;
        }


        private void CancelBTN_Click(object sender, EventArgs e)
        {
            View_Detailed_Patient back = new View_Detailed_Patient(pnum);
            back.Show();
            this.Hide();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Condition.Text = "";
            status.Text = "";
            treatment.Text = "";
            Day.SelectedItem = null;
            Month.SelectedItem = null;
            Year.SelectedItem = null;
        }

        private void Add_Treatment_Load(object sender, EventArgs e)
        {
            PatientNumber.Text = pnum.ToString();
            ConfirmBtn.Enabled = false;

        }

        private void Condition_TextChanged(object sender, EventArgs e)
        {
            if (Condition.Text != "" && status.Text != "" && treatment.Text != "" && Day.SelectedItem != null && Month.SelectedItem != null && Year.SelectedItem != null)
                ConfirmBtn.Enabled = true;
        }

        private void treatment_TextChanged(object sender, EventArgs e)
        {
            if (Condition.Text != "" && status.Text != "" && treatment.Text != "" && Day.SelectedItem != null && Month.SelectedItem != null && Year.SelectedItem != null)
                ConfirmBtn.Enabled = true;
        }

        private void Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Condition.Text != "" && status.Text != "" && treatment.Text != "" && Day.SelectedItem != null && Month.SelectedItem != null && Year.SelectedItem != null)
                ConfirmBtn.Enabled = true;
        }

        private void Day_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Condition.Text != "" && status.Text != "" && treatment.Text != "" && Day.SelectedItem != null && Month.SelectedItem != null && Year.SelectedItem != null)
                ConfirmBtn.Enabled = true;
        }

        private void Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Condition.Text != "" && status.Text != "" && treatment.Text != "" && Day.SelectedItem != null && Month.SelectedItem != null && Year.SelectedItem != null)
                ConfirmBtn.Enabled = true;
        }

        private void status_TextChanged(object sender, EventArgs e)
        {
            if (Condition.Text != "" && status.Text != "" && treatment.Text != "" && Day.SelectedItem != null && Month.SelectedItem != null && Year.SelectedItem != null)
                ConfirmBtn.Enabled = true;
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand checker = new SqlCommand("Select * from TreatmentHistoryTable where Date='" + Month.Text + "/" + Day.Text + "/" + Year.Text + "'", connection);
            SqlDataReader read = checker.ExecuteReader();
            if (read.HasRows)
            {
                MessageBox.Show("There is already a treatment for that day");
                Condition.Text = "";
                status.Text = "";
                treatment.Text = "";
                Day.SelectedItem = null;
                Month.SelectedItem = null;
                Year.SelectedItem = null;
            }
            else
            {

                connection.Close();
                connection.Open();
                SqlCommand com = new SqlCommand("Insert into TreatmentHistoryTable values (" + pnum.ToString() + ",'" + Condition.Text + "','" + treatment.Text + "','" + status.Text + "','" + Month.Text + "/" + Day.Text + "/" + Year.Text + "')", connection);
                com.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Treatment Successfuly Inserted!");
                View_Detailed_Patient back = new View_Detailed_Patient(pnum);
                back.Show();
                this.Hide();
            }
        }
    }
}
