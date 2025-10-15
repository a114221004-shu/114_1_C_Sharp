using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_Qualifier
{
    public partial class Form1 : Form
    {
        // 建構子：初始化表單元件
        public Form1()
        {
            InitializeComponent(); // 初始化所有視窗元件
        }

        // 當使用者按下「審核資格」按鈕時觸發
        private void checkButton_Click(object sender, EventArgs e)
        {
            const decimal MINIMUM_SALARY = 120000m; // 最低年薪要求
            const int MINIMUM_YEARS = 2; // 最低年資要求

            decimal salary; // 使用者輸入的年薪
            int yearsOnTob; // 使用者輸入的年資

            try
            {
                salary = decimal.Parse(salaryTextBox.Text); // 將輸入年薪轉換為decimal
                yearsOnTob = int.Parse(yearsTextBox.Text); // 將輸入年資轉換為int

                if (salary >= MINIMUM_SALARY)
                {
                    if (yearsOnTob >= MINIMUM_YEARS)
                    {
                        decisionLabel.Text = "符合資格"; // 顯示符合資格
                    }
                    else
                    {
                        decisionLabel.Text = "不符合資格：年資未達最低標準"; // 顯示不符合資格
                    }
                }
                else
                {
                    decisionLabel.Text = "不符合資格：收入未達最低標準"; // 顯示不符合資格
                }
            }
            catch(Exception ex)
            {
              MessageBox.Show(ex.Message); // 顯示錯誤訊息`
            }
        }

        // 當使用者按下「清除」按鈕時觸發
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清空年薪與年資輸入框，以及審核結果標籤
            salaryTextBox.Text = "";
            yearsTextBox.Text = "";
            decisionLabel.Text = "";

            // 將游標焦點移回年薪輸入框，方便使用者重新輸入
            salaryTextBox.Focus();
        }

        // 當使用者按下「離開」按鈕時觸發
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉視窗
            this.Close();
        }

        // 當使用者點擊審核結果標籤時觸發（目前未使用）
        private void decisionLabel_Click(object sender, EventArgs e)
        {
            // 此方法目前未實作任何功能
        }
    }
}
