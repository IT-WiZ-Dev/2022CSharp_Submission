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
        List<Course> data;//可変長配列

        public Form1()
        {
            InitializeComponent();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label6.Text = " ";
            label7.Text = " ";
            label8.Text = " ";
            data = new List<Course>();
            data.Add(new Course("ベビーコース", 1, 14, 1000));
            data.Add(new Course("幼児コース", 2, 10, 1000));
            data.Add(new Course("小学生コース", 3, 17, 800));
            data.Add(new Course("中学生コース", 4, 19, 800));
            data.Add(new Course("レディースコース", 5, 20, 1000));
            data.Add(new Course("一般コース", 6, 20, 1200));
            data.Add(new Course("家族コース", 0, 10, 1500));
            foreach (Course obj in data)
            {
                listBox1.Items.Add(obj.Coursename);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            int total = 0;
            int y = 0;
            int m = 0;
            y = (int)numericUpDown1.Value ;
            m = (int)numericUpDown2.Value ;
            Console.WriteLine(data[index].Coursename);
            label7.Text = data[index].Strattime.ToString()+"時";


            //日付の作り方

            //2023年6月の最終日
            int endDay = DateTime.DaysInMonth(y, m);
            DateTime t = new DateTime(y, m, 30);
            for (int i = 1; i <= endDay; i++)
            {
                DateTime t2 = new DateTime(y, m, i);
                //曜日の比較
                if (data[index].DayOfWeek == (int)t2.DayOfWeek)
                {
                    label6.Text = label6.Text +i+"日　";
                    total = total + data[index].Price;
                }
                label8.Text = total.ToString()+"円";
            }


        }
    }
}

