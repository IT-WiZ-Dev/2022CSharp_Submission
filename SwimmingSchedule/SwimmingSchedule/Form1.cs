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
        List<コースクラス> data;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = "";
            label6.Text = "";
            label8.Text = "";
            data = new List<コースクラス>();
            data.Add(new コースクラス("ベビーコース", 1, 14, 1000));
            data.Add(new コースクラス("幼児コース", 2, 10, 1000));
            data.Add(new コースクラス("小学生コース", 3, 17, 800));
            data.Add(new コースクラス("中学生コース", 4, 19, 800));
            data.Add(new コースクラス("レディースコース", 5, 20, 1000));
            data.Add(new コースクラス("一般コース", 6, 20, 1200));
            data.Add(new コースクラス("家族コース", 0, 10, 1500));

            foreach(コースクラス obj in data)
            {
                listBox1.Items.Add(obj.Course);
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            label6.Text = "";
            label8.Text = "";
            int a = (int)numericUpDown1.Value;
            int b = (int)numericUpDown2.Value;
            int n = listBox1.SelectedIndex;
            コースクラス course = data[n];
            int youbi = course.DayOfWeek;
            int time = course.StartTime;
            int money = course.Price;
            int year = a, month = b;
            int daysInMonth = DateTime.DaysInMonth(year, month);
            int count = 0;
            for(int i = 1; i <= daysInMonth-3; i++)
            {
                DateTime dt = new DateTime(year, month, i);
                int w = (int)dt.DayOfWeek;
                if(w == youbi)
                {
                    label4.Text = label4.Text + i + "日";
                    count += 1;
                }
            }
            label6.Text = time + "時";
            label8.Text = (money * count) + "円";
        }
    }
}
