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
    public partial class Update_Medicine : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=ASUS-PC\SQLEXPRESS01;Initial Catalog=IT132L;Integrated Security=True");

        public Update_Medicine()
        {
            InitializeComponent();
        }

        private void Update_Medicine_Load(object sender, EventArgs e)
        {
            ItemNo.Items.Clear();
            connection.Open();
            Confirm.Enabled = false;
            NQuantity.Enabled = false;

            SqlCommand com = new SqlCommand("select ItemNo from StockTable", connection);
            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                ItemNo.Items.Add(reader[0]);
            }
            connection.Close();
        }

        private void ItemNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            if (ItemNo.SelectedItem != null)
            {
                NQuantity.Enabled = true;
                SqlCommand com = new SqlCommand("select MedicalName from StockTable where ItemNo = '" + ItemNo.SelectedItem.ToString() + "'", connection);
                SqlDataReader read = com.ExecuteReader();

                while (read.Read())
                {
                    MedicalName.Text = read[0].ToString();
                }
                connection.Close();
                connection.Open();
                SqlCommand com0 = new SqlCommand("select GenericName from StockTable where ItemNo = '" + ItemNo.SelectedItem.ToString() + "'", connection);
                SqlDataReader read0 = com0.ExecuteReader();

                while (read0.Read())
                {

                    GenericName.Text = read0[0].ToString();
                }
                connection.Close();

                connection.Open();
                SqlCommand com1 = new SqlCommand("select Size from StockTable where ItemNo = '" + ItemNo.SelectedItem.ToString() + "'", connection);
                SqlDataReader read1 = com1.ExecuteReader();

                while (read1.Read())
                {
                    Size.Text = read1[0].ToString();
                }
                connection.Close();
                connection.Open();
                SqlCommand com2 = new SqlCommand("select AmountInStock from StockTable where ItemNo = '" + ItemNo.SelectedItem.ToString() + "'", connection);
                SqlDataReader read2 = com2.ExecuteReader();

                while (read2.Read())
                {
                    Quantity.Text = read2[0].ToString();
                }
                connection.Close();
                connection.Open();
                SqlCommand com3 = new SqlCommand("select ExpirationDate from StockTable where ItemNo = '" + ItemNo.SelectedItem.ToString() + "'", connection);
                SqlDataReader read3 = com3.ExecuteReader();

                while (read3.Read())
                {
                    ExpirationDate.Text = Convert.ToDateTime(read3[0]).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);


                }
                connection.Close();
                connection.Open();
                SqlCommand com4 = new SqlCommand("select Status from StockTable where ItemNo = '" + ItemNo.SelectedItem.ToString() + "'", connection);
                SqlDataReader read4 = com4.ExecuteReader();

                while (read4.Read())
                {
                    Status.Text = read4[0].ToString();
                }
                connection.Close();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Stock back = new Stock();
            back.Show();
            this.Hide();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            ItemNo.SelectedItem = null;
            MedicalName.Text = "";
            GenericName.Text = "";
            Size.Text = "";
            Quantity.Text = "";
            ExpirationDate.Text = "";
            Status.Text = "";
            NQuantity.Text = "";
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand com = new SqlCommand("Update StockTable set AmountInStock = "+NQuantity.Text+" where ItemNo = '" + ItemNo.SelectedItem.ToString() + "'", connection);
            com.ExecuteNonQuery();

            connection.Close();
            ItemNo.SelectedItem = null;
            MedicalName.Text = "";
            GenericName.Text = "";
            Size.Text = "";
            Quantity.Text = "";
            ExpirationDate.Text = "";
            Status.Text = "";
            NQuantity.Text = "";
        }

        private void NQuantity_TextChanged(object sender, EventArgs e)
        {
            Confirm.Enabled = true;
        }
    }
}
