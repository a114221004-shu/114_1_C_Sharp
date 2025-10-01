using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy
{
    public partial class Form1 : Form
    {
        // 建構函式，初始化表單元件
        public Form1()
        {
            InitializeComponent();
        }

        // 當使用者按下「計算油耗」按鈕時執行
        private void calculateButton_Click(object sender, EventArgs e)
        {
            double kilometers; // 宣告公里數變數（目前尚未使用）
            double liters;
            double kmpl;

            kilometers = double.Parse(milesTextBox.Text);
            liters = double.Parse(gallonsTextBox.Text);

            kmpl = kilometers / liters;

            mpgLabel.Text = kmpl.ToString("n2") + "公里/公升";
        }

        // 當使用者按下「離開」按鈕時執行
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
