using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_演習問題_22310121
{
    public partial class Form1 : Form
    {
        //コースのデータの配列
        List<Course> data;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            data = new List<Course>();
            data.Add(new Course("ベビーコース", 1, 14, 1000));
            data.Add(new Course("幼児コース", 2, 10, 1000));
            data.Add(new Course("小学生コース", 3, 17, 800));
            data.Add(new Course("中学生コース", 4, 19, 800));
            data.Add(new Course("レディースコース", 5, 20, 1000));
            data.Add(new Course("一般コース", 6, 20, 1200));
            data.Add(new Course("家族コース", 7, 10, 1500));

            foreach(Course obj in data)
            {
                listBox1.Items.Add( obj.CourseName );

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N1 = (int)numericUpDown1.Value;
            int N2 = (int)numericUpDown2.Value;
            int index = listBox1.SelectedIndex;
            int total = 0;
            Console.WriteLine(data[index].CourseName);

            //日付の作り方
            DateTime t = new DateTime(2023,06,30);
            //2023/06の最終日が欲しいなら
            int endDay = DateTime.DaysInMonth(N1,N2);

            for (int i = 1; i <= endDay; i++)//日にちを回してる
            {
                DateTime m = new DateTime(N1, N2, i);//年、月、日
                if (data[index].DayOfWeek == (int)m.DayOfWeek)
                {
                    label3.Text = label3.Text + i + "日";
                    total = total + data[index].Price;
                }
                label5.Text = "授業料："+total.ToString();
            }

            Console.WriteLine(data[index].Starttime);
            label4.Text = "開始時間：" + data[index].Starttime.ToString();


            }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}




