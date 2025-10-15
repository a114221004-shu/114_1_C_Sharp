using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_with_Overtime
{
    public partial class Form1 : Form
    {
        // 建構函式：初始化表單元件
        public Form1()
        {
            InitializeComponent(); // 初始化所有元件
        }

        // 當使用者按下「計算總薪資」按鈕時執行
        private void calculateButton_Click(object sender, EventArgs e)

        {
            const decimal BASE_HOURS = 40m; // 宣告常數以儲存基本工時
            const decimal OT_MULTIPLIER = 1.5m; // 宣告常數以儲存加班費倍率


            decimal hoursWorked; // 宣告變數以儲存工作時數
            decimal hourlyPayRate; // 宣告變數以儲存時薪
            decimal grossPay; // 宣告變數以儲存總薪資
            try
            {
                hoursWorked = decimal.Parse(hoursWorkedTextBox.Text); // 從輸入框讀取並轉換工作時數
                hourlyPayRate = decimal.Parse(hourlyPayRateTextBox.Text); // 從輸入框讀取並轉換時薪

                if(hoursWorked <= BASE_HOURS)
                {                     grossPay = hoursWorked * hourlyPayRate; // 計算總薪資（無加班）
                }
                else
                {
                    grossPay = (BASE_HOURS * hourlyPayRate) + 
                        ((hoursWorked - BASE_HOURS) * hourlyPayRate * OT_MULTIPLIER); // 計算總薪資（含加班）
                }
                grossPayLabel.Text = grossPay.ToString("c"); // 將總薪資格式化為貨幣並顯示在標籤上
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // 顯示錯誤訊息
            }
        }

        // 當使用者按下「清除」按鈕時執行
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清空工作時數、時薪輸入框與總薪資顯示欄位
            hoursWorkedTextBox.Text = "";
            hourlyPayRateTextBox.Text = "";
            grossPayLabel.Text = "";

            // 將游標焦點移回工作時數輸入框，方便使用者再次輸入
            hoursWorkedTextBox.Focus();
        }

        // 當使用者按下「離開」按鈕時執行
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單，結束程式
            this.Close();
        }

        private void grossPayLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
