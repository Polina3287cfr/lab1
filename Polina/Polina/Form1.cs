﻿using System;
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
        string baseurl = "C:\\Users\\Lab106(35)\\source\\repos\\Polina\\Polina\\img\\";
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
    }
}
