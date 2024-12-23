using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abu_Hospital
{
    public partial class AddDoctor : Form
    {
        public AddDoctor()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txt_Doctor.Clear();
            txt_age.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
          {


            string connectionString = ConfigurationManager.ConnectionStrings["HospitalConnection"].ConnectionString;

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand("sp_doctor", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter P1 = new SqlParameter("@Doctor_Name", SqlDbType.VarChar);
            cmd.Parameters.Add(P1).Value = txt_Doctor.Text;

            SqlParameter P2 = new SqlParameter("@Doctor_Age", SqlDbType.Int);
            cmd.Parameters.Add(P2).Value = txt_age.Text;



            int a = cmd.ExecuteNonQuery();

            if (a > 0)
            {
                MessageBox.Show("Doctor Added Successfully");
            }
            else
            {
                MessageBox.Show("Doctor Added Failed!!!!");
            }


            con.Close();

            
          }
            catch (Exception ex)
            {
                MessageBox.Show("Please check the data");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Homepage HP = new Homepage();
            HP.Show();
            this.Hide();
        }
    }
    
}
