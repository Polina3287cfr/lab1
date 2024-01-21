using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polina
{
    public partial class Form1 : Form
    {
        string baseurl = "C:\\Users\\Lena\\Desktop\\lab1\\Polina\\Polina\\img\\";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile($"{baseurl}car1.png");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile($"{baseurl}car2.png");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile($"{baseurl}car3.png");
        }

        private void label4_Click(object sender, EventArgs e)
        {

            pictureBox1.Image = Image.FromFile($"{baseurl}car4.png");
        }

        private void label7_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile($"{baseurl}car5.png");
        }

        private void label6_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile($"{baseurl}car6.png");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile($"{baseurl}car7.png");
        }

        private void label13_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile($"{baseurl}car8.png");
        }

        private void label12_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile($"{baseurl}car9.png");
        }

        private void label11_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile($"{baseurl}car10.png");
        }

        private void label10_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile($"{baseurl}car11.png");
        }

        private void label9_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile($"{baseurl}car12.png");
        }

        private void label8_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile($"{baseurl}car13.png");
        }

        private void label15_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile($"{baseurl}car14.png");
        }

        private void label14_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile($"{baseurl}car15.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
