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
         int coursename ;
         int day;
         int starttime;
         int oneprice;

        List<Course> data;

        public Form1()
        {
            InitializeComponent();
            int n = listBox3.SelectedIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = "";

            int year = (int)numericUpDown1.Value;
            int month = (int)numericUpDown2.Value;
            int daysInMonth = DateTime.DaysInMonth(year, month);
            int num = 0;

            //ListToValue(listBox3.SelectedIndex, out coursename);


            //Course courses = new Course[daysInMonth];

            int index = listBox3.SelectedIndex;

            label9.Text = data[index].Starttime.ToString();

            int price = data[index].Oneprice;

            

            int endDay = DateTime.DaysInMonth(year, month);

            for (int i = 1; i <= endDay; i++)
            {
                DateTime d = new DateTime(year, month, i);   


                if (d.DayOfWeek.ToString() == data[index].Day.ToString())
                {
                    label5.Text += i + "日、";
                    num += 1;
                }


            }

            int sum = price * num;
            label11.Text = sum.ToString();
        }

        private void ListToValue(int list, out int coursename)
        {
            int.TryParse(list.ToString(), out coursename);
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            data = new List<Course>();

            data.Add( new Course("ベビーコース", "Monday", 14, 1000) ) ;
            data.Add( new Course("幼児コース", "Tuesday", 10, 1000) );
            data.Add(new Course("小学生コース", "Wednesday", 17, 800));
            data.Add(new Course("中学生コース", "Thursday", 19, 800));
            data.Add(new Course("レディースコース", "Friday", 20, 1000));
            data.Add(new Course("一般コース", "Saturday", 20, 1200));
            data.Add(new Course("家族コース", "Sunday", 10, 1500));

        }
    }
}
