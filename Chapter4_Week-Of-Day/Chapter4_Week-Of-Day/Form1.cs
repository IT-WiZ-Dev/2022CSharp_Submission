using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter4_Week_Of_Day
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label6.Text = "";
        }

        private int Day_of_week(int year, int month, int day)
        {
            if (month == 1)
            {
                year -= 1;
                month += 12;
            }

            if (month == 2)
            {
                year -= 1;
                month += 12;
            }

            return (5 * year / 4 - year / 100 + year / 400 + (26 * month + 16) / 10 + day) % 7;
        }

        private bool Judge_urudoshi(int year)
        {
            bool urudoshi = false;

            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
            {
                urudoshi = true;
            }

            return urudoshi;
        }

        private bool Check_month_day(int year, int month, int day)
        {
            bool urudoshi = true;

            if (month < 1 || month > 12 || day < 1)
            {
                urudoshi = false;
            }

            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                if (day > 31)
                {
                    urudoshi = false;
                }
            }

            if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                if (day > 30)
                {
                    urudoshi = false;
                }
            }

            if (Judge_urudoshi(year) == true)
            {
                if (day > 29)
                {
                    urudoshi = false;
                }
            }
            else
            {
                if (day > 28)
                {
                    urudoshi = false;
                }
            }

            return urudoshi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int year) != true || year < 0)
            {
                label6.Text = "西暦年エラー";
                return;
            }

            int month = (int)numericUpDown1.Value;
            int day = (int)numericUpDown2.Value;

            if (Check_month_day(year,month,day)== false)
            {
                label6.Text = "ありえない日付";
                return;
            }

            int week = Day_of_week(year, month, day);

            switch (week)
            {
                case 0:
                    label6.Text = "日曜日です";
                    break;
                case 1:
                    label6.Text = "月曜日です";
                    break;
                case 2:
                    label6.Text = "火曜日です";
                    break;
                case 3:
                    label6.Text = "水曜日です";
                    break;
                case 4:
                    label6.Text = "木曜日です";
                    break;
                case 5:
                    label6.Text = "金曜日です";
                    break;
                case 6:
                    label6.Text = "土曜日です";
                    break;
                default:
                    label6.Text = "算出エラーです";
                    break;
            }
            
        }

    }
}
