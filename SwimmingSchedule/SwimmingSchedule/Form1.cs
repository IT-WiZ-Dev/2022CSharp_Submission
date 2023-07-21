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
        List<Course> data;
        private int year;
        private int mouth;
        private int kin;
        private int count =0;
        private int sougaku = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            data = new List<Course>();
            data.Add(new Course("ベビーコース",1,14,1000));
            data.Add(new Course("幼児コース", 2, 10, 1000));
            data.Add(new Course("小学生コース", 3, 17, 800));
            data.Add(new Course("中学生コース", 4, 19, 800));
            data.Add(new Course("レディースコース", 5, 20, 1000));
            data.Add(new Course("一般コース", 6, 20, 1200));
            data.Add(new Course("家族コース", 0, 10, 1500));

            foreach(Course obj in data)
            {
                listBox1.Items.Add(obj.CourseName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            year = (int)numericUpDown1.Value;
            mouth = (int)numericUpDown2.Value;
            int index = listBox1.SelectedIndex;
            labelDay.Text = "";
            labelTime.Text = "";
            labelMony.Text = "";
            //Console.WriteLine(data[index].CourseName);

            //日付の作り方
            DateTime t = new DateTime(year, mouth, 30);
            //2023年6月の最終日
            int endDay = DateTime.DaysInMonth(year, mouth);
            //曜日の比較
            for (int i = 1; i <= endDay; i++)
            {
                DateTime t2 = new DateTime(year, mouth, i);
                if ((int)t2.DayOfWeek == data[index].DayOfWeek)
                {
                    if (i <= endDay - 3)
                    {
                        labelDay.Text += i + "日";
                        count = count + 1;
                    }
                }
            }
             kin = data[index].Price;
            sougaku = kin * count;
            labelTime.Text = data[index].StartTime + "時";
            labelMony.Text = sougaku+ "円";
        }
    }
}
