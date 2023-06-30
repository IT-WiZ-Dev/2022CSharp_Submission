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
    public partial class FormSwimmming : Form
    {
        //フィールド
        Corse baby_course;
        Corse infant_course;
        Corse elementary_course;
        Corse middle_course;
        Corse women_course;
        Corse general_course;
        Corse family_course;

        public FormSwimmming()
        {
            InitializeComponent();
        }

        private void FormSwimmming_Load(object sender, EventArgs e)
        {
            baby_course = new Corse("ベビーコース", 1, 14, 1000);
            infant_course = new Corse("幼児コース", 2, 10, 1000);
            elementary_course = new Corse("小学生コース", 3, 17, 800);
            middle_course = new Corse("中学生コース", 4, 19, 800);
            women_course = new Corse("レディースコース", 5, 20, 1000);
            general_course = new Corse("一般コース", 6, 20, 1200);
            family_course = new Corse("家族コース", 0, 10, 1500);

            DateTime dt = DateTime.Now;
            numericUpDownYear.Value = dt.Year;
            numericUpDownMonth.Value = dt.Month;
            labelLessonDay.Text = "";
            labelStartTime.Text = "";
            labelLessonPrice.Text = "";
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            int year = Decimal.ToInt32(numericUpDownYear.Value);
            int month = Decimal.ToInt32(numericUpDownMonth.Value);
            int day = 1;
            int last_day = DateTime.DaysInMonth(year, month);
            DateTime dt = new DateTime(year, month, day);
            int week = (int)dt.DayOfWeek;
            int index = listBoxCourse.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("コースを選択してください。", "確認");
                return;
            }

            //授業日
            int lesson_week = WeekCheck(index);
            int count = 0;
            while (lesson_week != week)
            {
                day++;
                dt = new DateTime(year, month, day);
                week = (int)dt.DayOfWeek;
            }
            string lesson_day = null;

            do
            {
                lesson_day += day + "日　";
                day += 7;
                count++;
            } while (day <= last_day-3);

            //開始時間
            int start_time = TimeCheck(index);

            //授業料
            int lesson_price = PriceCheck(index) * count;

            //表示
            labelLessonDay.Text = lesson_day;
            labelStartTime.Text = start_time.ToString() + "時";
            labelLessonPrice.Text = lesson_price.ToString() + "円";


        }

        public int WeekCheck(int idx)
        {
            int result = -1;
            if (idx == 0)
                result = baby_course.Lesson_week;
            else if (idx == 1)
                result = infant_course.Lesson_week;
            else if (idx == 2)
                result = elementary_course.Lesson_week;
            else if (idx == 3)
                result = middle_course.Lesson_week;
            else if (idx == 4)
                result = women_course.Lesson_week;
            else if (idx == 5)
                result = general_course.Lesson_week;
            else if (idx == 6)
                result = family_course.Lesson_week;

            return result;
        }

        public int TimeCheck(int idx)
        {
            int result = -1;
            if (idx == 0)
                result = baby_course.Start_time;
            else if (idx == 1)
                result = infant_course.Start_time;
            else if (idx == 2)
                result = elementary_course.Start_time;
            else if (idx == 3)
                result = middle_course.Start_time;
            else if (idx == 4)
                result = women_course.Start_time;
            else if (idx == 5)
                result = general_course.Start_time;
            else if (idx == 6)
                result = family_course.Start_time;

            return result;
        }

        public int PriceCheck(int idx)
        {
            int result = -1;
            if (idx == 0)
                result = baby_course.Lesson_price;
            else if (idx == 1)
                result = infant_course.Lesson_price;
            else if (idx == 2)
                result = elementary_course.Lesson_price;
            else if (idx == 3)
                result = middle_course.Lesson_price;
            else if (idx == 4)
                result = women_course.Lesson_price;
            else if (idx == 5)
                result = general_course.Lesson_price;
            else if (idx == 6)
                result = family_course.Lesson_price;

            return result;
        }
    }
}
