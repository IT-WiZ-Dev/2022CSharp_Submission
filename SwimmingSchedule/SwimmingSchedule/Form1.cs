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
    public partial class Form : System.Windows.Forms.Form
    {
        List<コースクラス> data;
        public Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelZyugyo.Text = "";
            labelKaishi.Text = "";
            labelRyokin.Text = "";
            int year = (int)numericUpDown1.Value;
            int month = (int)numericUpDown2.Value;
            int n = listBox.SelectedIndex;
            コースクラス course = data[n];
            int youbi = course.DayOfWeek; 
            int time = course.StartTime;
            int money = course.Price;
            int daysInMonth = DateTime.DaysInMonth(year, month);
            int count = 0;
            for (int a = 1; a <= daysInMonth - 3; a++)
            {
                DateTime dt = new DateTime(year, month, a);
                int w = (int)dt.DayOfWeek;
                if (w == youbi)
                {
                    labelZyugyo.Text = labelZyugyo.Text + a + "日 ";
                    count += 1;
                }
            }
            labelKaishi.Text = time + "時";
            labelRyokin.Text = (money * count) + "円";
        }

        private void Form_Load(object sender, EventArgs e)
        {
            labelZyugyo.Text = "";
            labelKaishi.Text = "";
            labelRyokin.Text = "";
            data = new List<コースクラス>();
            data.Add(new コースクラス("ベビーコース", 1, 14, 1000));
            data.Add(new コースクラス("幼児コース", 2, 10, 1000));
            data.Add(new コースクラス("小学生コース", 3, 17, 800));
            data.Add(new コースクラス("中学生コース", 4, 19, 800));
            data.Add(new コースクラス("レディースコース", 5, 20, 1000));
            data.Add(new コースクラス("一般コース", 6, 20, 1200));
            data.Add(new コースクラス("家族コース", 0, 10, 1500));
            foreach (コースクラス obj in data)
            {
                listBox.Items.Add(obj.Coce);
            }
        }
    }
}

