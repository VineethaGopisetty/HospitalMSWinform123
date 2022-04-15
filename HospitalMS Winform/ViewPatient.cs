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
    public partial class ViewPatient : Form
    {
        public ViewPatient()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=INBLL000519;Initial Catalog=HospitalPatient;Integrated Security=True");
        private void fetchempdata()
        {
            Con.Open();
            string query = "Select * from HospitalPatientTbl where PatientId='" + PatientidTb.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                PatientIdlbl.Text = dr["Patientid"].ToString();
                PatientNamelbl.Text = dr["Patientname"].ToString();
                PatientAddlbl.Text = dr["Patientadd"].ToString();
                PatientGenlbl.Text = dr["PatientGen"].ToString();
                Patientphonelbl.Text = dr["Patientphone"].ToString();
                PatientBGPlbl.Text = dr["PatientBGP"].ToString();
                PatientAgelbl.Text = dr["PatientAge"].ToString();
                PatientDislbl.Text = dr["PatientDisease"].ToString();
                Wordlbl.Text = dr["TypeOfWord"].ToString();
              

                PatientIdlbl.Visible = true;
                PatientNamelbl.Visible = true;
                PatientAddlbl.Visible = true;
                PatientGenlbl.Visible = true;
                Patientphonelbl.Visible = true;
                PatientBGPlbl.Visible = true;
                PatientAgelbl.Visible = true;
                PatientDislbl.Visible = true;
                Wordlbl.Visible = true;

            }
            Con.Close();
        }
        private void ViewPatient_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fetchempdata();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("====PATIENT SUMMARY====", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(180));
            e.Graphics.DrawString("Patient ID: " + PatientIdlbl.Text + "\tPatient Name: " + PatientNamelbl.Text, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(10, 100));
            e.Graphics.DrawString("Patient Address: " + PatientAddlbl.Text + "\tPatient Gender: " + PatientGenlbl.Text, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(10, 140));
            e.Graphics.DrawString("Type Of Word: " + Wordlbl.Text + "\tPatient Age: " + PatientAgelbl.Text, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(10, 180));
            e.Graphics.DrawString("Patient Phone: " + Patientphonelbl.Text +"\tPatient Disease: " + PatientDislbl.Text, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(10, 220));

            e.Graphics.DrawString("====================", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Orange, new Point(180, 280));

        }
    }
}
