using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleConditionsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
                {
                int score = int.Parse(textBox1.Text);
                string grade;
                //if (score >= 90)
                //{
                //    grade = "A";
                //}
                //else if (score >= 80)
                //{
                //    grade = "B";
                //}
                //else if (score >= 70)
                //{
                //    grade = "C";
                //}
                //else if (score >= 60)
                //{
                //    grade = "D";
                //}
                //else
                //{
                //    grade = "F";
                //}
                if (score >= 60)
                { 
                    if (score >= 70)
                    {
                        if (score >= 80)
                        {
                            if (score >= 90)
                            {
                                grade = "A";
                            }
                            else
                            {
                                grade = "B";
                            }

                        }
                        else
                        {
                            grade = "C";
                        }
                    }
                    else
                    {
                        grade = "D";
                    }
                }
                else
                {
                    grade = "F";
                }

                label2.Text = grade;
            }
            catch (FormatException)
            {
                MessageBox.Show("請輸入有效的數字成績。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
