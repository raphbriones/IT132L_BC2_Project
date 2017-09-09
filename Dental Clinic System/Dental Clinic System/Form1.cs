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
    public partial class Form1 : Form
    {
      
        SqlConnection connection = new SqlConnection(@"Data Source=ASUS-PC\SQLEXPRESS01;Initial Catalog=IT132L;Integrated Security=True");
        string date;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = monthCalendar1.TodayDate.Month.ToString() + "/" + monthCalendar1.TodayDate.Day.ToString() + "/" + monthCalendar1.TodayDate.Year.ToString();
            MonthCmbBox.Text = monthCalendar1.TodayDate.Month.ToString();
            DayCmbBox.Text = monthCalendar1.TodayDate.Day.ToString();
            YearCmbBox.Text = monthCalendar1.TodayDate.Year.ToString();
            connection.Close();
            connection.Open();

        
            SqlCommand cmd = new SqlCommand("update ScheduleTable Set status = 'missed' where date < '" + monthCalendar1.TodayDate.Month.ToString() + "/" + monthCalendar1.TodayDate.Day.ToString() + "/" + monthCalendar1.TodayDate.Year.ToString() + "' and  status !='Completed' ", connection);

            cmd.ExecuteNonQuery();
            connection.Close();


            
            connection.Open();
           

            SqlDataAdapter sda = new SqlDataAdapter("select *from ScheduleTable where Date = '" + MonthCmbBox.Text + "/" + DayCmbBox.Text + "/" + YearCmbBox.Text + "' ", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            ListViewItem lvi = new ListViewItem();
            listView1.Items.Clear();
            listView1.BeginUpdate();
            for (int row = 0; row < dt.Rows.Count; row++)
            {
                DataRow dr = dt.Rows[row];
                ListViewItem listitem = new ListViewItem(dr["PatientName"].ToString());
                listitem.SubItems.Add(dr["Date"].ToString());
                listitem.SubItems.Add(dr["Time"].ToString());
                listitem.SubItems.Add(dr["Status"].ToString());
                listView1.Items.Add(listitem);

               
            }
            listView1.EndUpdate();



            
            
            connection.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = System.DateTime.Now.ToString("T");
        }

        private void AddSchedBtn_Click(object sender, EventArgs e)
        {
       
            Add_Schedule add = new Add_Schedule();
            add.Show();
            this.Hide();
   
        }

        private void RemoveSchedBtn_Click(object sender, EventArgs e)
        {
            Remove_Schedule remove = new Remove_Schedule();
            remove.Show();
            this.Hide();
        }

        private void UpdateSchedBtn_Click(object sender, EventArgs e)
        {
            Update_Schedule update = new Update_Schedule();
            update.Show();
            this.Hide();
        }

        private void PatientBtn_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.Show();
            this.Hide();
        }

        private void StockBtn_Click(object sender, EventArgs e)
        {
            Stock medstock = new Stock();
            medstock.Show();
            this.Hide();
        }

        private void MonthCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            //where Date = '" + MonthCmbBox.Text + "/" + DayCmbBox.Text + "/" + YearCmbBox.Text + "'
            date = MonthCmbBox.Text + "/" + DayCmbBox.Text + "/" + YearCmbBox.Text;
            if (MonthCmbBox.Text != "" && DayCmbBox.Text != "" && YearCmbBox.Text != "")
            {
         
                SqlDataAdapter sda = new SqlDataAdapter("select *from ScheduleTable where date = '" + date + "'", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                ListViewItem lvi = new ListViewItem();
                listView1.Items.Clear();
                listView1.BeginUpdate();
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    DataRow dr = dt.Rows[row];
                    ListViewItem listitem = new ListViewItem(dr["PatientName"].ToString());
                    listitem.SubItems.Add(dr["Date"].ToString());
                    listitem.SubItems.Add(dr["Time"].ToString());
                    listitem.SubItems.Add(dr["Status"].ToString());
                    listView1.Items.Add(listitem);


                }
                listView1.EndUpdate();





                connection.Close();

            }
        }

        private void DayCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            date = MonthCmbBox.Text + "/" + DayCmbBox.Text + "/" + YearCmbBox.Text;
            if (MonthCmbBox.Text != "" && DayCmbBox.Text != "" && YearCmbBox.Text != "")
            {
               
                SqlDataAdapter sda = new SqlDataAdapter("select *from ScheduleTable where date = '" + date + "'", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                ListViewItem lvi = new ListViewItem();
                listView1.Items.Clear();
                listView1.BeginUpdate();
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    DataRow dr = dt.Rows[row];
                    ListViewItem listitem = new ListViewItem(dr["PatientName"].ToString());
                    listitem.SubItems.Add(dr["Date"].ToString());
                    listitem.SubItems.Add(dr["Time"].ToString());
                    listitem.SubItems.Add(dr["Status"].ToString());
                    listView1.Items.Add(listitem);


                }
                listView1.EndUpdate();





                connection.Close();

            }
        }

        private void YearCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            date = MonthCmbBox.Text + "/" + DayCmbBox.Text + "/" + YearCmbBox.Text;
            if (MonthCmbBox.Text != "" && DayCmbBox.Text != "" && YearCmbBox.Text != "")
            {

                SqlDataAdapter sda = new SqlDataAdapter("select *from ScheduleTable where date = '" + date + "'", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                ListViewItem lvi = new ListViewItem();
                listView1.Items.Clear();
                listView1.BeginUpdate();
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    DataRow dr = dt.Rows[row];
                    ListViewItem listitem = new ListViewItem(dr["PatientName"].ToString());
                    listitem.SubItems.Add(dr["Date"].ToString());
                    listitem.SubItems.Add(dr["Time"].ToString());
                    listitem.SubItems.Add(dr["Status"].ToString());
                    listView1.Items.Add(listitem);


                }
                listView1.EndUpdate();





                connection.Close();

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
