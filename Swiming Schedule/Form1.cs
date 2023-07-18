using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swiming_Schedule
{
    public partial class Form1 : Form
    {
        public int n;
        List<course> data;
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            n = listBox1.SelectedIndex;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown2.Value == 13)
            {
                numericUpDown2.Value = 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            label6.Text = "";
            label8.Text = "";
            int year = (int)numericUpDown1.Value;
            int month = (int)numericUpDown2.Value;
            course course1 = data[n];
            int youbi = course1.DayofWeek;
            int time = course1.StartTime;
            int money = course1.Price;
            int daysInMonth = DateTime.DaysInMonth(year, month);
            int count = 0;
            for (int i = 1; i <= daysInMonth - 3; i++)
            {
                DateTime dt = new DateTime(year, month, i);
                int w = (int)dt.DayOfWeek;
                if (w == youbi)
                {
                    label4.Text = label4.Text + i + "日";
                    count += 1;
                }
            }
            label6.Text = time + "時";
            label8.Text = (money * count) + "円";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            data = new List<course>();
            data.Add(new course("ベビーコース", 0, 14, 1000));
            data.Add(new course("幼児コース", 1, 10, 1000));
            data.Add(new course("小学生コース", 2, 17, 800));
            data.Add(new course("中学生コース", 3, 19, 800));
            data.Add(new course("レディースコース", 4, 20, 1000));
            data.Add(new course("一般コース", 5, 20, 1200));
            data.Add(new course("家族コース", 6, 10, 1500));
        }
    }
}
