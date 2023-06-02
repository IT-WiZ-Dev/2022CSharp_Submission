using System;
using System.Windows.Forms;

namespace WeekdayCalculator
{
    public partial class Form1 : Form
    {
        private TextBox txtYear;
        private NumericUpDown numMonth;
        private NumericUpDown numDay;
        private Button btnCalculate;
        private Label lblResult;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int year, month, day;
            if (!int.TryParse(txtYear.Text, out year) || year < 0)
            {
                lblResult.Text = "西暦年エラー";
                return;
            }

            month = (int)numMonth.Value;
            day = (int)numDay.Value;

            if (!IsValidDate(year, month, day))
            {
                lblResult.Text = "あり得ない日付";
                return;
            }

            string weekday = GetWeekday(year, month, day);
            lblResult.Text = weekday;
        }

        private bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
        }

        private bool IsValidDate(int year, int month, int day)
        {
            if (month == 2)
            {
                if (IsLeapYear(year))
                    return day <= 29;
                else
                    return day <= 28;
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                return day <= 30;
            }
            else
            {
                return day <= 31;
            }
        }

        private string GetWeekday(int year, int month, int day)
        {
            int[] monthTable = { 0, 3, 3, 6, 1, 4, 6, 2, 5, 0, 3, 5 };
            int centuryCode = 6 - 2 * ((year / 100) % 4);
            int yearCode = (year % 100 + (year % 100) / 4) % 7;
            int monthCode = monthTable[month - 1];
            int leapYearCorrection = (IsLeapYear(year) && (month == 1 || month == 2)) ? -1 : 0;

            int weekdayCode = (centuryCode + yearCode + monthCode + day + leapYearCorrection) % 7;

            string[] weekdays = { "土曜日です", "日曜日です", "月曜日です", "火曜日です", "水曜日です", "木曜日です", "金曜日です" };

            return weekdays[weekdayCode];
        }
    }
}
