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

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year;
            if (int.TryParse(textBox1.Text, out year) != true || year < 0)
            {
                label4.Text = "西暦年エラー";
                return;
            }
            int month = (int)numericUpDown1.Value;
            int day = (int)numericUpDown2.Value;
            if (monthday(year, month, day) == false)
            {
                label4.Text = "あり得ない日付";
                return;
            }
            int w = week(year, month, day);

            if (w == 0)
            {
                label4.Text = "日曜日です";
            }
            else if (w == 1)
            {
                label4.Text = "月曜日です";
            }
            else if (w == 2)
            {
                label4.Text = "火曜日です";
            }
            else if (w == 3)
            {
                label4.Text = "水曜日です";
            }
            else if (w == 4)
            {
                label4.Text = "木曜日です";
            }
            else if (w == 5)
            {
                label4.Text = "金曜日です";
            }
            else if (w == 6)
            {
                label4.Text = "土曜日です";
            }
        }
        private int week(int y, int m, int d)
        {
            if (m == 1 || m == 2)
            {
                y = y - 1;
                m = m + 12;
            }
            return (5 * y / 4 - y / 100 + y / 400 + (26 * m + 16) / 10 + d) % 7;
        }
        private bool uruu(int y)
        {
            bool ur = false;
            if (y % 4 == 0 && (y % 100 != 0 || y % 400 == 0))
            {
                ur = true;
            }
            return ur;
        }
        private bool monthday(int y,int m,int d)
        {
            bool ur = true;
            if (m < 1 || m > 12 || d < 1)
            {
                ur = false;
            }
            else if (m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12)
            {
                if (d > 31)
                {
                    ur = false;
                }
            }
            else if (m == 4 || m == 6 || m == 9 || m == 11)
            {
                if (d > 30)
                {
                    ur = false;
                }
            }
            else
            {
                if (uruu(y) == true)
                {
                    if (d > 29)
                    {
                        ur = false;
                    }
                }
                else
                {
                    if (d > 28)
                    {
                        ur = false;
                    }
                }
            }
            return ur;
        }
    }
}
