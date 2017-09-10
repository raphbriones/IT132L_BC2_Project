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
    public partial class Weekly_Reportd : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=ASUS-PC\SQLEXPRESS01;Initial Catalog=IT132L;Integrated Security=True");
        int amountPayed,PamountPayed;
        string smallest="1/1/1",largest="1/1/1";
        List<string> dates = new List<string>();
        List<string> dates2 = new List<string>();
        public Weekly_Reportd()
        {
            InitializeComponent();
        }

        private void Weekly_Reportd_Load(object sender, EventArgs e)
        {
            connection.Open();


            SqlDataAdapter sda0 = new SqlDataAdapter("select *from StockTable  ", connection);
            DataTable dt0 = new DataTable();
            sda0.Fill(dt0);

            ListViewItem lvi0 = new ListViewItem();
            listView2.Items.Clear();
            listView2.BeginUpdate();
            for (int row = 0; row < dt0.Rows.Count; row++)
            {
                DataRow dr = dt0.Rows[row];
                ListViewItem listitem = new ListViewItem(dr["ItemNo"].ToString());
                listitem.SubItems.Add(dr["MedicalName"].ToString());
                listitem.SubItems.Add(dr["GenericName"].ToString());
                listitem.SubItems.Add(dr["Size"].ToString());
                listitem.SubItems.Add(dr["AmountInStock"].ToString());
                listitem.SubItems.Add(dr["Price"].ToString());
                listitem.SubItems.Add(Convert.ToDateTime(dr["ExpirationDate"]).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));
                listitem.SubItems.Add(dr["Status"].ToString());
                listView2.Items.Add(listitem);


            }
            listView2.EndUpdate();
            connection.Close();

            connection.Open();
            SqlCommand c = new SqlCommand(" select sum(amountPayed) As TotalPayed from PaymentTable", connection);
            SqlDataReader reader = c.ExecuteReader();
            if(reader.HasRows){
            while(reader.Read())
            {
                
                 ypayed.Text = reader[0].ToString() + " php "; 
              
            }}
            else
            {
                ypayed.Text = "0.00 php";
            }

            connection.Close();
            connection.Open();
     
            SqlCommand com = new SqlCommand("Select Date from PaymentTable ", connection);
            SqlDataReader r = com.ExecuteReader();
            while(r.Read())
            {
                if (System.DateTime.Today.DayOfYear - Convert.ToDateTime(r[0]).DayOfYear <= 7)
                {
                     dates.Add(r[0].ToString());                  
                }
                if(System.DateTime.Today.DayOfYear - Convert.ToDateTime(r[0]).DayOfYear>=7 && System.DateTime.Today.DayOfYear - Convert.ToDateTime(r[0]).DayOfYear<=14 )
                {
                    dates2.Add(r[0].ToString());
                }
            }
           
           
            for(int i= 0;i<dates.Count;i++)
            {
                connection.Close();

                
                connection.Open();
                SqlCommand com0 = new SqlCommand("Select AmountPayed from PaymentTable where Date ='"+dates[i]+"'", connection);
                SqlDataReader r0 = com0.ExecuteReader();
                
                while(r0.Read())
                {
                    
                    amountPayed = amountPayed+ Convert.ToInt32(r0[0]);
                    break;

                }

          
                connection.Close();
            }
            for (int i = 0; i < dates2.Count; i++)
            {
                connection.Close();


                connection.Open();
                SqlCommand com0 = new SqlCommand("Select AmountPayed from PaymentTable where Date ='" + dates2[i] + "'", connection);
                SqlDataReader r0 = com0.ExecuteReader();

                while (r0.Read())
                {

                    PamountPayed = PamountPayed + Convert.ToInt32(r0[0]);
                    break;

                }


                connection.Close();
            }

            ppayed.Text = Convert.ToDouble(PamountPayed).ToString() + ".00 php ";
            if (dates.Count < 0)
            {
                smallest = dates[0];

                for (int i = 1; i < dates.Count; i++)
                {
                    if (Convert.ToDateTime(dates[i]).DayOfYear < Convert.ToDateTime(smallest).DayOfYear)
                    {
                        largest = smallest;
                        smallest = dates[i];
                    }
                    else if (Convert.ToDateTime(dates[i]).DayOfYear > Convert.ToDateTime(smallest).DayOfYear)
                    {
                        largest = dates[i];
                    }
                    else
                    {
                        largest = smallest;
                    }

                }
            }
            connection.Close();
                connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select *from PaymentTable where Date between '"+smallest+"' and '"+largest+"'", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            ListViewItem lvi = new ListViewItem();
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



            Payed.Text = Convert.ToDouble(amountPayed).ToString() + ".00 php "; 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
