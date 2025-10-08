using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sale_Price_Calculator
{
    // 主表單類別，負責顯示特價計算機的介面
    public partial class Form1 : Form
    {
        // 建構函式，初始化表單元件
        public Form1()
        {
            InitializeComponent();
        }

        // 當使用者按下「計算特價」按鈕時觸發的事件處理函式
        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal originalPrice;
            decimal discountPercentage;
            decimal salePrice;

            //嘗試將文字框中的文字轉換為 decimal 型別
            originalPrice = decimal.Parse(originalPriceTextBox.Text);
            discountPercentage = decimal.Parse(discountPercentageTextBox.Text);

            // 計算特價 , .0m 強制轉型為 decimal , 若不加會當作 double 計算 , 與前面兩個變數型別不符
            salePrice = originalPrice * (1 - discountPercentage / 100.0m);

            // 顯示特價，格式化為貨幣格式
            salePriceLabel.Text = salePrice.ToString("C");


            // 此處可加入計算特價的邏輯
            // 例如：
            // 1. 取得原價與折扣百分比的輸入值
            // 2. 檢查輸入是否有效（數值且非空白）
            // 3. 計算特價：特價 = 原價 * (1 - 折扣百分比 / 100)
            // 4. 顯示計算結果於 salePriceLabel
        }

        // 當使用者按下「離開」按鈕時觸發的事件處理函式
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }

        private void discountPercentageTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
