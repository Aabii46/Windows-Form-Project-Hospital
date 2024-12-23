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
using System.Configuration;

namespace Abu_Hospital
{
    public partial class Addpatient : Form
    {
        public Addpatient()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["HospitalConnection"].ConnectionString;

                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_patient", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter P3 = new SqlParameter("@Patient_Name", SqlDbType.VarChar);
                cmd.Parameters.Add(P3).Value = txt_patient.Text;

                SqlParameter P4 = new SqlParameter("@Patient_Age", SqlDbType.Int);
                cmd.Parameters.Add(P4).Value = txt_age.Text;



                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    MessageBox.Show("Patient Added Successfully");
                }
                else
                {
                    MessageBox.Show("Patient Added Failed!!!!");
                }

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please check the data");
            }
        }
            


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txt_patient.Clear();
            txt_age.Clear();
        }

        private void Addpatient_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Homepage HP = new Homepage();
            HP.Show();
            this.Hide();
        }
    }
}
