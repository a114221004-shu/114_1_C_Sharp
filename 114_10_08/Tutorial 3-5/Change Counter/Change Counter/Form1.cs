using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Change_Counter
{
    public partial class Form1 : Form
    {
        // 定義各種硬幣的面額（單位：分）
        const decimal FIVE_CENTS = 5.0m;           // 5分硬幣
        const decimal TEN_CENTS = 10.0m;           // 10分硬幣
        const decimal TWENTY_FIVE_CENTS = 25.0m;   // 25分硬幣
        const decimal FIFTY_CENTS = 50.0m;         // 50分硬幣

        // 用來累加所有硬幣的總金額（單位：分）
        private decimal total;

        // 建構子，初始化表單元件
        public Form1()
        {
            InitializeComponent();
        }

        // 當使用者點擊5分硬幣圖片時執行此事件，將5分累加到總金額
        private void fiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            total += FIVE_CENTS;
            // 將目前累加的總金額顯示在標籤上
            totalLabel.Text = total.ToString();
        }

        // 當使用者點擊10分硬幣圖片時執行此事件，將10分累加到總金額
        private void tenCentsPictureBox_Click(object sender, EventArgs e)
        {
            total += TEN_CENTS;
            totalLabel.Text = total.ToString();
        }

        // 當使用者點擊25分硬幣圖片時執行此事件，將25分累加到總金額
        private void twentyFiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            total += TWENTY_FIVE_CENTS;
            totalLabel.Text = total.ToString();
        }

        // 當使用者點擊50分硬幣圖片時執行此事件，將50分累加到總金額
        private void fiftyCentsPictureBox_Click(object sender, EventArgs e)
        {
            total += FIFTY_CENTS;
            totalLabel.Text = total.ToString();
        }

        // 當使用者點擊離開按鈕時執行此事件，關閉視窗
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
