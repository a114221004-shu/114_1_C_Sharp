using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuorial_2_5
{
    // Form1 是主視窗表單類別
    public partial class Form1 : Form
    {
        // 建構子：初始化表單元件
        public Form1()
        {
            InitializeComponent(); // 初始化元件（由 Designer 產生）
        }

        // 點擊卡片背面圖片的事件處理函式
        private void cardnackPictureBox_Click(object sender, EventArgs e)
        {
            // 目前尚未實作任何功能
        }

        // 點擊卡片正面圖片的事件處理函式
        private void cardfacePictureBox_Click(object sender, EventArgs e)
        {
            // 目前尚未實作任何功能
        }

        // 按下顯示正面按鈕的事件處理函式
        private void showfaceButton_Click(object sender, EventArgs e)
        {
            cardfacePictureBox.Visible = true; // 顯示卡片正面圖片
            cardbackPictureBox.Visible = false; // 隱藏卡片背面圖片
        }

        // 表單載入時的事件處理函式
        private void Form1_Load(object sender, EventArgs e)
        {
            cardfacePictureBox.Visible = false; // 隱藏卡片正面圖片
            cardbackPictureBox.Visible = false; // 隱藏卡片背面圖片
        }

        // 按下顯示背面按鈕的事件處理函式
        private void showbackButton_Click(object sender, EventArgs e)
        {
            cardbackPictureBox.Visible = true; // 顯示卡片背面圖片
        }
    }
}
