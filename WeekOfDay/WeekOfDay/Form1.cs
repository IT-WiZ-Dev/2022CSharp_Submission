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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = "";
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int year) || year < 0)
            {
                label4.Text = "西暦年エラー";
                return;
            }

            int month = (int)numericUpDown1.Value;
            int day = (int)numericUpDown2.Value;

            if (!IsValidDate(year, month, day))
            {
                label4.Text = "あり得ない日付";
                return;
            }

            string weekday = CalculateWeekday(year, month, day);
            label4.Text = $"{weekday}";
        }
        //閏年かどうか判定するメソッド
        private bool IsLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        return true;
                    }
                    return false;
                }
                return true;
            }
            return false;
        }
        //年月日の妥当性チェックを行うメソッド
        private bool IsValidDate(int year, int month, int day)
        {
            if (month < 1 || month > 12 || day < 1 || day > DateTime.DaysInMonth(year, month))
            {
                return false;
            }

            if (month == 2 && day == 29 && !IsLeapYear(year))
            {
                return false;
            }

            return true;
        }
        //西暦年、月、日から曜日を求めるメソッド
        private string CalculateWeekday(int year, int month, int day)
        {
            // ツェラーの公式を使用して曜日を計算
            int q = day;
            int m = month;
            int K = year % 100;
            int J = year / 100;

            if (m <= 2)
            {
                m += 12;
                K--;
            }

            int h = (q + (13 * (m + 1) / 5) + K + (K / 4) + (J / 4) - (2 * J)) % 7;

            string[] weekdays = { "土曜", "日曜", "月曜", "火曜", "水曜", "木曜", "金曜" };
            return weekdays[(h + 7) % 7];
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
