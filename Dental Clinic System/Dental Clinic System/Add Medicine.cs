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
    public partial class Add_Medicine : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=ASUS-PC\SQLEXPRESS01;Initial Catalog=IT132L;Integrated Security=True");

        public Add_Medicine()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (MedicalName.Text != "" && GenericName.Text != "" && Size.Text != "" && Quantity.Text != "" && Price.Text != "" && Day.SelectedItem != null && Month.SelectedItem != null && Year.SelectedItem != null)
            {
                confirmBtn.Enabled = true;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Stock back = new Stock();
            back.Show();
            this.Hide();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            MedicalName.Text = "";
            GenericName.Text = "";
            Size.Text = "";
            Quantity.Text = "";
            Price.Text = "";
            Day.SelectedItem = null;
            Month.SelectedItem = null;
            Year.SelectedItem = null;

        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand com = new SqlCommand("Insert into StockTable values('" + MedicalName.Text + "','" + GenericName.Text + "','" + Size.Text + "'," + Quantity.Text + "," + Price.Text + ",'" + Month.Text + "/" + Day.Text+ "/" + Year.Text + "','Fine')", connection);
            com.ExecuteNonQuery();
            connection.Close();

            MedicalName.Text = "";
            GenericName.Text = "";
            Size.Text = "";
            Quantity.Text = "";
            Price.Text = "";
            Day.SelectedItem = null;
            Month.SelectedItem = null;
            Year.SelectedItem = null;
        }

        private void Add_Medicine_Load(object sender, EventArgs e)
        {
            confirmBtn.Enabled = false;
        }

        private void GenericName_TextChanged(object sender, EventArgs e)
        {
            if (MedicalName.Text != "" && GenericName.Text != "" && Size.Text != "" && Quantity.Text != "" && Price.Text != "" && Day.SelectedItem != null && Month.SelectedItem != null && Year.SelectedItem != null)
            {
                confirmBtn.Enabled = true;
            }
        }

        private void Size_TextChanged(object sender, EventArgs e)
        {
            if (MedicalName.Text != "" && GenericName.Text != "" && Size.Text != "" && Quantity.Text != "" && Price.Text != "" && Day.SelectedItem != null && Month.SelectedItem != null && Year.SelectedItem != null)
            {
                confirmBtn.Enabled = true;
            }
        }

        private void Quantity_TextChanged(object sender, EventArgs e)
        {
            if (MedicalName.Text != "" && GenericName.Text != "" && Size.Text != "" && Quantity.Text != "" && Price.Text != "" && Day.SelectedItem != null && Month.SelectedItem != null && Year.SelectedItem != null)
            {
                confirmBtn.Enabled = true;
            }
        }

        private void Price_TextChanged(object sender, EventArgs e)
        {
            if (MedicalName.Text != "" && GenericName.Text != "" && Size.Text != "" && Quantity.Text != "" && Price.Text != "" && Day.SelectedItem != null && Month.SelectedItem != null && Year.SelectedItem != null)
            {
                confirmBtn.Enabled = true;
            }
        }

        private void Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MedicalName.Text != "" && GenericName.Text != "" && Size.Text != "" && Quantity.Text != "" && Price.Text != "" && Day.SelectedItem != null && Month.SelectedItem != null && Year.SelectedItem != null)
            {
                confirmBtn.Enabled = true;
            }
        }

        private void Day_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MedicalName.Text != "" && GenericName.Text != "" && Size.Text != "" && Quantity.Text != "" && Price.Text != "" && Day.SelectedItem != null && Month.SelectedItem != null && Year.SelectedItem != null)
            {
                confirmBtn.Enabled = true;
            }
        }

        private void Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MedicalName.Text != "" && GenericName.Text != "" && Size.Text != "" && Quantity.Text != "" && Price.Text != "" && Day.SelectedItem != null && Month.SelectedItem != null && Year.SelectedItem != null)
            {
                confirmBtn.Enabled = true;
            }
        }
    }
}
