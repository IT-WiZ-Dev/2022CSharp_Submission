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
        List<Cource> data;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            data = new List<Cource>();
            data.Add(new Cource("ベビーコース",   1, 14, 1000));
            data.Add(new Cource("幼児コース",     2, 10, 1000));
            data.Add(new Cource("小学生コース",   3, 17,  800));
            data.Add(new Cource("中学生コース",   4, 19,  800));
            data.Add(new Cource("レディーコース", 5, 20, 1000));
            data.Add(new Cource("一般コース",     6, 20, 1200));
            data.Add(new Cource("家族コース",     0, 10, 1500));

            foreach(Cource obj in data)
            {
                listBox1.Items.Add(obj.CourceName);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label.Text = "";
            labelt.Text = "";
            labelp.Text = "";
            int year = (int)numericUpDown3.Value;
            int month = (int)numericUpDown2.Value;
            int n = listBox1.SelectedIndex;
            Cource cource = data[n];
            int youbi = cource.DayofWeek;
            int time = cource.StartTime;
            int money = cource.Price;
            int daysInMonth = DateTime.DaysInMonth(year, month);
            int count = 0;
            for(int i = 1;i <= daysInMonth - 3; i++)
            {
                DateTime dt = new DateTime(year, month, i);
                int w = (int)dt.DayOfWeek;
                if(w == youbi)
                {
                    label.Text = label.Text + i + "日";
                    count += 1;
                }
            }
            labelt.Text = time + "時";
            labelp.Text = (money * count) + "円";
            
        }
    }
}
