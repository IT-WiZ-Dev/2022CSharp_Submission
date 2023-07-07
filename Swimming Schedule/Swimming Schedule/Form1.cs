using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swimming_Schedule
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
            data.Add(new Course("レディーコース", 5, 20, 1000));
            data.Add(new Course("一般コース", 6, 20, 1200));
            data.Add(new Course("家族コース", 0, 10, 1500));

            foreach(Course obj in data)
            {
                listBox1.Items.Add(obj.CourseName);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            Console.WriteLine(data[index].CourseName);
            //日付の作り方
            DataTime t = new DataTime(2023, 6, 30);
        }

      
    }
}
