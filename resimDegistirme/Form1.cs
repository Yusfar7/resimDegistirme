using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace resimDegistirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = radioButton2.Checked;
            label1.Text = "Resim 1";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Visible = radioButton3.Checked;
            label1.Text = "Resim 2";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox3.Visible = radioButton4.Checked;
            label1.Text = "Resim 3";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox4.Visible = radioButton5.Checked;
            label1.Text = "Resim 4";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox5.Visible = radioButton6.Checked;
            label1.Text = "Resim 5";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox6.Visible = radioButton7.Checked;
            label1.Text = "Resim 6";
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox7.Visible = radioButton8.Checked;
            label1.Text = "Resim 7";
        }
    }
}
