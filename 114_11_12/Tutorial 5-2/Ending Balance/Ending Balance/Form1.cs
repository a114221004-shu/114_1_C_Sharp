using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ending_Balance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const decimal INTEREST_RATE = 0.005m; // 月利率

            decimal startingBalance; // 起始餘額
            int months;              // 月數
            int count = 1;            // 計數器

            if (decimal.TryParse(startingBalTextBox.Text, out startingBalance)) // 驗證起始餘額
            {
                if (int.TryParse(monthsTextBox.Text, out months) && months > 0) // 驗證月數
                { 
                    while (count <= months)
                    {
                        // 計算新的餘額。
                        startingBalance += startingBalance * INTEREST_RATE; //startingBalance = startingBalance * ( 1 + INTEREST_RATE );
                        // 在 ListBox 中顯示每個月的餘額。
                        detailListBox.Items.Add("第"  + count + "個月結餘:" + startingBalance.ToString("c")); 
                        // 將計數器加 1。
                        count = count + 1; //count++
                    }

                    endingBalanceLabel.Text = startingBalance.ToString("c2"); // 顯示最終餘額
                }
                else
                {
                    MessageBox.Show("請輸入有效的月數。","輸入錯誤");
                    monthsTextBox.Focus();
                    return;
                }
            }
            else
            { 
                MessageBox.Show("請輸入有效的起始餘額。","輸入錯誤");
                startingBalTextBox.Focus();
                return;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除 TextBox、endingBalanceLabel 控制項
            // 以及 ListBox 中的項目。
            startingBalTextBox.Text = "";
            monthsTextBox.Text = "";
            endingBalanceLabel.Text = "";
            detailListBox.Items.Clear();

            // 重設焦點到起始餘額輸入框。
            startingBalTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
