﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial_2_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "芬蘭";
            countryLabel.Font = new Font(countryLabel.Font.FontFamily, 24, countryLabel.Font.Style);
        }

        private void finlandPictureBox_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "法國";
            countryLabel.Font = new Font(countryLabel.Font.FontFamily, 24, countryLabel.Font.Style);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "德國";
            countryLabel.Font = new Font(countryLabel.Font.FontFamily, 24, countryLabel.Font.Style);
        }
    }
}
