using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 第七章練習問題
{

    public partial class Form1 : Form
    {
        internal int year;
        internal int month;

        //コースのデータの配列
        List<course> data;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            data = new List<course>();
            data.Add(new course("ベビーコース", 1, 14, 1000));
            data.Add(new course("幼児コース", 2, 10, 1000));
            data.Add(new course("小学生コース", 3, 17, 800));
            data.Add(new course("中学生コース", 4, 19, 800));
            data.Add(new course("レディーコース", 5, 14, 1000));
            data.Add(new course("一班コース", 6, 20, 1200));
            data.Add(new course("家族コース", 0, 10, 1500));

            foreach(course obj in data)
            {
                listBox1.Items.Add(obj.CourseName);
            }
            numericUpDownYear.Maximum = 3000;
            numericUpDownYear.Minimum = 0;

            numericUpDownMonth.Maximum = 12;
            numericUpDownMonth.Minimum = 0;

            numericUpDownYear.Value = DateTime.Now.Year;
            numericUpDownMonth.Value = DateTime.Now.Month;

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;

            year = (int)numericUpDownYear.Value;
            month = (int)numericUpDownMonth.Value;

            // ラベルのテキストを初期化
            labelDay.Text = "";
            labelStartTime.Text = "";
            labelPrice.Text = "";

            // 指定された年月の最初の日を取得
            DateTime startDate = new DateTime(year, month, 1);

            // 指定された年月の最終日を取得
            DateTime endDate = startDate.AddMonths(1).AddDays(-1);


            int dayOFWeek = data[index].DayOFWeek;

            DateTime startDayOfWeek = new DateTime(year, month, 1);
            while ((int)startDate.DayOfWeek != dayOFWeek)
            {
                startDayOfWeek = startDate.AddDays(1);
            }

            TimeSpan difference = endDate - startDate;
            int dayDifference = difference.Days;

            int strofweek = startDayOfWeek.Day;

            




            if (index >= 0 && index < data.Count)
            {
                int startTime = data[index].StartTime;
                labelStartTime.Text = startTime.ToString() + "時";

                int dayOfWeek = (int)DateTime.Parse($"{year}/{month}/1").DayOfWeek;
                int price = data[index].Price * GetDayOfWeekCount(dayOfWeek, startDate, endDate);
                labelPrice.Text = price.ToString();
            }
        }


        private int GetDayOfWeekCount(int dayOfWeek, DateTime startDate, DateTime endDate)
        {
            int count = 0;
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if ((int)date.DayOfWeek == dayOfWeek)
                {
                    count++;
                }
            }
            return count;
        }

        }
    }

