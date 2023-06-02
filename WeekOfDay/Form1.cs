using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeekOfDay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 13)
            {
                numericUpDown1.Value = 1;
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 4)
            {
                if (numericUpDown2.Value == 31)
                {
                    numericUpDown2.Value = 1;
                }

            }
            else if (numericUpDown1.Value == 6)
            {
                if (numericUpDown2.Value == 31)
                {
                    numericUpDown2.Value = 1;
                }

            }
            else if (numericUpDown1.Value == 9)
            {
                if (numericUpDown2.Value == 31)
                {
                    numericUpDown2.Value = 1;
                }
            }
            else if (numericUpDown1.Value == 11)
            {
                if (numericUpDown2.Value == 31)
                {
                    numericUpDown2.Value = 1;
                }
            }
            else if (numericUpDown1.Value == 2)
            {
                int X = int.Parse(textBox1.Text);
                if (X % 4 == 0 && X % 100 > 0)
                {
                    if (numericUpDown2.Value == 30)
                    {
                        numericUpDown2.Value = 1;
                    }
                }
                else if (X % 400 == 0)
                {
                    if (numericUpDown2.Value == 30)
                    {
                        numericUpDown2.Value = 1;
                    }
                }
                else
                {
                    if (numericUpDown2.Value == 29)
                    {
                        numericUpDown2.Value = 1;
                    }
                }
            }
            else
            {
                if (numericUpDown2.Value == 32)
                    numericUpDown2.Value = 1;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            int w, y, m, d;
            y = int.Parse(textBox1.Text);
            m = (int)numericUpDown1.Value;
            d = (int)numericUpDown2.Value;
            w = (5*y / 4-y / 100+y / 400+(26*m+16) / 10+d) % 7;
            if(w == 0)
            {
                label4.Text = "日曜日でし";
            }else if (w == 1)
            {
                label4.Text = "月曜日でし";
            }
            else if (w == 2)
            {
                label4.Text = "火曜日でし";
            }
            else if (w == 3)
            {
                label4.Text = "水曜日でし";
            }
            else if (w == 4)
            {
                label4.Text = "木曜日でし";
            }
            else if (w == 5)
            {
                label4.Text = "金曜日でし";
            }
            else if (w == 6)
            {
                label4.Text = "土曜日でし";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = 1;
            numericUpDown2.Value = 1;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int Hanbetu;
            String S = textBox1.Text;
            if (int.TryParse(S, out Hanbetu) == false)
            {
                label4.Text = "西暦年エラー";
            }
            else
            {
                label4.Text = " ";
            }
        }
    }
}
