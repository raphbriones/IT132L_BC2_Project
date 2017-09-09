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
    public partial class View_Detailed_Patient : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=ASUS-PC\SQLEXPRESS01;Initial Catalog=IT132L;Integrated Security=True");

        
        public View_Detailed_Patient()
        {
            InitializeComponent();

        }
        int Pnum;
        public View_Detailed_Patient(int x)
        {
            InitializeComponent();
            Pnum = x;
        }
        private void View_Detailed_Patient_Load(object sender, EventArgs e)
        {
            PatientNumber.Items.Clear();
            EditContactInfoBtn.Enabled = false;
            EditTreatment.Enabled = false;
            AddTreatment.Enabled = false;
            connection.Open();


            SqlCommand com = new SqlCommand("select PatientNo from PatientTable", connection);
            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                PatientNumber.Items.Add(reader[0]);
            }
            connection.Close();

            if(Pnum!=null)
            {
                
               for(int i=0;i<PatientNumber.Items.Count;i++)
               {
                   if(PatientNumber.Items[i].ToString()==Pnum.ToString())
                   {
                       PatientNumber.SelectedIndex = i;
                   }
               }
            }

            
            
        }

        private void PatientNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = "Patient " + PatientNumber.SelectedItem.ToString();
            if (PatientNumber.SelectedItem != null)
            {
                EditContactInfoBtn.Enabled = true;
                EditTreatment.Enabled = true;
                AddTreatment.Enabled = true;
                connection.Open();
                SqlCommand com = new SqlCommand("select LastName + ', '+ FirstName+' '+MiddleName+' ' from PatientTable where PatientNo = " + PatientNumber.Text + "", connection);
                SqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    PatientName.Text = reader[0].ToString();
                }
                connection.Close();
                connection.Open();
                SqlCommand com0 = new SqlCommand("select Birthday from PatientTable where PatientNo = " + PatientNumber.Text + "", connection);
                SqlDataReader reader0 = com0.ExecuteReader();

                while (reader0.Read())
                {
                    birthday.Text = Convert.ToDateTime(reader0[0]).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                }
                connection.Close();
                connection.Open();
                SqlCommand com1 = new SqlCommand("select Age from PatientTable where PatientNo = " + PatientNumber.Text + "", connection);
                SqlDataReader reader1 = com1.ExecuteReader();

                while (reader1.Read())
                {
                    Age.Text = reader1[0].ToString();
                }
                connection.Close();
                connection.Open();
                SqlCommand com2 = new SqlCommand("select Occupation from PatientTable where PatientNo = " + PatientNumber.Text + "", connection);
                SqlDataReader reader2 = com2.ExecuteReader();

                while (reader2.Read())
                {
                    occupation.Text = reader2[0].ToString();
                }
                connection.Close();
                connection.Open();
                SqlCommand com3 = new SqlCommand("select status from PatientTable where PatientNo = " + PatientNumber.Text + "", connection);
                SqlDataReader reader3 = com3.ExecuteReader();

                while (reader3.Read())
                {
                    status.Text = reader3[0].ToString();
                }
                connection.Close();
                connection.Open();
                SqlCommand com4 = new SqlCommand("select Address from ContactInformationTable where PatientNo = " + PatientNumber.Text + "", connection);
                SqlDataReader reader4 = com4.ExecuteReader();

                while (reader4.Read())
                {
                  Address.Text = reader4[0].ToString();
                }
                connection.Close();
                connection.Open();
                SqlCommand com5 = new SqlCommand("select EmailAdd from ContactInformationTable where PatientNo = " + PatientNumber.Text + "", connection);
                SqlDataReader reader5 = com5.ExecuteReader();

                while (reader5.Read())
                {
                    EmailAdd.Text = reader5[0].ToString();
                }
                connection.Close();
                connection.Open();
                SqlCommand com6 = new SqlCommand("select ContactNo from ContactInformationTable where PatientNo = " + PatientNumber.Text + "", connection);
                SqlDataReader reader6 = com6.ExecuteReader();

                while (reader6.Read())
                {
                    ContactNo.Text = reader6[0].ToString();
                }
                connection.Close();


                connection.Open();
            

                SqlDataAdapter sda = new SqlDataAdapter("select *from TreatmentHistoryTable where PatientNo = "+ PatientNumber.Text, connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                ListViewItem lvi = new ListViewItem();
                listView1.Items.Clear();
                listView1.BeginUpdate();
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    DataRow dr = dt.Rows[row];
                    ListViewItem listitem = new ListViewItem(dr["Condition"].ToString());
                    listitem.SubItems.Add(dr["Treatment"].ToString());
                    listitem.SubItems.Add(dr["Status"].ToString());
                    listitem.SubItems.Add(dr["Date"].ToString());
                 
                    listView1.Items.Add(listitem);


                }
                listView1.EndUpdate();





                connection.Close();

                connection.Open();


                SqlDataAdapter sda0 = new SqlDataAdapter("select *from PaymentTable where PatientNo = " + PatientNumber.Text, connection);
                DataTable dt0 = new DataTable();
                sda0.Fill(dt0);

                ListViewItem lvi0 = new ListViewItem();
                listView2.Items.Clear();
                listView2.BeginUpdate();
                for (int row = 0; row < dt0.Rows.Count; row++)
                {
                    DataRow dr0 = dt0.Rows[row];
                    ListViewItem listitem = new ListViewItem(Convert.ToDateTime(dr0["Date"]).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));
                    listitem.SubItems.Add(dr0["ModeOfPayment"].ToString());
                    listitem.SubItems.Add(dr0["AmountPayed"].ToString());
                    listitem.SubItems.Add(dr0["Balance"].ToString());
                    listitem.SubItems.Add(dr0["status"].ToString());

                    listView2.Items.Add(listitem);


                }
                listView2.EndUpdate();





                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Patient back = new Patient();
            back.Show();
            this.Hide();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EditContactInfoBtn_Click(object sender, EventArgs e)
        {
            Edit_Contact_Info edit = new Edit_Contact_Info(Convert.ToInt32(PatientNumber.Text));
            edit.Show();
            this.Hide();
        }

        private void AddTreatment_Click(object sender, EventArgs e)
        {

            Add_Treatment addT = new Add_Treatment(Convert.ToInt32(PatientNumber.Text));
            addT.Show();
            this.Hide();
        }

        private void EditTreatment_Click(object sender, EventArgs e)
        {
            Edit_Treatment editT = new Edit_Treatment(Convert.ToInt32(PatientNumber.Text));
            editT.Show();
            this.Hide();
        }
    }
}
