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

namespace HospitalMS_Winform
{
    public partial class Slip : Form
    {
        public Slip()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=INBLL000519;Initial Catalog=HospitalPatient;Integrated Security=True");

        private void Bills_Load(object sender, EventArgs e)
        {

        }
        private void fetchempdata()
        {
            if (PatientIdlbl.Text == "")
            {
                MessageBox.Show("Enter Patient Id");
            }
            else
            {
                Con.Open();
                string query = "Select * from HospitalPatientTbl where PatientId='" + PatientIdlbl.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {

                    PatientNamelbl.Text = dr["Patientname"].ToString();
                    PatientGenTb.Text = dr["PatientGen"].ToString();
                    WordTb.Text = dr["TypeOfWord"].ToString();
                    //Dayslbl.Text = dr["Patientname"].ToString();

                }
                Con.Close();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fetchempdata();
        }
        int Dailybase, total;

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("====PATIENT BILLSLIP====", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(180));
            e.Graphics.DrawString("Patient ID: " + PatientIdlbl.Text , new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(10, 100));
            e.Graphics.DrawString("Patient Name: " + PatientNamelbl.Text , new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(10, 140));
            e.Graphics.DrawString("Type Of Word: " + WordTb.Text , new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(10, 180));
            e.Graphics.DrawString("Treatment Days: " + Dayslbl.Text, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(10, 220));
            e.Graphics.DrawString("Per Day Rs: " + Dailybase, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(10, 260));
            e.Graphics.DrawString("Total Amount: " + total, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(10, 300));

            e.Graphics.DrawString("====================", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Orange, new Point(180, 340));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (WordTb.Text == "")
            {
                MessageBox.Show("Select An employee");
            }
            else if (Dayslbl.Text == "" || Convert.ToInt32(Dayslbl.Text) > 100)
            {
                MessageBox.Show("Enter a valid Number of days");
            }
            else
            {
                if (WordTb.Text == "ICU")
                {
                    Dailybase = 1200;
                }
                else if (WordTb.Text == "DoubleBed")
                {
                    Dailybase = 1000;
                }
                else if (WordTb.Text == "General")
                {
                    Dailybase = 950;
                }
                else
                {
                    Dailybase = 850;
                }
                total = Dailybase * Convert.ToInt32(Dayslbl.Text);
                BillSlip.Text ="Patient Id: "+ PatientIdlbl.Text + "\n" + "Patient Name:  " + PatientNamelbl.Text + "\n" + "Type Of Word :  " + WordTb.Text + "\n" + "Treatment Days:  " + Dayslbl.Text + "\n" + "Per Day Rs:  " + Dailybase + "\n" + "Total Amount Rs:  " + total;

            }
        }
    }
}
