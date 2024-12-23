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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Addpatient AP = new Addpatient();
            AP.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddDoctor AD = new AddDoctor();
            AD.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showpatient SP = new showpatient();
            SP.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showdoctor SD = new showdoctor();
            SD.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 LG = new Form1();
            LG.Show();
            this.Hide();
        }
    }
}
