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
    public partial class Patient : Form
    {

        SqlConnection connection = new SqlConnection(@"Data Source=ASUS-PC\SQLEXPRESS01;Initial Catalog=IT132L;Integrated Security=True");

        public Patient()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Patient_Load(object sender, EventArgs e)
        {
            label4.Text = monthCalendar1.TodayDate.Month.ToString() + "/" + monthCalendar1.TodayDate.Day.ToString() + "/" + monthCalendar1.TodayDate.Year.ToString();
            connection.Open();


            SqlCommand cmd = new SqlCommand("update ScheduleTable Set status = 'missed' where date <= '" + monthCalendar1.TodayDate.Month.ToString() + "/" + monthCalendar1.TodayDate.Day.ToString() + "/" + monthCalendar1.TodayDate.Year.ToString() + "' and  status !='Completed' ", connection);

            cmd.ExecuteNonQuery();
            connection.Close();



            connection.Open();
         

            SqlDataAdapter sda = new SqlDataAdapter("select *from PatientTable  ", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            ListViewItem lvi = new ListViewItem();
            listView1.BeginUpdate();
            for (int row = 0; row < dt.Rows.Count; row++)
            {
                DataRow dr = dt.Rows[row];
                ListViewItem listitem = new ListViewItem(dr["PatientNo"].ToString());
                listitem.SubItems.Add(dr["FirstName"].ToString());
                listitem.SubItems.Add(dr["MiddleName"].ToString());
                listitem.SubItems.Add(dr["LastName"].ToString());
                listitem.SubItems.Add(Convert.ToDateTime(dr["Birthday"]).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));
                listitem.SubItems.Add(dr["Age"].ToString());
                listitem.SubItems.Add(dr["Occupation"].ToString());
                listitem.SubItems.Add(dr["Status"].ToString());
                listView1.Items.Add(listitem);


            }
            listView1.EndUpdate();





            connection.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = System.DateTime.Now.ToString("T");
        }

        private void ScheduleBtn_Click(object sender, EventArgs e)
        {
            Form1 schedule = new Form1();
            schedule.Show();
            this.Hide();
        }

        private void StockBtn_Click(object sender, EventArgs e)
        {
            Stock medstock = new Stock();
            medstock.Show();
            this.Hide();
        }

        private void AddPatientBtn_Click(object sender, EventArgs e)
        {
            Add_Patient add = new Add_Patient();
            add.Show();
            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RemovePatientBtn_Click(object sender, EventArgs e)
        {
            Remove_Patient remove = new Remove_Patient();
            remove.Show();
            this.Hide();
        }

        private void UpdatePatientBtn_Click(object sender, EventArgs e)
        {
            View_Detailed_Patient view = new View_Detailed_Patient();
            view.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand C1 = new SqlCommand("select *from PatientTable where firstname ='" + search.Text + "'", connection);
            SqlDataReader r1 = C1.ExecuteReader();
           
            if (r1.HasRows)
            {
                connection.Close();
                connection.Open();


                SqlDataAdapter sda = new SqlDataAdapter("select *from PatientTable where firstname ='" + search.Text + "'", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                ListViewItem lvi = new ListViewItem();
                listView1.Items.Clear();
                listView1.BeginUpdate();
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    DataRow dr = dt.Rows[row];
                    ListViewItem listitem = new ListViewItem(dr["PatientNo"].ToString());
                    listitem.SubItems.Add(dr["FirstName"].ToString());
                    listitem.SubItems.Add(dr["MiddleName"].ToString());
                    listitem.SubItems.Add(dr["LastName"].ToString());
                    listitem.SubItems.Add(Convert.ToDateTime(dr["Birthday"]).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));
                    listitem.SubItems.Add(dr["Age"].ToString());
                    listitem.SubItems.Add(dr["Occupation"].ToString());
                    listitem.SubItems.Add(dr["Status"].ToString());
                    listView1.Items.Add(listitem);
                }
                listView1.EndUpdate();
                connection.Close();
            }
            else
            {
                connection.Close();
                connection.Open();
                SqlCommand C2 = new SqlCommand("select *from PatientTable where Middlename ='" + search.Text + "'", connection);
                SqlDataReader r2 = C2.ExecuteReader();
             
                if (r2.HasRows)
                {
                    connection.Close();
                    connection.Open();


                    SqlDataAdapter sda = new SqlDataAdapter("select *from PatientTable where Middlename ='" + search.Text + "'", connection);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    ListViewItem lvi = new ListViewItem();
                    listView1.Items.Clear();
                    listView1.BeginUpdate();
                    for (int row = 0; row < dt.Rows.Count; row++)
                    {
                        DataRow dr = dt.Rows[row];
                        ListViewItem listitem = new ListViewItem(dr["PatientNo"].ToString());
                        listitem.SubItems.Add(dr["FirstName"].ToString());
                        listitem.SubItems.Add(dr["MiddleName"].ToString());
                        listitem.SubItems.Add(dr["LastName"].ToString());
                        listitem.SubItems.Add(Convert.ToDateTime(dr["Birthday"]).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));
                        listitem.SubItems.Add(dr["Age"].ToString());
                        listitem.SubItems.Add(dr["Occupation"].ToString());
                        listitem.SubItems.Add(dr["Status"].ToString());
                        listView1.Items.Add(listitem);
                    }
                    listView1.EndUpdate();
                    connection.Close();
                }
                else
                {
                    connection.Close();
                    connection.Open();
                    SqlCommand C3 = new SqlCommand("select *from PatientTable where Lastname ='" + search.Text + "'", connection);
                    SqlDataReader r3 = C3.ExecuteReader();
                    
                    if (r3.HasRows)
                    {
                        connection.Close();
                        connection.Open();


                        SqlDataAdapter sda = new SqlDataAdapter("select *from PatientTable where Lastname ='" + search.Text + "'", connection);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        ListViewItem lvi = new ListViewItem();
                        listView1.Items.Clear();
                        listView1.BeginUpdate();
                        for (int row = 0; row < dt.Rows.Count; row++)
                        {
                            DataRow dr = dt.Rows[row];
                            ListViewItem listitem = new ListViewItem(dr["PatientNo"].ToString());
                            listitem.SubItems.Add(dr["FirstName"].ToString());
                            listitem.SubItems.Add(dr["MiddleName"].ToString());
                            listitem.SubItems.Add(dr["LastName"].ToString());
                            listitem.SubItems.Add(Convert.ToDateTime(dr["Birthday"]).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));
                            listitem.SubItems.Add(dr["Age"].ToString());
                            listitem.SubItems.Add(dr["Occupation"].ToString());
                            listitem.SubItems.Add(dr["Status"].ToString());
                            listView1.Items.Add(listitem);
                        }
                        listView1.EndUpdate();
                        connection.Close();
                    }
                    else
                    {
                        connection.Close();
                        MessageBox.Show("No result Found");
                        

                    }
                }
            }
        }

        private void PaymentHistoryBtn_Click(object sender, EventArgs e)
        {
            Payment_History pay = new Payment_History();
            pay.Show();
            this.Hide();
        }
    }
}
