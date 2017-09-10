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
    public partial class Payment_History : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=ASUS-PC\SQLEXPRESS01;Initial Catalog=IT132L;Integrated Security=True");

        string date;
        public Payment_History()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Payment_History_Load(object sender, EventArgs e)
        {
            label4.Text = monthCalendar1.TodayDate.Month.ToString() + "/" + monthCalendar1.TodayDate.Day.ToString() + "/" + monthCalendar1.TodayDate.Year.ToString();
            timer1.Start();

            connection.Open();
        


            SqlDataAdapter sda = new SqlDataAdapter("select *from PaymentTable ", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            ListViewItem lvi0 = new ListViewItem();
            listView1.Items.Clear();
            listView1.BeginUpdate();
            for (int row = 0; row < dt.Rows.Count; row++)
            {
                DataRow dr0 = dt.Rows[row];
                ListViewItem listitem = new ListViewItem(dr0["PatientNo"].ToString());
                listitem.SubItems.Add(Convert.ToDateTime(dr0["Date"]).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));
                listitem.SubItems.Add(dr0["ModeOfPayment"].ToString());
                listitem.SubItems.Add(dr0["AmountPayed"].ToString());
                listitem.SubItems.Add(dr0["Balance"].ToString());
                listitem.SubItems.Add(dr0["status"].ToString());

                listView1.Items.Add(listitem);


            }
            listView1.EndUpdate();





            connection.Close();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = System.DateTime.Now.ToString("T");
        }

        private void SchedBtn_Click(object sender, EventArgs e)
        {
            Form1 sched = new Form1();
            sched.Show();
            this.Hide();
        }

        private void PatientBtn_Click(object sender, EventArgs e)
        {
            Patient pat = new Patient();
            pat.Show();
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

            date = MonthCmbBox.Text + "/" + DayCmbBox.Text + "/" + YearCmbBox.Text;
            if (MonthCmbBox.Text != "" && DayCmbBox.Text != "" && YearCmbBox.Text != "" && modePay.Text == "")
            {
                connection.Open();



                SqlDataAdapter sda = new SqlDataAdapter("select *from PaymentTable where Date = '" + MonthCmbBox.Text + "/" + DayCmbBox.Text + "/" + YearCmbBox.Text + "' ", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                ListViewItem lvi0 = new ListViewItem();
                listView1.Items.Clear();
                listView1.BeginUpdate();
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    DataRow dr0 = dt.Rows[row];
                    ListViewItem listitem = new ListViewItem(dr0["PatientNo"].ToString());
                    listitem.SubItems.Add(Convert.ToDateTime(dr0["Date"]).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));
                    listitem.SubItems.Add(dr0["ModeOfPayment"].ToString());
                    listitem.SubItems.Add(dr0["AmountPayed"].ToString());
                    listitem.SubItems.Add(dr0["Balance"].ToString());
                    listitem.SubItems.Add(dr0["status"].ToString());

                    listView1.Items.Add(listitem);
                }
                listView1.EndUpdate();
                connection.Close();

            }
            else if (MonthCmbBox.Text != "" && DayCmbBox.Text != "" && YearCmbBox.Text != "" && modePay.Text == "Cash")
            {
                connection.Open();



                SqlDataAdapter sda = new SqlDataAdapter("select *from PaymentTable where Date = '" + MonthCmbBox.Text + "/" + DayCmbBox.Text + "/" + YearCmbBox.Text + "' and ModeOfPayment ='Cash'", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                ListViewItem lvi0 = new ListViewItem();
                listView1.Items.Clear();
                listView1.BeginUpdate();
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    DataRow dr0 = dt.Rows[row];
                    ListViewItem listitem = new ListViewItem(dr0["PatientNo"].ToString());
                    listitem.SubItems.Add(Convert.ToDateTime(dr0["Date"]).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));
                    listitem.SubItems.Add(dr0["ModeOfPayment"].ToString());
                    listitem.SubItems.Add(dr0["AmountPayed"].ToString());
                    listitem.SubItems.Add(dr0["Balance"].ToString());
                    listitem.SubItems.Add(dr0["status"].ToString());

                    listView1.Items.Add(listitem);
                }
                listView1.EndUpdate();
                connection.Close();
            }
            else if (MonthCmbBox.Text != "" && DayCmbBox.Text != "" && YearCmbBox.Text != "" && modePay.Text == "Check")
            {
                connection.Open();



                SqlDataAdapter sda = new SqlDataAdapter("select *from PaymentTable where Date = '" + MonthCmbBox.Text + "/" + DayCmbBox.Text + "/" + YearCmbBox.Text + "' and ModeOfPayment ='Check'", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                ListViewItem lvi0 = new ListViewItem();
                listView1.Items.Clear();
                listView1.BeginUpdate();
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    DataRow dr0 = dt.Rows[row];
                    ListViewItem listitem = new ListViewItem(dr0["PatientNo"].ToString());
                    listitem.SubItems.Add(Convert.ToDateTime(dr0["Date"]).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));
                    listitem.SubItems.Add(dr0["ModeOfPayment"].ToString());
                    listitem.SubItems.Add(dr0["AmountPayed"].ToString());
                    listitem.SubItems.Add(dr0["Balance"].ToString());
                    listitem.SubItems.Add(dr0["status"].ToString());

                    listView1.Items.Add(listitem);
                }
                listView1.EndUpdate();
                connection.Close();
            }
        }

        private void DayCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            date = MonthCmbBox.Text + "/" + DayCmbBox.Text + "/" + YearCmbBox.Text;
            if (MonthCmbBox.Text != "" && DayCmbBox.Text != "" && YearCmbBox.Text != "" && modePay.Text == "")
            {
                connection.Open();



                SqlDataAdapter sda = new SqlDataAdapter("select *from PaymentTable where Date = '" + MonthCmbBox.Text + "/" + DayCmbBox.Text + "/" + YearCmbBox.Text + "' ", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                ListViewItem lvi0 = new ListViewItem();
                listView1.Items.Clear();
                listView1.BeginUpdate();
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    DataRow dr0 = dt.Rows[row];
                    ListViewItem listitem = new ListViewItem(dr0["PatientNo"].ToString());
                    listitem.SubItems.Add(Convert.ToDateTime(dr0["Date"]).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));
                    listitem.SubItems.Add(dr0["ModeOfPayment"].ToString());
                    listitem.SubItems.Add(dr0["AmountPayed"].ToString());
                    listitem.SubItems.Add(dr0["Balance"].ToString());
                    listitem.SubItems.Add(dr0["status"].ToString());

                    listView1.Items.Add(listitem);
                }
                listView1.EndUpdate();
                connection.Close();

            }
            else if (MonthCmbBox.Text != "" && DayCmbBox.Text != "" && YearCmbBox.Text != "" && modePay.Text == "Cash")
            {
                connection.Open();



                SqlDataAdapter sda = new SqlDataAdapter("select *from PaymentTable where Date = '" + MonthCmbBox.Text + "/" + DayCmbBox.Text + "/" + YearCmbBox.Text + "' and ModeOfPayment ='Cash'", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                ListViewItem lvi0 = new ListViewItem();
                listView1.Items.Clear();
                listView1.BeginUpdate();
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    DataRow dr0 = dt.Rows[row];
                    ListViewItem listitem = new ListViewItem(dr0["PatientNo"].ToString());
                    listitem.SubItems.Add(Convert.ToDateTime(dr0["Date"]).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));
                    listitem.SubItems.Add(dr0["ModeOfPayment"].ToString());
                    listitem.SubItems.Add(dr0["AmountPayed"].ToString());
                    listitem.SubItems.Add(dr0["Balance"].ToString());
                    listitem.SubItems.Add(dr0["status"].ToString());

                    listView1.Items.Add(listitem);
                }
                listView1.EndUpdate();
                connection.Close();
            }
            else if (MonthCmbBox.Text != "" && DayCmbBox.Text != "" && YearCmbBox.Text != "" && modePay.Text == "Check")
            {
                connection.Open();



                SqlDataAdapter sda = new SqlDataAdapter("select *from PaymentTable where Date = '" + MonthCmbBox.Text + "/" + DayCmbBox.Text + "/" + YearCmbBox.Text + "' and ModeOfPayment ='Check'", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                ListViewItem lvi0 = new ListViewItem();
                listView1.Items.Clear();
                listView1.BeginUpdate();
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    DataRow dr0 = dt.Rows[row];
                    ListViewItem listitem = new ListViewItem(dr0["PatientNo"].ToString());
                    listitem.SubItems.Add(Convert.ToDateTime(dr0["Date"]).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));
                    listitem.SubItems.Add(dr0["ModeOfPayment"].ToString());
                    listitem.SubItems.Add(dr0["AmountPayed"].ToString());
                    listitem.SubItems.Add(dr0["Balance"].ToString());
                    listitem.SubItems.Add(dr0["status"].ToString());

                    listView1.Items.Add(listitem);
                }
                listView1.EndUpdate();
                connection.Close();
            }
        }

        private void YearCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            date = MonthCmbBox.Text + "/" + DayCmbBox.Text + "/" + YearCmbBox.Text;
            if (MonthCmbBox.Text != "" && DayCmbBox.Text != "" && YearCmbBox.Text != "" && modePay.Text == "")
            {
                connection.Open();



                SqlDataAdapter sda = new SqlDataAdapter("select *from PaymentTable where Date = '" + MonthCmbBox.Text + "/" + DayCmbBox.Text + "/" + YearCmbBox.Text + "' ", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                ListViewItem lvi0 = new ListViewItem();
                listView1.Items.Clear();
                listView1.BeginUpdate();
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    DataRow dr0 = dt.Rows[row];
                    ListViewItem listitem = new ListViewItem(dr0["PatientNo"].ToString());
                    listitem.SubItems.Add(Convert.ToDateTime(dr0["Date"]).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));
                    listitem.SubItems.Add(dr0["ModeOfPayment"].ToString());
                    listitem.SubItems.Add(dr0["AmountPayed"].ToString());
                    listitem.SubItems.Add(dr0["Balance"].ToString());
                    listitem.SubItems.Add(dr0["status"].ToString());

                    listView1.Items.Add(listitem);
                }
                listView1.EndUpdate();
                connection.Close();

            }
            else if (MonthCmbBox.Text != "" && DayCmbBox.Text != "" && YearCmbBox.Text != "" && modePay.Text == "Cash")
            {
                connection.Open();



                SqlDataAdapter sda = new SqlDataAdapter("select *from PaymentTable where Date = '" + MonthCmbBox.Text + "/" + DayCmbBox.Text + "/" + YearCmbBox.Text + "' and ModeOfPayment ='Cash'", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                ListViewItem lvi0 = new ListViewItem();
                listView1.Items.Clear();
                listView1.BeginUpdate();
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    DataRow dr0 = dt.Rows[row];
                    ListViewItem listitem = new ListViewItem(dr0["PatientNo"].ToString());
                    listitem.SubItems.Add(Convert.ToDateTime(dr0["Date"]).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));
                    listitem.SubItems.Add(dr0["ModeOfPayment"].ToString());
                    listitem.SubItems.Add(dr0["AmountPayed"].ToString());
                    listitem.SubItems.Add(dr0["Balance"].ToString());
                    listitem.SubItems.Add(dr0["status"].ToString());

                    listView1.Items.Add(listitem);
                }
                listView1.EndUpdate();
                connection.Close();
            }
            else if (MonthCmbBox.Text != "" && DayCmbBox.Text != "" && YearCmbBox.Text != "" && modePay.Text == "Check")
            {
                connection.Open();



                SqlDataAdapter sda = new SqlDataAdapter("select *from PaymentTable where Date = '" + MonthCmbBox.Text + "/" + DayCmbBox.Text + "/" + YearCmbBox.Text + "' and ModeOfPayment ='Check'", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                ListViewItem lvi0 = new ListViewItem();
                listView1.Items.Clear();
                listView1.BeginUpdate();
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    DataRow dr0 = dt.Rows[row];
                    ListViewItem listitem = new ListViewItem(dr0["PatientNo"].ToString());
                    listitem.SubItems.Add(Convert.ToDateTime(dr0["Date"]).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));
                    listitem.SubItems.Add(dr0["ModeOfPayment"].ToString());
                    listitem.SubItems.Add(dr0["AmountPayed"].ToString());
                    listitem.SubItems.Add(dr0["Balance"].ToString());
                    listitem.SubItems.Add(dr0["status"].ToString());

                    listView1.Items.Add(listitem);
                }
                listView1.EndUpdate();
                connection.Close();
            }
        }

        private void modePay_SelectedIndexChanged(object sender, EventArgs e)
        {

            date = MonthCmbBox.Text + "/" + DayCmbBox.Text + "/" + YearCmbBox.Text;
            if (MonthCmbBox.Text != "" && DayCmbBox.Text != "" && YearCmbBox.Text != ""&& modePay.Text=="")
            {
                connection.Open();



                SqlDataAdapter sda = new SqlDataAdapter("select *from PaymentTable where Date = '" + MonthCmbBox.Text + "/" + DayCmbBox.Text + "/" + YearCmbBox.Text + "' ", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                ListViewItem lvi0 = new ListViewItem();
                listView1.Items.Clear();
                listView1.BeginUpdate();
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    DataRow dr0 = dt.Rows[row];
                    ListViewItem listitem = new ListViewItem(dr0["PatientNo"].ToString());
                    listitem.SubItems.Add(Convert.ToDateTime(dr0["Date"]).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));
                    listitem.SubItems.Add(dr0["ModeOfPayment"].ToString());
                    listitem.SubItems.Add(dr0["AmountPayed"].ToString());
                    listitem.SubItems.Add(dr0["Balance"].ToString());
                    listitem.SubItems.Add(dr0["status"].ToString());

                    listView1.Items.Add(listitem);
                }
                listView1.EndUpdate();
                connection.Close();

            }
            else if (MonthCmbBox.Text != "" && DayCmbBox.Text != "" && YearCmbBox.Text != "" && modePay.Text =="Cash")
            {
                connection.Open();



                SqlDataAdapter sda = new SqlDataAdapter("select *from PaymentTable where Date = '" + MonthCmbBox.Text + "/" + DayCmbBox.Text + "/" + YearCmbBox.Text + "' and ModeOfPayment ='Cash'", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                ListViewItem lvi0 = new ListViewItem();
                listView1.Items.Clear();
                listView1.BeginUpdate();
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    DataRow dr0 = dt.Rows[row];
                    ListViewItem listitem = new ListViewItem(dr0["PatientNo"].ToString());
                    listitem.SubItems.Add(Convert.ToDateTime(dr0["Date"]).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));
                    listitem.SubItems.Add(dr0["ModeOfPayment"].ToString());
                    listitem.SubItems.Add(dr0["AmountPayed"].ToString());
                    listitem.SubItems.Add(dr0["Balance"].ToString());
                    listitem.SubItems.Add(dr0["status"].ToString());

                    listView1.Items.Add(listitem);
                }
                listView1.EndUpdate();
                connection.Close();
            }else if(MonthCmbBox.Text != "" && DayCmbBox.Text != "" && YearCmbBox.Text != "" && modePay.Text =="Check")
            {
                connection.Open();



                SqlDataAdapter sda = new SqlDataAdapter("select *from PaymentTable where Date = '" + MonthCmbBox.Text + "/" + DayCmbBox.Text + "/" + YearCmbBox.Text + "' and ModeOfPayment ='Check'", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                ListViewItem lvi0 = new ListViewItem();
                listView1.Items.Clear();
                listView1.BeginUpdate();
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    DataRow dr0 = dt.Rows[row];
                    ListViewItem listitem = new ListViewItem(dr0["PatientNo"].ToString());
                    listitem.SubItems.Add(Convert.ToDateTime(dr0["Date"]).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));
                    listitem.SubItems.Add(dr0["ModeOfPayment"].ToString());
                    listitem.SubItems.Add(dr0["AmountPayed"].ToString());
                    listitem.SubItems.Add(dr0["Balance"].ToString());
                    listitem.SubItems.Add(dr0["status"].ToString());

                    listView1.Items.Add(listitem);
                }
                listView1.EndUpdate();
                connection.Close();
            }
          
        }

        private void AddTransBtn_Click(object sender, EventArgs e)
        {
            Add_Transaction add = new Add_Transaction();
            add.Show();
            this.Hide();
        }

        private void MonthCmbBox_TextUpdate(object sender, EventArgs e)
        {
            if(MonthCmbBox.Text=="" && DayCmbBox.Text == ""&&YearCmbBox.Text =="")
            {
                connection.Open();



                SqlDataAdapter sda = new SqlDataAdapter("select *from PaymentTable ", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                ListViewItem lvi0 = new ListViewItem();
                listView1.Items.Clear();
                listView1.BeginUpdate();
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    DataRow dr0 = dt.Rows[row];
                    ListViewItem listitem = new ListViewItem(dr0["PatientNo"].ToString());
                    listitem.SubItems.Add(Convert.ToDateTime(dr0["Date"]).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));
                    listitem.SubItems.Add(dr0["ModeOfPayment"].ToString());
                    listitem.SubItems.Add(dr0["AmountPayed"].ToString());
                    listitem.SubItems.Add(dr0["Balance"].ToString());
                    listitem.SubItems.Add(dr0["status"].ToString());

                    listView1.Items.Add(listitem);


                }
                listView1.EndUpdate();





                connection.Close();

            }
        }

        private void DayCmbBox_TextUpdate(object sender, EventArgs e)
        {
            if (MonthCmbBox.Text == "" && DayCmbBox.Text == "" && YearCmbBox.Text == "")
            {
                connection.Open();



                SqlDataAdapter sda = new SqlDataAdapter("select *from PaymentTable ", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                ListViewItem lvi0 = new ListViewItem();
                listView1.Items.Clear();
                listView1.BeginUpdate();
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    DataRow dr0 = dt.Rows[row];
                    ListViewItem listitem = new ListViewItem(dr0["PatientNo"].ToString());
                    listitem.SubItems.Add(Convert.ToDateTime(dr0["Date"]).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));
                    listitem.SubItems.Add(dr0["ModeOfPayment"].ToString());
                    listitem.SubItems.Add(dr0["AmountPayed"].ToString());
                    listitem.SubItems.Add(dr0["Balance"].ToString());
                    listitem.SubItems.Add(dr0["status"].ToString());

                    listView1.Items.Add(listitem);


                }
                listView1.EndUpdate();





                connection.Close();

            }
        }

        private void YearCmbBox_TextUpdate(object sender, EventArgs e)
        {
            if (MonthCmbBox.Text == "" && DayCmbBox.Text == "" && YearCmbBox.Text == "")
            {
                connection.Open();



                SqlDataAdapter sda = new SqlDataAdapter("select *from PaymentTable ", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                ListViewItem lvi0 = new ListViewItem();
                listView1.Items.Clear();
                listView1.BeginUpdate();
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    DataRow dr0 = dt.Rows[row];
                    ListViewItem listitem = new ListViewItem(dr0["PatientNo"].ToString());
                    listitem.SubItems.Add(Convert.ToDateTime(dr0["Date"]).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));
                    listitem.SubItems.Add(dr0["ModeOfPayment"].ToString());
                    listitem.SubItems.Add(dr0["AmountPayed"].ToString());
                    listitem.SubItems.Add(dr0["Balance"].ToString());
                    listitem.SubItems.Add(dr0["status"].ToString());

                    listView1.Items.Add(listitem);


                }
                listView1.EndUpdate();





                connection.Close();

            }
        }
    }
}
