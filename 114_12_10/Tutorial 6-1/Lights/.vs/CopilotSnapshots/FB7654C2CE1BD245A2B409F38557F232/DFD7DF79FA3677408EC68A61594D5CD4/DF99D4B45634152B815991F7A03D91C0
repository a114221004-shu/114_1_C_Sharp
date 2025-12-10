using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lights
{
    // 燈光切換應用程式的主表單類別
    public partial class Form1 : Form
    {
        // 建構函式：初始化表單元件
        public Form1()
        {
            InitializeComponent();
        }

        // 切換按鈕點擊事件處理程序
        // 功能：根據目前燈光狀態切換燈的開關
        private void switchButton_Click(object sender, EventArgs e)
        {
            // 檢查燈是否目前為開啟狀態
            if (lightOnPictureBox.Visible == true)
            {
                // 如果燈亮著，則關燈
                turnLightOff();
            }
            else
            {
                // 如果燈關著，則開燈
                turnLightOn();
            }
        }

        // 開燈方法：點亮燈光並更新 UI 顯示
        private void turnLightOn()
        {
            // 顯示亮燈的圖片
            lightOnPictureBox.Visible = true;
            // 隱藏熄燈的圖片
            lightOffPictureBox.Visible = false;
            // 更新狀態標籤為 "ON"
            lightStateLabel.Text = "ON";
        }

        // 關燈方法：熄滅燈光並更新 UI 顯示
        private void turnLightOff()
        {
            // 隱藏亮燈的圖片
            lightOnPictureBox.Visible = false;
            // 顯示熄燈的圖片
            lightOffPictureBox.Visible = true;
            // 更新狀態標籤為 "OFF"
            lightStateLabel.Text = "OFF";
        }

        // 結束按鈕點擊事件處理程序
        // 功能：關閉應用程式視窗
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單視窗
            this.Close();
        }
    }
}
