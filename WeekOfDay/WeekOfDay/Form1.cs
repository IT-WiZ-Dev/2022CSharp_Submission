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

        private void button1_Click(object sender, EventArgs e)
        {
            int year;
            if (int.TryParse(textBoxYear.Text, out year) == false)
            {
                year = -1;
            }
            int month = (int)numericUpDownMonth.Value;
            int day = (int)numericUpDownDay.Value;
            if (year < 0)
            {
                labelans.Text = "西暦年エラー";
            }
            else if (DateCheck(year,month, day) == false)
            {
                labelans.Text = "あり得ない日付";
            }
            else
            {
                labelans.Text = WeekAns(year, month, day);
            }
        }
        private Boolean UruYear(int n)
        {
            if (n % 4 == 0 && n % 100 != 0)
            {
                return true;
            }
            else if (n % 400 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private Boolean DateCheck(int y,int m, int d)
        {
            int datou;
            if (m == 4 || m == 6 || m == 9 || m == 11)
            {
                datou = 30 + 1;
            }
            else if (m == 2)
            {
                if (UruYear(y))
                {
                    datou = 29 + 1;
                }
                else
                {
                    datou = 28 + 1;
                }
            }
            else
            {
                datou = 31 + 1;
            }
            return d < datou;
        }
        private string WeekAns(int y, int m, int d)
        {
            if (m < 3)
            {
                m += 12;
                y--;
            }
            int ans = (((5 * y) / 4) - (y / 100) + (y / 400) + (((26 * m) + 16) / 10 + d)) % 7;
            switch (ans)
            {
                case 0:
                    return "日曜日";
                case 1:
                    return "月曜日";
                case 2:
                    return "火曜日";
                case 3:
                    return "水曜日";
                case 4:
                    return "木曜日";
                case 5:
                    return "金曜日";
                case 6:
                    return "土曜日";
                default:
                    return "不正発生";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            labelans.Text = "";
        }
    }
}
