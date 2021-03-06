﻿using System;
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
    public partial class Stock : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=ASUS-PC\SQLEXPRESS01;Initial Catalog=IT132L;Integrated Security=True");

        public Stock()
        {
            InitializeComponent();
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            label4.Text = monthCalendar1.TodayDate.Month.ToString() + "/" + monthCalendar1.TodayDate.Day.ToString() + "/" + monthCalendar1.TodayDate.Year.ToString();
            timer1.Start();

            connection.Open();
        
            SqlCommand co = new SqlCommand("Update StockTable Set Status ='Expired' where ExpirationDate ='"+monthCalendar1.TodayDate.Date+"'", connection);
            co.ExecuteNonQuery();
      

            connection.Close();

            connection.Open();
          

            SqlDataAdapter sda = new SqlDataAdapter("select *from StockTable  ", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            ListViewItem lvi = new ListViewItem();
            listView1.Items.Clear();
            listView1.BeginUpdate();
            for (int row = 0; row < dt.Rows.Count; row++)
            {
                DataRow dr = dt.Rows[row];
                ListViewItem listitem = new ListViewItem(dr["ItemNo"].ToString());
                listitem.SubItems.Add(dr["MedicalName"].ToString());
                listitem.SubItems.Add(dr["GenericName"].ToString());
                listitem.SubItems.Add(dr["Size"].ToString());
                listitem.SubItems.Add(dr["AmountInStock"].ToString());
                listitem.SubItems.Add(dr["Price"].ToString());
                listitem.SubItems.Add(Convert.ToDateTime(dr["ExpirationDate"]).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));
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
            Form1 sched = new Form1();
            sched.Show();
            this.Hide();
        }

        private void PatientBtn_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.Show();
            this.Hide();
        }

        private void AddMdcnBtn_Click(object sender, EventArgs e)
        {
            Add_Medicine add = new Add_Medicine();
            add.Show();
            this.Hide();
        }

        private void RemoveMdcnBtn_Click(object sender, EventArgs e)
        {
            Remove_Medicine remove = new Remove_Medicine();
            remove.Show();
            this.Hide();
        }

        private void UpdateMdcnBtn_Click(object sender, EventArgs e)
        {
            Update_Medicine update = new Update_Medicine();
            update.Show();
            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand c1 = new SqlCommand("Select *from  StockTable where GenericName = '" + Search.Text + "'", connection);
            SqlDataReader r1 = c1.ExecuteReader();
            if (r1.HasRows)
            {
                connection.Close();

                connection.Open();
              

                SqlDataAdapter sda = new SqlDataAdapter("Select *from  StockTable where GenericName = '" + Search.Text + "'", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                ListViewItem lvi = new ListViewItem();
                listView1.Items.Clear();
                listView1.BeginUpdate();
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    DataRow dr = dt.Rows[row];
                    ListViewItem listitem = new ListViewItem(dr["ItemNo"].ToString());
                    listitem.SubItems.Add(dr["MedicalName"].ToString());
                    listitem.SubItems.Add(dr["GenericName"].ToString());
                    listitem.SubItems.Add(dr["Size"].ToString());
                    listitem.SubItems.Add(dr["AmountInStock"].ToString());
                    listitem.SubItems.Add(dr["Price"].ToString());
                    listitem.SubItems.Add(dr["ExpirationDate"].ToString());
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
                SqlCommand c2 = new SqlCommand("Select *from  StockTable where MedicalName = '" + Search.Text + "'", connection);
                SqlDataReader r2 = c2.ExecuteReader();
                if (r2.HasRows)
                {
                    connection.Close();

                    connection.Open();


                    SqlDataAdapter sda = new SqlDataAdapter("Select *from  StockTable where MedicalName = '" + Search.Text + "'", connection);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    ListViewItem lvi = new ListViewItem();
                      listView1.Items.Clear();
                    listView1.BeginUpdate();
                  
                    for (int row = 0; row < dt.Rows.Count; row++)
                    {
                        DataRow dr = dt.Rows[row];
                        ListViewItem listitem = new ListViewItem(dr["ItemNo"].ToString());
                        listitem.SubItems.Add(dr["MedicalName"].ToString());
                        listitem.SubItems.Add(dr["GenericName"].ToString());
                        listitem.SubItems.Add(dr["Size"].ToString());
                        listitem.SubItems.Add(dr["AmountInStock"].ToString());
                        listitem.SubItems.Add(dr["Price"].ToString());
                        listitem.SubItems.Add(dr["ExpirationDate"].ToString());
                        listitem.SubItems.Add(dr["Status"].ToString());
                        listView1.Items.Add(listitem);
                    }
                    listView1.EndUpdate();
                    connection.Close();
                }else
                {
                    connection.Close();
                    MessageBox.Show("No results Found");
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PaymentHistoryBtn_Click(object sender, EventArgs e)
        {
            Payment_History pay = new Payment_History();
            pay.Show();
            this.Hide();
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            if(Search.Text=="")
            {
                connection.Open();


                SqlDataAdapter sda = new SqlDataAdapter("select *from StockTable  ", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                ListViewItem lvi = new ListViewItem();
                listView1.Items.Clear();
                listView1.BeginUpdate();
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    DataRow dr = dt.Rows[row];
                    ListViewItem listitem = new ListViewItem(dr["ItemNo"].ToString());
                    listitem.SubItems.Add(dr["MedicalName"].ToString());
                    listitem.SubItems.Add(dr["GenericName"].ToString());
                    listitem.SubItems.Add(dr["Size"].ToString());
                    listitem.SubItems.Add(dr["AmountInStock"].ToString());
                    listitem.SubItems.Add(dr["Price"].ToString());
                    listitem.SubItems.Add(Convert.ToDateTime(dr["ExpirationDate"]).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));
                    listitem.SubItems.Add(dr["Status"].ToString());
                    listView1.Items.Add(listitem);


                }
                listView1.EndUpdate();





                connection.Close();
            }
        }
    } 
}
