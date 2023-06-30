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
        List<course> date;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            date = new List<course>();
            date.Add(new course("ベビーコース",1,14,1000));
            date.Add(new course("幼児コース", 2, 10, 1000));
            date.Add(new course("小学生コース", 3, 17, 800));
            date.Add(new course("中学生コース", 4, 19, 800));
            date.Add(new course("レディースコース", 20, 14, 1000));
            date.Add(new course("一般コース", 6, 20, 1200));
            date.Add(new course("家族コース", 0, 10, 1500));
            
            foreach(course obj in date)
            {
                listBox1.Items.Add(obj.CourseName);
            }
            DateTime now = DateTime.Now;
            int year = now.Year;
            int month = now.Month;
            numericUpDown1.Value = year;
            numericUpDown2.Value = month;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year = (int)numericUpDown1.Value;
            int month = (int)numericUpDown2.Value;
            int index = listBox1.SelectedIndex;
            int endDay = DateTime.DaysInMonth(year,month );
            int cnt = 0;
            string a = "";
            
            for (int i = 1; i <= endDay-3; i++ )
            {
                DateTime dt = new DateTime(year, month, i);
                int w = (int)dt.DayOfWeek;
                if(w == date[index].DayOfWeek)
                {
                    a = a + i + ",";
                    cnt =cnt + 1;
                }
                label4.Text = a;
                label5.Text = Convert.ToString(date[index].StartTime);
                label6.Text = Convert.ToString(date[index].Price * cnt);
            }
                
        }
    
            
    }
}

