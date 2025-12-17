using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pay_and_Bonus
{
    public partial class Form1 : Form
    {
        // 提撥比率的常數欄位
        private const decimal CONTRIB_RATE = 0.05m;

        public Form1()
        {
            InitializeComponent();
        }

        // InputIsValid 方法會嘗試將使用者輸入轉換成數值，
        // 並將結果儲存在 out 參數中。若兩個欄位都成功轉換，
        // 則回傳 true；否則回傳 false。
        // 這個檢查可避免後續計算因非數字輸入而發生例外。
        private bool InputIsValid(ref decimal grossPay, ref decimal bonus)
        {
            bool inputIsValid = false;
            if (decimal.TryParse(grossPayTextBox.Text, out grossPay) )
            {
                if (decimal.TryParse(bonusTextBox.Text, out bonus))
                {
                    inputIsValid = true;
                }
                else
                {
                    MessageBox.Show("Invalid input for bonus.");
                }
                   
            }
            else
            {
              MessageBox.Show("總薪資金額輸入無效");
                bonus = 0;
            }
            return inputIsValid;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
           decimal grossPay = 0.0m;
              decimal bonus = 0.0m;
              decimal contribution = 0.0m;

            if (InputIsValid( ref grossPay, ref bonus))
            {
                // 計算提撥金額（總薪資 + 獎金） * 提撥比率
                contribution = (grossPay + bonus) * CONTRIB_RATE;
                // 顯示計算結果（使用貨幣格式）
                contributionLabel.Text = contribution.ToString("C");
            }
            else
            {
                // 顯示錯誤訊息，提示使用者輸入有效的數字
                MessageBox.Show("Please enter valid numeric values for gross pay and bonus.");
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
