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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDownYear.Value = DateTime.Now.Year;
            numericUpDownMonth.Value = DateTime.Now.Month;
            labelDay.Text = "";
            labelTime.Text = "";
            labelPrice.Text = "";

            listBoxCourse.Items.Add("ベビーコース");
            listBoxCourse.Items.Add("幼児コース");
            listBoxCourse.Items.Add("小学生コース");
            listBoxCourse.Items.Add("中学生コース");
            listBoxCourse.Items.Add("レディースコース");
            listBoxCourse.Items.Add("一般コース");
            listBoxCourse.Items.Add("家族コース");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelDay.Text = "";
            Course c = new Course();
            int cnt = 0;
            int week = c.weeknum(listBoxCourse.SelectedIndex);

            DateTime dt = new DateTime((int)numericUpDownYear.Value, (int)numericUpDownMonth.Value, 1);
            for (int i = 1;dt.Day < (DateTime.DaysInMonth(dt.Year,dt.Month))-2;i++)
            {
                dt = new DateTime((int)numericUpDownYear.Value, (int)numericUpDownMonth.Value, i);
                if ((int)dt.DayOfWeek == week) 
                {
                    labelDay.Text += dt.Day + "日" + "　";
                    cnt++;
                }
            }
            labelTime.Text = c.startnum(listBoxCourse.SelectedIndex)+"時";
            labelPrice.Text = c.pricenum(listBoxCourse.SelectedIndex)*cnt + "円";
        }
    }
}
