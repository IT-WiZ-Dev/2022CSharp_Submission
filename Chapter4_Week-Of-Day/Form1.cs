using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter4_Week_Of_Day
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string year_text1 = textBox1.Text;
                int year1 = int.Parse(textBox1.Text);
            }
            catch(InvalidCastException)
            {
                label4.Text = "西暦年エラー";
            }

            try
            {
                string year_text2 = textBox1.Text;
                int year2 = int.Parse(textBox1.Text);
            }
            catch (FormatException)
            {
                label4.Text = "西暦年エラー";
            }

            string year_text = textBox1.Text;
            int year = int.Parse(textBox1.Text);

            decimal value_month = numericUpDown1.Value;
            int month= (int)value_month;

            decimal value_day = numericUpDown2.Value;
            int day = (int)value_day;

            int urudoshi = 0;
            int urudoshi_4_100 = 0;
            
            Judge_urudoshi(year,urudoshi,urudoshi_4_100);
            Check_month_day(month,day);
            Day_of_week(year, month, day);
 
            
        }

        private bool Judge_urudoshi(int year, int urudoshi, int urudoshi_4_100)
        {
            if (year % 4 == 0)
            {
                urudoshi_4_100 += 1;
            }

            if (year % 100 != 0)
            {
                urudoshi_4_100 += 1;
            }

            if (urudoshi_4_100 == 2)
            {
                return true;
            }

            if (year % 400 == 0)
            {
                return true;
            }

            return false;

        }


        private string Check_month_day(int month, int day)
        {
            
            if (month == 2 && day == 29)
            {
                label4.Text = "あり得ない日付";
            }





            if (month == 2 && day == 30)
            {
                label4.Text = "あり得ない日付";
            }
            if (month == 2 && day == 31)
            {
                label4.Text = "あり得ない日付";
            }
            if (month == 4 && day == 31)
            {
                label4.Text = "あり得ない日付";
            }
            if (month == 6 && day == 31)
            {
                label4.Text = "あり得ない日付";
            }
            if (month == 9 && day == 31)
            {
                label4.Text = "あり得ない日付";
            }
            if (month == 11 && day == 31)
            {
                label4.Text = "あり得ない日付";
            }

            return label4.Text;

        }

        private string Day_of_week(int year,int month,int day)
        {
            if (month == 1)
            {
                year -= 1;
                month += 12;
            }

            if (month == 2)
            {
                year -= 1;
                month += 12;
            }

            int w = (5 * year / 4 - year / 100 + year / 400 + (26 * month + 16) / 10 + day) % 7;

            string[] arr = { "日曜日", " 月曜日 ", "火曜日 ", "水曜日", " 木曜日 ", "金曜日", " 土曜日" };
            return arr[w];
            string arr_text = arr[w];
            label4.Text = arr_text + "です";

        }


        
    }
}
