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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int year = int.Parse(textBox1.Text);
                int month = (int)numericUpDown1.Value;
                int day = (int)numericUpDown2.Value;
                if(monthDay(month, checkYear(year)) < day)
                {
                    label2.Text = "あり得ない日付";
                    return;
                }
                label2.Text = zeller(year, month, day).ToString()
                    .Replace("0", "日曜日です")
                    .Replace("1", "月曜日です")
                    .Replace("2", "火曜日です")
                    .Replace("3", "水曜日です")
                    .Replace("4", "木曜日です")
                    .Replace("5", "金曜日です")
                    .Replace("6", "土曜日です")
                    ;
            }
            catch (Exception)
            {
                label2.Text = "西暦年エラー";
            }

        }
        private bool checkYear(int year)
        {
            if (year % 400 == 0) return true;
            else if (year % 4 == 0 && year % 100 != 0) return true;
            else return false;
        }
        private int monthDay(int month, bool isLeap)
        {
            if(month == 2)
            {
                if (isLeap) return 29;
                else return 28;
            }
            if (month == 4 || month == 6 || month == 9 || month == 11) return 30;
            else return 31;
        }
        private int zeller(int year, int month, int day)
        {
            if(month < 3)
            {
                year--;
                month += 12;
            }
            return (5 * year / 4 - year / 100 + year / 400 + (26 * month + 16) / 10 + day) % 7;
        }
    }
}
