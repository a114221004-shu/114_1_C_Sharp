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
using System.Globalization;

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

    

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                inputFile = File.OpenText(openFile.FileName);
                salesListBox.Items.Clear();

                while (!inputFile.EndOfStream)
                {

                    line = inputFile.ReadLine();
                    if (string.IsNullOrWhiteSpace(line))
                        continue; // 跳過空行

                    // 期待的格式為 "Mon 1000.0"，以空白分隔月份與數值
                    var parts = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length >= 2)
                    {
                        // 第二個欄位可能包含數字，使用 InvariantCulture 解析小數點
                        if (decimal.TryParse(parts[1], NumberStyles.Number, CultureInfo.InvariantCulture, out currentSales))
                        {
                            // 顯示原始行內容
                            salesListBox.Items.Add(line);
                            totalSales += currentSales;
                        }
                        else
                        {
                            MessageBox.Show("無法解析銷售額: " + line);
                           inputFile.Close();
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("資料格式不正確: " + line);
                        inputFile.Close();
                        break;
                    }
                }
                inputFile.Close();
                totalLabel.Text = totalSales.ToString("C");
            }
            else
            {
                MessageBox.Show("未選擇檔案");
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

        private void totalLabel_Click(object sender, EventArgs e)
        {

        }

        private void openFile_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
