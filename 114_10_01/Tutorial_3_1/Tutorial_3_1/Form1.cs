using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial_3_1
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

        private void showDateButton_Click(object sender, EventArgs e)
        {
            string dayOfWeek = dayOfWeekTextBox.Text;
            string month = dayOfMonthTextBox.Text;
            string year = dayOfYearTextBox.Text;
            string dayOfMonth = dayOfDateTextBox.Text;

            dateOutputLabel.Text = " 中華民國 " + year + " 年 " + month + " 月 " + dayOfMonth + " 日 " + " ，星期 " + dayOfWeek;
             
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            dayOfWeekTextBox.Text = "";
            dayOfDateTextBox.Text = "";
            dayOfMonthTextBox.Text = "";
            dayOfYearTextBox.Text = "";
            dateOutputLabel.Text = "";
        }
    }
}
