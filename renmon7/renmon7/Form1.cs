using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace renmon7
{
    public partial class Form1 : Form
    {
        private Schedule schedule1, schedule2, schedule3, schedule4, schedule5, schedule6, schedule7;

        private void listBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            schedule1 = new Schedule("ベビーコース", 1, 14, 1000);
            schedule2 = new Schedule("幼児コース", 2, 10, 1000);
            schedule3 = new Schedule("小学生コース", 3, 17, 800);
            schedule4 = new Schedule("中学生コース", 4, 19, 800);
            schedule5 = new Schedule("レディースコース", 5, 20, 1000);
            schedule6 = new Schedule("一般コース", 6, 20, 1200);
            schedule7 = new Schedule("家族コース", 0, 10, 1500);

            numericUpDownYear.Value = DateTime.Now.Year;
            numericUpDownMonth.Value = DateTime.Now.Month;

            listBoxCourse.Items.Add(schedule1.CourseName);
            listBoxCourse.Items.Add(schedule2.CourseName);
            listBoxCourse.Items.Add(schedule3.CourseName);
            listBoxCourse.Items.Add(schedule4.CourseName);
            listBoxCourse.Items.Add(schedule5.CourseName);
            listBoxCourse.Items.Add(schedule6.CourseName);
            listBoxCourse.Items.Add(schedule7.CourseName);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            int n = listBoxCourse.SelectedIndex;
            int year = (int)numericUpDownYear.Value;
            int month = (int)numericUpDownMonth.Value;

            switch (n)
            {
                case 0:
                    labelDays.Text = "授業日    ： " + schedule1.SchoolDays(year, month);
                    labelStartTime.Text = "開始時間 ： " + schedule1.StartTime + "時";
                    labelFee.Text = "授業料    ： " + schedule1.SchoolFee(year, month) + "円";
                    break;
                case 1:
                    labelDays.Text = "授業日    ： " + schedule2.SchoolDays(year, month);
                    labelStartTime.Text = "開始時間 ： " + schedule2.StartTime + "時";
                    labelFee.Text = "授業料    ： " + schedule2.SchoolFee(year, month) + "円";
                    break;
                case 2:
                    labelDays.Text = "授業日    ： " + schedule3.SchoolDays(year, month);
                    labelStartTime.Text = "開始時間 ： " + schedule3.StartTime + "時";
                    labelFee.Text = "授業料    ： " + schedule3.SchoolFee(year, month) + "円";
                    break;
                case 3:
                    labelDays.Text = "授業日    ： " + schedule4.SchoolDays(year, month);
                    labelStartTime.Text = "開始時間 ： " + schedule4.StartTime + "時";
                    labelFee.Text = "授業料    ： " + schedule4.SchoolFee(year, month) + "円";
                    break;
                case 4:
                    labelDays.Text = "授業日    ： " + schedule5.SchoolDays(year, month);
                    labelStartTime.Text = "開始時間 ： " + schedule5.StartTime + "時";
                    labelFee.Text = "授業料    ： " + schedule5.SchoolFee(year, month) + "円";
                    break;
                case 5:
                    labelDays.Text = "授業日    ： " + schedule6.SchoolDays(year, month);
                    labelStartTime.Text = "開始時間 ： " + schedule6.StartTime + "時";
                    labelFee.Text = "授業料    ： " + schedule6.SchoolFee(year, month) + "円";
                    break;
                case 6:
                    labelDays.Text = "授業日    ： " + schedule7.SchoolDays(year, month);
                    labelStartTime.Text = "開始時間 ： " + schedule7.StartTime + "時";
                    labelFee.Text = "授業料    ： " + schedule7.SchoolFee(year, month) + "円";
                    break;
            }

        }
    }
}
