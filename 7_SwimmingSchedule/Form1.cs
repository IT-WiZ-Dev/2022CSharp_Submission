using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_SwimmingSchedule
{
    
    public partial class Form1 : Form
    {
        List<Course> data;
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            int year = (int)numericUpDown1.Value;
            int month = (int)numericUpDown2.Value;
            int endDay = DateTime.DaysInMonth(2023, 6);
            int price = 0;
            //2023年6月の最終日
            //曜日の比較
            label2.Text = "";
            for (int i = 1; i <= endDay; i++)
            {
                
                DateTime t = new DateTime(year,month,i);
                if((int)t.DayOfWeek+1 == data[index].dayOfWeek)
                {
                    label2.Text += ($"{i}日 ");
                    price += data[index].price;
                }
            }
            label3.Text = $"{data[index].startTime}時";
            label4.Text = $"{price}円";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            data = new List<Course>();
            data.Add(new Course("ベビーコース",1, 14, 1000));
            data.Add(new Course("幼児コース", 2, 10, 1000));
            data.Add(new Course("小学生コース", 3, 17, 800));
            data.Add(new Course("中学生コース", 4, 19, 800));
            data.Add(new Course("レディースコース", 5, 20, 1000));
            data.Add(new Course("一般コース", 6, 20, 1200));
            data.Add(new Course("家庭コース", 7, 10, 1500));
            foreach(Course obj in data)
            {
                listBox1.Items.Add(obj.courseName);
            }
        }
        public string CourseName
        {
            set
            {
                this.CourseName = value;
            }
            get
            {
                return this.CourseName;
            }
        }
    }
}
