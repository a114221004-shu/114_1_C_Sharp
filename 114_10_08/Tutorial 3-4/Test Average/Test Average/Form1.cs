using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 建構函式，初始化表單元件
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 「計算平均」按鈕的事件處理函式
        /// 取得三個測驗分數，計算平均值並顯示於標籤
        /// 若輸入非數字或發生例外，則顯示錯誤訊息
        /// </summary>
        /// <param name="sender">事件來源物件</param>
        /// <param name="e">事件參數</param>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 宣告三個 double 變數來存放分數
            double test1, test2, test3;

            // 使用 try-catch 來捕捉可能的例外
            try
            {
                // 取得三個分數並轉型為 double
                test1 = double.Parse(test1TextBox.Text);
                test2 = double.Parse(test2TextBox.Text);
                test3 = double.Parse(test3TextBox.Text);

                // 計算平均分數
                double average = (test1 + test2 + test3) / 3.0;

                // 顯示平均分數（小數點後兩位）
                averageLabel.Text = average.ToString("n2");
            }

            // 捕捉所有例外
            catch (Exception ex)
            {
                // 若輸入格式錯誤或其他例外，顯示錯誤訊息
                MessageBox.Show( ex.Message, "例外發生!");
                // 清空三個分數文字框及平均分數標籤
                test1TextBox.Text = "";
                test2TextBox.Text = "";
                test3TextBox.Text = "";
                averageLabel.Text = "";

                // 將游標移回第一個分數文字框
                test1TextBox.Focus();
            }
        }

        /// <summary>
        /// 「清除」按鈕的事件處理函式
        /// 清空所有分數輸入框及平均分數標籤，並將游標移至第一個輸入框
        /// </summary>
        /// <param name="sender">事件來源物件</param>
        /// <param name="e">事件參數</param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清空三個分數文字框及平均分數標籤
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";

            // 將游標移回第一個分數文字框
            test1TextBox.Focus();
        }

        /// <summary>
        /// 「離開」按鈕的事件處理函式
        /// 關閉整個表單
        /// </summary>
        /// <param name="sender">事件來源物件</param>
        /// <param name="e">事件參數</param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
