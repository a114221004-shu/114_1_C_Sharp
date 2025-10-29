using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cookie_Calories
{
    public partial class Form1 : Form
    {
        // 建構子，初始化表單元件
        public Form1()
        {
            InitializeComponent();
        }

        // 離開按鈕事件，關閉視窗
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 餅乾數量文字框內容改變事件（目前未使用）
        private void cookieTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        // 計算按鈕事件，計算總熱量
        private void cipherButton_Click(object sender, EventArgs e)
        {
            double cookies;
            try
            {
                // 取得餅乾數量並轉為 double 型別
                cookies = double.Parse(cookieTextBox.Text);

                // 每片餅乾 75 卡路里，計算總熱量
                double average = cookies * 75;

                // 顯示結果，保留一位小數
                showLabel.Text = average.ToString("n1");

            }
            catch (Exception ex)
            {
                // 當輸入格式錯誤時，顯示錯誤訊息並清空欄位
                MessageBox.Show(ex.Message, "請輸入正確餅乾數量");
                cookieTextBox.Text = "";
                showLabel.Text = "";

                // 讓使用者可以重新輸入
                cookieTextBox.Focus();

            }
        }

        // 清除按鈕事件，清空輸入與結果
        private void clearButton_Click(object sender, EventArgs e)
        {
            cookieTextBox.Text = "";
            showLabel.Text = "";

            cookieTextBox.Focus();
        }
    }
}
