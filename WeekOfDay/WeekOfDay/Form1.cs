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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year = int.Parse(textBox1.Text);
            bool isUruu = false;
            if (year % 4 == 0 && year % 100 != 0)
            {
                isUruu = true;
            }
            if (year % 400 == 0)
            {
                isUruu = true;
            }

            int month = (int)numericUpDown1.Value;
            int day = (int)numericUpDown2.Value;

            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                if (day < 1 || day > 31)
                {
                    result.Text = "あり得ない日付";
                    return;

                }
                else if (month == 4 || month == 6 || month == 9 || month == 11)
                {
                    if (day < 1 || day > 30)
                    {
                        result.Text = "あり得ない日付";
                        return;
                    }
                }
                else if (month == 2)
                {
                    if (isUruu == true)
                    {
                        if (day < 1 || day > 29)
                        {
                            result.Text = "あり得ない日付";
                            return;
                        }
                    }
                    if (isUruu == false)
                    {
                        if (day < 1 || day > 28)
                        {
                            result.Text = "あり得ない日付";
                            return;
                        }
                    }
                }
            }
        }

    }
}
