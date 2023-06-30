

using System.Linq;

using System.Text;


using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;
using System.Threading.Tasks;

using System.Windows.Forms;

 

namespace SwimmingSchedule

{



    public partial class Form1 : Form

    {

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

            data.Add(new Course("家族コース", 0, 10, 1500));



            foreach (Course obj in data)

            {

                listBox1.Items.Add(obj.CourseName);

            }

        }



        private void numericUpDownY_ValueChanged(object sender, EventArgs e)

        {





        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)

        {


        }





        private void button1_Click(object sender, EventArgs e)

        {

            label1.Text = "授業日";

            label2.Text = "開始時間";

            label3.Text = "授業料";

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            Console.WriteLine(data[index].CourseName);


            DateTime t = new DateTime(2023, 6 ,30);

            int endDay = DateTime.DaysInMonth(2023, 6);

            for (int i = 1; i <= endDay; i++) 
            {
                DateTime t2 = new DateTime(2023, 6, i);
            }
            _ = (int)t.DayOfWeek == (int)t.DayOfWeek;

        }
    }

}
