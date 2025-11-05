using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String message = "";

            if (checkBox1.Checked)
            {
                message =message + "夏威夷";
            }
            if (checkBox2.Checked)
            {
                message = message +  "章魚燒";
            }
            // 移除錯誤的分號，讓 if 條件正確套用區塊
            if (checkBox3.Checked)
            {
                message = message + "綜合海鮮";
            }
            if (checkBox4.Checked)
            {
                message = message + "義式火腿";
            }
            
            if (message == "")
            {
                message = "您未選擇任何口味";
            }

            MessageBox.Show(message,"您選擇的披薩口味是：");
        }
    }
}
