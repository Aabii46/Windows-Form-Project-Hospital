using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abu_Hospital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (uname_txt.Text == "Admin" && pass_txt.Text == "Admin123")
                {
                    MessageBox.Show("Welcome Back Admin");

                    Homepage HP = new Homepage();
                    HP.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid Password");
                }
            }
            catch(Exception ex)
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
            uname_txt.Clear();
            pass_txt.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            pass_txt.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }
    }
}
