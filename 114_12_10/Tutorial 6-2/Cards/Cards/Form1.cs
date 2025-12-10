using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cards
{
    /// <summary>
    /// 卡片顯示應用程式的主視窗
    /// 允許使用者從列表中選擇卡片並顯示對應的卡片圖像
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// 初始化 Form1 的新執行個體
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 顯示卡片按鈕的點擊事件處理程式
        /// 根據列表框中的選擇顯示相應的卡片圖像
        /// </summary>
        private void showCardButton_Click(object sender, EventArgs e)
        {
            if (cardListBox.SelectedIndex != -1)
            {
                showSelectedCard(cardListBox.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("請先選擇一張卡片！");
            }
        }

        private void showSelectedCard(string cardName)
        {
            // 隱藏所有卡片圖像
            aceSpadesPictureBox.Visible = false;
            tenHeartsPictureBox.Visible = false;
            kingClubsPictureBox.Visible = false;
            // 根據選擇的索引顯示相應的卡片圖像
            switch (cardName)
            {
                case"黑桃A":
                    ShowAceSpades();
                    break;
                case "紅心10":
                    ShowTenHearts();
                    break;
                case "梅花K":
                    ShowKingClubs();
                    break;
            }
        }

        private void ShowAceSpades()
        {
            aceSpadesPictureBox.Visible = true;
        }

        private void ShowTenHearts()
        {
            tenHeartsPictureBox.Visible = true;
        }

        private void ShowKingClubs()
        {
            kingClubsPictureBox.Visible = true;
        }

        /// <summary>
        /// 離開按鈕的點擊事件處理程式
        /// 關閉應用程式視窗
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉視窗
            this.Close();
        }
    }
}
