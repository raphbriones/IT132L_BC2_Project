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
    public partial class Add_Schedule : Form
    {
        public Add_Schedule()
        {
            InitializeComponent();
         
       
        }

        SqlConnection connection = new SqlConnection(@"Data Source=ASUS-PC\SQLEXPRESS01;Initial Catalog=IT132L;Integrated Security=True");
        SqlCommand cmd;
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
            Month.SelectedItem = null;
            Day.SelectedItem = null;
            Year.SelectedItem = null;
            Hour.SelectedItem = null;
            Minute.SelectedItem = null;
            ConfirmBtn.Enabled = false;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (PatientName.Text != "" && Month.Text != "" && Day.Text != "" && Year.Text != "" && Hour.Text != "" && Minute.Text != "")
            { ConfirmBtn.Enabled = true; }
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            SqlCommand checker = new SqlCommand("select *from ScheduleTable where  Date = '" + Month.Text + "/" + Day.Text + "/" + Year.Text + "' and Time ='" + Hour.Text + ":" + Minute.Text + "'", connection);
            connection.Open();
            SqlDataReader reader = checker.ExecuteReader();
            if (reader.HasRows)
            {
                MessageBox.Show("Schedule slot is already occupied");
                Month.SelectedItem = null;
                Day.SelectedItem = null;
                Year.SelectedItem = null;
                Hour.SelectedItem = null;
                Minute.SelectedItem = null;
                ConfirmBtn.Enabled = false;
            }
            else
            {
                connection.Close();
                cmd = new SqlCommand("insert into ScheduleTable values('" + PatientName.Text + "','" + Month.Text + "/" + Day.Text + "/" + Year.Text + "','" + Hour.Text + ":" + Minute.Text + "','pending')", connection);
                connection.Open();
                cmd.ExecuteNonQuery();

                connection.Close();

                PatientName.Clear();
                Month.SelectedItem = null;
                Day.SelectedItem = null;
                Year.SelectedItem = null;
                Hour.SelectedItem = null;
                Minute.SelectedItem = null;
                ConfirmBtn.Enabled = false;
            }
        }

        private void Add_Schedule_Load(object sender, EventArgs e)
        {


            ConfirmBtn.Enabled = false;
            
        }

        private void PatientName_TextChanged(object sender, EventArgs e)
        {

            if (PatientName.Text != "" && Month.Text != "" && Day.Text != "" && Year.Text != "" && Hour.Text != "" && Minute.Text != "")
            { ConfirmBtn.Enabled = true; }
        }

        private void Month_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (PatientName.Text != "" && Month.Text != "" && Day.Text != "" && Year.Text != "" && Hour.Text != "" && Minute.Text != "")
            { ConfirmBtn.Enabled = true; }
        }

        private void Day_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (PatientName.Text != "" && Month.Text != "" && Day.Text != "" && Year.Text != "" && Hour.Text != "" && Minute.Text != "")
            { ConfirmBtn.Enabled = true; }
        }

        private void Year_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (PatientName.Text != "" && Month.Text != "" && Day.Text != "" && Year.Text != "" && Hour.Text != "" && Minute.Text != "")
            { ConfirmBtn.Enabled = true; }
        }

        private void Hour_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (PatientName.Text != "" && Month.Text != "" && Day.Text != "" && Year.Text != "" && Hour.Text != "" && Minute.Text != "")
            { ConfirmBtn.Enabled = true; }
        }
    }
}
