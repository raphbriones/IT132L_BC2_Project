﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Clinic_System
{
    public partial class Form1 : Form
    {
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
            label4.Text = monthCalendar1.TodayDate.Month.ToString()+"/"+monthCalendar1.TodayDate.Day.ToString()+"/"+monthCalendar1.TodayDate.Year.ToString();
            MonthCmbBox.Text = monthCalendar1.TodayDate.Month.ToString();
            DayCmbBox.Text = monthCalendar1.TodayDate.Day.ToString();
            YearCmbBox.Text = monthCalendar1.TodayDate.Year.ToString();
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
    }
}