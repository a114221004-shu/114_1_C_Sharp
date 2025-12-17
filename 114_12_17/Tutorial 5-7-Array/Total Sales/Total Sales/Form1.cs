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
            string line;

            decimal[] sales = new decimal[8]; // 假設有 8 筆銷售資料
            int index = 0;

            try
            {
                inputFile = File.OpenText("Sales.txt");
                salesListBox.Items.Clear();

                // 在讀取前清空 ListBox 以避免重複顯示
                this.salesListBox.Items.Clear();
                while (!inputFile.EndOfStream)
                {
                    if (decimal.TryParse(line = inputFile.ReadLine(), out currentSales))
                    {
                        salesListBox.Items.Add(line);
                        sales[index++] = currentSales;
                        index++;
                    }
                    else
                    {
                        MessageBox.Show("無法解析銷售額: " + line);
                        break;
                    }
                }
                inputFile.Close();

                // 計算總銷售額
                for (int i = 0; i < index; i++)
                {
                    totalSales += sales[i];
                }

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
