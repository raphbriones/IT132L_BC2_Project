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
    public partial class Add_Patient : Form
    {
        
        SqlConnection connection = new SqlConnection(@"Data Source=ASUS-PC\SQLEXPRESS01;Initial Catalog=IT132L;Integrated Security=True");
        string PatientNumber;
        public Add_Patient()
        {
            InitializeComponent();
        }

        private void Add_Patient_Load(object sender, EventArgs e)
        {
            ConfirmBtn.Enabled = false;
            for (int i = 1950; i <= System.DateTime.Today.Year; i++)
            {

                Year.Items.Add(i);
            }


        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Patient back = new Patient();
            back.Show();
            this.Hide();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            FirstName.Text = "";
            MiddleName.Text = "";
            LastName.Text = "";
            Day.SelectedItem = null;
            Month.SelectedItem = null;
            Year.SelectedItem = null;
            Age.Text = "";
            Occupation.Text = "";
            Status.Text = "";
            Address.Text = "";
            EmailAddress.Text = "";
            ContactNo.Text = "";
        }

        private void FirstName_TextChanged(object sender, EventArgs e)
        {
            if (FirstName.Text != "" && MiddleName.Text != "" && LastName.Text != "" && Day.SelectedItem != null && Month.SelectedItem != null && Year.SelectedItem != null && Age.Text != "" && Occupation.Text != "" && Status.Text != "" && Address.Text !=""&& EmailAddress.Text != "" && ContactNo.Text !="")
                ConfirmBtn.Enabled = true;
        }

        private void MiddleName_TextChanged(object sender, EventArgs e)
        {
            if (FirstName.Text != "" && MiddleName.Text != "" && LastName.Text != "" && Day.SelectedItem != null && Month.SelectedItem != null && Year.SelectedItem != null && Age.Text != "" && Occupation.Text != "" && Status.Text != "" && Address.Text != "" && EmailAddress.Text != "" && ContactNo.Text != "")
                ConfirmBtn.Enabled = true;
        }

        private void LastName_TextChanged(object sender, EventArgs e)
        {
            if (FirstName.Text != "" && MiddleName.Text != "" && LastName.Text != "" && Day.SelectedItem != null && Month.SelectedItem != null && Year.SelectedItem != null && Age.Text != "" && Occupation.Text != "" && Status.Text != "" && Address.Text != "" && EmailAddress.Text != "" && ContactNo.Text != "")
                ConfirmBtn.Enabled = true;
        }

        private void Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FirstName.Text != "" && MiddleName.Text != "" && LastName.Text != "" && Day.SelectedItem != null && Month.SelectedItem != null && Year.SelectedItem != null && Age.Text != "" && Occupation.Text != "" && Status.Text != "" && Address.Text != "" && EmailAddress.Text != "" && ContactNo.Text != "")
                ConfirmBtn.Enabled = true;
        }

        private void Day_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FirstName.Text != "" && MiddleName.Text != "" && LastName.Text != "" && Day.SelectedItem != null && Month.SelectedItem != null && Year.SelectedItem != null && Age.Text != "" && Occupation.Text != "" && Status.Text != "" && Address.Text != "" && EmailAddress.Text != "" && ContactNo.Text != "")
                ConfirmBtn.Enabled = true;
        }

        private void Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FirstName.Text != "" && MiddleName.Text != "" && LastName.Text != "" && Day.SelectedItem != null && Month.SelectedItem != null && Year.SelectedItem != null && Age.Text != "" && Occupation.Text != "" && Status.Text != "" && Address.Text != "" && EmailAddress.Text != "" && ContactNo.Text != "")
                ConfirmBtn.Enabled = true;
        }

        private void Occupation_TextChanged(object sender, EventArgs e)
        {
            if (FirstName.Text != "" && MiddleName.Text != "" && LastName.Text != "" && Day.SelectedItem != null && Month.SelectedItem != null && Year.SelectedItem != null && Age.Text != "" && Occupation.Text != "" && Status.Text != "" && Address.Text != "" && EmailAddress.Text != "" && ContactNo.Text != "")
                ConfirmBtn.Enabled = true;
        }

        private void Status_TextChanged(object sender, EventArgs e)
        {
            if (FirstName.Text != "" && MiddleName.Text != "" && LastName.Text != "" && Day.SelectedItem != null && Month.SelectedItem != null && Year.SelectedItem != null && Age.Text != "" && Occupation.Text != "" && Status.Text != "" && Address.Text != "" && EmailAddress.Text != "" && ContactNo.Text != "")
                ConfirmBtn.Enabled = true;
        }

        private void Age_TextChanged(object sender, EventArgs e)
        {
            if (FirstName.Text != "" && MiddleName.Text != "" && LastName.Text != "" && Day.SelectedItem != null && Month.SelectedItem != null && Year.SelectedItem != null && Age.Text != "" && Occupation.Text != "" && Status.Text != "" && Address.Text != "" && EmailAddress.Text != "" && ContactNo.Text != "")
                ConfirmBtn.Enabled = true;
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            SqlCommand checker = new SqlCommand("select *from PatientTable where Firstname='" + FirstName.Text + "' and  Middlename = '" + MiddleName.Text + "'  and Lastname = '" + LastName.Text + "'", connection);
            connection.Open();
            SqlDataReader reader0 = checker.ExecuteReader();
            if (reader0.HasRows)
            {
                MessageBox.Show("Patient Info Already in the Database");
                FirstName.Text = "";
                MiddleName.Text = "";
                LastName.Text = "";
                Day.SelectedItem = null;
                Month.SelectedItem = null;
                Year.SelectedItem = null;
                Age.Text = "";
                Occupation.Text = "";
                Status.Text = "";
                Address.Text = "";
                EmailAddress.Text = "";
                ContactNo.Text = "";
                connection.Close();
            }
            else
            {
                connection.Close();
                connection.Open();
                SqlCommand com = new SqlCommand("Insert Into PatientTable values('" + FirstName.Text + "','" + MiddleName.Text + "','" + LastName.Text + "','" + Month.Text + "/" + Day.Text + "/" + Year.Text + "'," + Age.Text + ",'" + Occupation.Text + "','" + Status.Text + "')", connection);
                com.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Patient Successfuly Added!");
                connection.Open();



                SqlCommand com1 = new SqlCommand("select PatientNo from PatientTable", connection);
                SqlDataReader reader = com1.ExecuteReader();

                while (reader.Read())
                {
                    PatientNumber = reader[0].ToString();
                }
                connection.Close();
                connection.Open();
                SqlCommand com0 = new SqlCommand("Insert Into ContactInformationTable values (" + PatientNumber + ",'" + Address.Text + "','" + EmailAddress.Text + "','" + ContactNo.Text + "')", connection);
                com0.ExecuteNonQuery();

                connection.Close();

                Address.Text = "";
                EmailAddress.Text = "";
                ContactNo.Text = "";
                FirstName.Text = "";
                MiddleName.Text = "";
                LastName.Text = "";
                Day.SelectedItem = null;
                Month.SelectedItem = null;
                Year.SelectedItem = null;
                Age.Text = "";
                Occupation.Text = "";
                Status.Text = "";
            }
        }

        private void Address_TextChanged(object sender, EventArgs e)
        {
            if (FirstName.Text != "" && MiddleName.Text != "" && LastName.Text != "" && Day.SelectedItem != null && Month.SelectedItem != null && Year.SelectedItem != null && Age.Text != "" && Occupation.Text != "" && Status.Text != "" && Address.Text != "" && EmailAddress.Text != "" && ContactNo.Text != "")
                ConfirmBtn.Enabled = true;
        }

        private void EmailAddress_TextChanged(object sender, EventArgs e)
        {
            if (FirstName.Text != "" && MiddleName.Text != "" && LastName.Text != "" && Day.SelectedItem != null && Month.SelectedItem != null && Year.SelectedItem != null && Age.Text != "" && Occupation.Text != "" && Status.Text != "" && Address.Text != "" && EmailAddress.Text != "" && ContactNo.Text != "")
                ConfirmBtn.Enabled = true;
        }

        private void ContactNo_TextChanged(object sender, EventArgs e)
        {
            if (FirstName.Text != "" && MiddleName.Text != "" && LastName.Text != "" && Day.SelectedItem != null && Month.SelectedItem != null && Year.SelectedItem != null && Age.Text != "" && Occupation.Text != "" && Status.Text != "" && Address.Text != "" && EmailAddress.Text != "" && ContactNo.Text != "")
                ConfirmBtn.Enabled = true;
        }
    }
}
