﻿using System;
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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelday.Text = "";
            labeltime.Text = "";
            labelen.Text = "";

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
                listBoxcourse.Items.Add( obj.CourseName );
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBoxcourse.SelectedIndex;
            Console.WriteLine(data[index].CourseName);

            //日付の作り方
            DateTime t = new DateTime(2023, 6, 30);
            //2023年6月の最終日
            int endDay = DateTime.DaysInMonth(2023, 6);

            for (int i = 1; i <= endDay; i++)  
            {
                DateTime t2 = new DateTime(2023, 6, i);
                if((int)t2.DayOfWeek == data[index].dayOfWeek)
                {
                    labelday.Text += t2.Day.ToString();                                            
                }
            }
            //曜日の比較
            //data[index].dayOfWeek == (int)t.DayOfWeek;
        }
    }
}
