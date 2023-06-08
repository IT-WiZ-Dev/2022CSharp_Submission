using System;
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
            int y = Convert.ToInt32(textBox3.Text);
            int m = (int)numericUpDown1.Value;
            int d = (int)numericUpDown2.Value;

            if (IsValidDate(y, m, d))
            {
                int w = CalculateDayOfWeek(y, m, d);
                string dayOfWeek = GetDayOfWeekString(w);
                label4.Text = "曜日: " + dayOfWeek;
            }
            else
            {
                MessageBox.Show("無効な日付です。");
            }
        }

        private bool IsValidDate(int year, int month, int day)
        {
            try
            {
                DateTime date = new DateTime(year, month, day);
                return true;
            }
            catch (ArgumentOutOfRangeException)
            {
                return false;
            }
        }

        private int CalculateDayOfWeek(int year, int month, int day)
        {
            if (month < 3)
            {
                month += 12;
                year--;
            }

            int h = (day + 2 * month + 3 * (month + 1) / 5 + year + year / 4 - year / 100 + year / 400) % 7;
            int w = (h + 6) % 7; // 0: 日曜日, 1: 月曜日, ..., 6: 土曜日
            return w;
        }

        private string GetDayOfWeekString(int dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case 0:
                    return "火曜日";
                case 1:
                    return "水曜日";
                case 2:
                    return "木曜日";
                case 3:
                    return "金曜日";
                case 4:
                    return "土曜日";
                case 5:
                    return "日曜日";
                case 6:
                    return "月曜日";
                default:
                    return string.Empty;
            }
        }
    }
}



