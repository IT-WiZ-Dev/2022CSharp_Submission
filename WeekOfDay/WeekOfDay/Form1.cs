using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeekOfDay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ここまでしかできませんでした
            int year = int.Parse(textBox1.Text);
            int month = int.Parse(listBox1.Text);
            int day = int.Parse(listBox2.Text);
            DateTime date = new DateTime(year, month, day);
            // 曜日を取得して表示
            DayOfWeek dayOfWeek = date.DayOfWeek;
            //label4.Text
            string a = dayOfWeek.ToString();
            if (a == "Friday")
            {
                label4.Text = "金曜日";
            }
            if (a == "Thursday")
            {
                label4.Text = "木曜日";
            }
            if (a == "Wednesday")
            {
                label4.Text = "水曜日";
            }
            if (a == "Tuesday")
            {
                label4.Text = "火曜日";
            }
            if (a == "Monday")
            {
                label4.Text = "月曜日";
            }






            /*
            int y = int.Parse(textBox1.Text);
            bool b;
            listBox2.Text = b;

            if(4 % a = 0 && 100 % a=1 || y % 400 = 0)
            {
                //うるう年
            }
            if (listBox1.Text=="2") { 

            }
            if(listBox2.Text == "4" || listBox2.Text == "6" || listBox2.Text == "9" || listBox2.Text == "11")
            {
                if (listBox2.Text=="31")
                {
                    
                }
            }
            */
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
