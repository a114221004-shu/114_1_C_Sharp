using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace How_Much_Insurance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void costButton_Click(object sender, EventArgs e)
        {
            double cost = 0;

            try
            {

                cost = double.Parse(costTextBox.Text);

                cost = cost * 0.8;

                insuranceLabel.Text = cost.ToString("n2");

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"例外發生!");
                
                costTextBox.Focus();
                
                costTextBox.Text = "";
            }
        }
             private void clearButton_Click(object sender, EventArgs e)
        {
            costTextBox.Text = "";
            insuranceLabel.Text = "";
            costTextBox.Focus();
        }
    }
}
