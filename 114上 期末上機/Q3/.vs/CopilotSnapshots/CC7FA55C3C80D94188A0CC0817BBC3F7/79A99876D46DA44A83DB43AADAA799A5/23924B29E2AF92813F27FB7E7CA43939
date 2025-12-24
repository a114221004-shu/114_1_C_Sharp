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

namespace Q3
{
    public partial class Form1 : Form
    {
        // Random instance for generating numbers
        private readonly Random rng = new Random();
        // flag to indicate whether a file has been successfully loaded
        private bool fileLoaded = false;

        public Form1()
        {
            InitializeComponent();
            // 初始狀態若未開檔，不能按「產生號碼」
            numberButton.Enabled = false;
        }

        private void opennumberButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "選擇檔案";
                ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    listBox1.Items.Clear();
                    try
                    {
                        string content;

                        // First attempt: UTF8 with BOM detection
                        using (var stream = ofd.OpenFile())
                        using (var sr = new StreamReader(stream, Encoding.UTF8, detectEncodingFromByteOrderMarks: true))
                        {
                            content = sr.ReadToEnd();
                        }

                        // If replacement character found, try Big5 (codepage 950), then fallback to system default
                        if (content.IndexOf('\uFFFD') >= 0)
                        {
                            bool success = false;
                            try
                            {
                                using (var stream = ofd.OpenFile())
                                using (var sr = new StreamReader(stream, Encoding.GetEncoding(950)))
                                {
                                    content = sr.ReadToEnd();
                                    success = true;
                                }
                            }
                            catch
                            {
                                // ignore and try default encoding
                            }

                            if (!success)
                            {
                                using (var stream = ofd.OpenFile())
                                using (var sr = new StreamReader(stream, Encoding.Default))
                                {
                                    content = sr.ReadToEnd();
                                }
                            }
                        }

                        // Split lines and add to listBox
                        using (var reader = new StringReader(content))
                        {
                            string line;
                            while ((line = reader.ReadLine()) != null)
                            {
                                listBox1.Items.Add(line);
                            }
                        }

                        // 成功讀檔後啟用產生號碼按鈕
                        fileLoaded = true;
                        numberButton.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        fileLoaded = false;
                        numberButton.Enabled = false;
                        MessageBox.Show("讀檔時發生錯誤: " + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void numberButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!fileLoaded)
                {
                    throw new InvalidOperationException("尚未開啟檔案，請先開啟檔案後再產生號碼。");
                }

                var numbers = new HashSet<int>();
                while (numbers.Count < 5)
                {
                    numbers.Add(rng.Next(1, 49));
                }

                var list = numbers.ToList();

                // 將數字顯示在 label 上
                number1Label.Text = list[0].ToString();
                number2Label.Text = list[1].ToString();
                number3Label.Text = list[2].ToString();
                number4Label.Text = list[3].ToString();
                number5Label.Text = list[4].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("無法產生號碼: " + ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
