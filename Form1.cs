using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTP_092922_KeyboardAndCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void key1_Click(object sender, EventArgs e)
        {
            lblEkran.Text += "1";
        }

        private void key2_Click(object sender, EventArgs e)
        {
            lblEkran.Text += "2";
        }

        private void key3_Click(object sender, EventArgs e)
        {
            lblEkran.Text += "3";
        }

        private void key4_Click(object sender, EventArgs e)
        {
            lblEkran.Text += "4";
        }

        private void key5_Click(object sender, EventArgs e)
        {
            lblEkran.Text += "5";
        }

        private void key6_Click(object sender, EventArgs e)
        {
            lblEkran.Text += "6";
        }

        private void key7_Click(object sender, EventArgs e)
        {
            lblEkran.Text += "7";
        }

        private void key8_Click(object sender, EventArgs e)
        {
            lblEkran.Text += "8";
        }

        private void key9_Click(object sender, EventArgs e)
        {
            lblEkran.Text += "9";
        }

        private void key0_Click(object sender, EventArgs e)
        {
            lblEkran.Text += "0";
        }
    }
}
