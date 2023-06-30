using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwimmingSchedule
{
    public partial class Form1 : Form
    {
        //コースのデータの配列
        List<course> data;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //空文字列を表示
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            //現在の年と月を表示
            numericUpDown1.Value = DateTime.Now.Year;
            numericUpDown2.Value = DateTime.Now.Month;

            data = new List<course>();
            data.Add(new course("ベビーコース", 1, 14, 1000));
            data.Add(new course("幼児コース", 2, 10, 1000));
            data.Add(new course("小学生コース", 3, 17, 800));
            data.Add(new course("中学生コース", 4, 19, 800));
            data.Add(new course("レディースコース", 5, 20, 1000));
            data.Add(new course("一般コース", 6, 20, 1200));
            data.Add(new course("家族コース", 0, 10, 1500));

            foreach (course obj in data)
            {
                listBox1.Items.Add(obj.CourseName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            string courseName = data[index].CourseName;
            int dayOfWeek = data[index].DayOfWeek;

            // 選択された年と月を取得
            int year = (int)numericUpDown1.Value;
            int month = (int)numericUpDown2.Value;

            // 選択された年と月の最初の日を取得
            DateTime startDate = new DateTime(year, month, 1);

            // 選択された曜日と一致する日付を取得（月の最後の3日間を除外）
            List<DateTime> matchingDates = GetMatchingDates(startDate, (DayOfWeek)dayOfWeek, 3);

            // 結果を表示
            label9.Text = string.Join(", ", matchingDates.Select(date => date.Day.ToString() + "日"));
            label10.Text = data[index].StartTime.ToString() + "時";
            int totalPrice = matchingDates.Count * data[index].Price;
            label11.Text = totalPrice.ToString() + "円";
        }

        private List<DateTime> GetMatchingDates(DateTime startDate, DayOfWeek targetDayOfWeek, int excludeLastDays)
        {
            List<DateTime> matchingDates = new List<DateTime>();

            // 最初の日から月末までの日付を調べて、曜日に一致する日をリストに追加
            int year = startDate.Year;
            int month = startDate.Month;
            int daysInMonth = DateTime.DaysInMonth(year, month);

            for (int day = 1; day <= daysInMonth - excludeLastDays; day++)
            {
                DateTime currentDate = new DateTime(year, month, day);
                if (currentDate.DayOfWeek == targetDayOfWeek)
                {
                    matchingDates.Add(currentDate);
                }
            }
            return matchingDates;
        }
    }
}
