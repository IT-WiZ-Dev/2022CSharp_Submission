using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwimminSchedule
{
    public partial class Form1 : Form
    {
        List<Course> data;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //現在の年月を表示
            DateTime date = DateTime.Now.Date;
            numericUpDownYear.Value = date.Year;
            numericUpDownMonth.Value = date.Month;

            //データ入力
            data = new List<Course>();
            data.Add(new Course("ベビーコース",      1, 14, 1000));
            data.Add(new Course("幼児コース",        2, 10, 1000));
            data.Add(new Course("小学生コース",      3, 17,  800));
            data.Add(new Course("中学生コース",      4, 19,  800));
            data.Add(new Course("レディースコース",  5, 20, 1000));
            data.Add(new Course("一般コース",        6, 20, 1200));
            data.Add(new Course("家族コース",        0, 10, 1500));
            
            foreach(Course obj in data)
            {
                listBoxCourse.Items.Add(obj.CouseName);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBoxCourse.SelectedIndex;

            //月の最終日
            int Year = (int)numericUpDownYear.Value;
            int Month = (int)numericUpDownMonth.Value;
            int daysInMonth = DateTime.DaysInMonth(Year, Month);

            //月の最終日の曜日
            DateTime dt = new DateTime(Year, Month, daysInMonth);
            int week = (int)dt.DayOfWeek;

            int count = 0;
            int Day;
            int[] days = new int[0];
            string d = "";
            
            //表示処理
            //開始時間
            labelTime.Text = Convert.ToString(data[index].Time) + "時";
            //その月の欲しい曜日
            while (true)
            {
                if(week == data[index].DayOfWeek)
                {
                    break;
                }
                week = week - 1;
                if (week == -1)
                {
                    week = 6;
                }
                count = count + 1;
            }
            
            //欲しい日付を配列に入れる
            Day = daysInMonth - count;
            for (int i = Day; i > 0;  i = i - 7)
            {
                if (i < daysInMonth - 3)
                {
                    Array.Resize(ref days, days.Length + 1);
                    days[days.Length - 1] = i;
                }
            }

            Array.Reverse(days);

            //日付をテキストに表示
            for (int i = 0; i < days.Length; i++) 
            {
                d = d + days[i] + "日";
            }

            labelDay.Text = Convert.ToString(d);

            //合計金額を配列の要素数とかけて算出
            labelPrice.Text = Convert.ToString(data[index].Price * days.Length) + "円  ";

        }

    }
}
