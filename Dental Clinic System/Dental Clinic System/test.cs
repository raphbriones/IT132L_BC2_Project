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
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void test_Load(object sender, EventArgs e)
        {
           
            SqlConnection connection = new SqlConnection(@"Data Source=ASUS-PC\SQLEXPRESS01;Initial Catalog=IT132L;Integrated Security=True");
            connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select *from ScheduleTable", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            ListViewItem lvi = new ListViewItem();
            listView1.BeginUpdate();
            for (int row = 0; row < dt.Rows.Count; row++)
            {
                for (int col = 0; col < dt.Columns.Count; col++)
                {
                    if (col > 0)
                    {
                        if (dt.Rows[row][col].ToString() == "")
                            lvi.SubItems.Add("NULL");
                        else
                            lvi.SubItems.Add(dt.Rows[row][col].ToString());
                    }
                    else
                        lvi = new ListViewItem(dt.Rows[row][col].ToString());

                }
                listView1.Items.Add(lvi);
            }
            listView1.EndUpdate();





            connection.Close();
        }
    }
}
