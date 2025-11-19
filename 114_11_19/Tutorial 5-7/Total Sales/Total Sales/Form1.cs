using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Total_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 計算按鈕點擊事件處理
            StreamReader inputFile;
            decimal totalSales = 0m;
            decimal currentSales = 0m;

            try
            {
                inputFile = File.OpenText("Sales.txt");
                salesListBox.Items.Clear();

                // 在讀取前清空 ListBox 以避免重複顯示
                this.salesListBox.Items.Clear();
                while (!inputFile.EndOfStream)
                {
                    string line = inputFile.ReadLine();
                    salesListBox.Items.Add(line); // 增加一行空白，確保每次迴圈都有新行
                    // 先讀取一行文字，將原始字串加入 ListBox 顯示
                    currentSales = decimal.Parse(line);
                    totalSales += currentSales;
                }
                inputFile.Close();
                totalLabel.Text = totalSales.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("發生錯誤: " + ex.Message);
                return;
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }

        private void outputDescriptionLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
