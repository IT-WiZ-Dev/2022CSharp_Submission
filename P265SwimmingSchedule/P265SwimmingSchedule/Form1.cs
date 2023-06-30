using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P265SwimmingSchedule
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxCourse.Items.Add("ベビーコース");
            listBoxCourse.Items.Add("幼児コース");
            listBoxCourse.Items.Add("小学生コース");
            listBoxCourse.Items.Add("中学生コース");
            listBoxCourse.Items.Add("レディースコース");
            listBoxCourse.Items.Add("一般コース");
            listBoxCourse.Items.Add("家族コース");

            DateTime now = DateTime.Now;
            numericUpDownYear.Value = now.Year;
            numericUpDownMonth.Value = now.Month;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelDays.Text = "授業日  ： ";
            labelTime.Text = "開始時間  ： ";
            labelMoney.Text = "授業料  ： ";
            Course course = new Course();
            int courseLen = listBoxCourse.SelectedIndex;
            int year = (int)numericUpDownYear.Value;
            int month = (int)numericUpDownMonth.Value;
            int week = course.ArrWeek[courseLen];
            int time = course.ArrTime[courseLen];
            int money = course.ArrMoney[courseLen];
            string sankaDay = "";
            int lessonCnt = 0;

            int daysInMonth = DateTime.DaysInMonth(year, month);
            for (int i = 1; i <= daysInMonth - 3; i++)
            {
                DateTime dt = new DateTime(year, month, i);
                int checkWeek = (int)dt.DayOfWeek;
                if (checkWeek == week)
                {
                    sankaDay += (i + "日  ");
                    lessonCnt++;
                }
            }
            labelDays.Text += sankaDay;
            labelTime.Text += (time + "時");
            labelMoney.Text += (money * lessonCnt + "円");
        }
    }
}
