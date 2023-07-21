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
        private Cource cource1, cource2, cource3, cource4, cource5, cource6, cource7;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            cource1 = (new Cource("ベビーコース",1,14,1000));
            cource2 = (new Cource("幼児コース", 2, 10, 1000));
            cource3 = (new Cource("小学生コース", 3, 17, 800));
            cource4 = (new Cource("中学生コース", 4, 19, 800));
            cource5 = (new Cource("レディースコース", 5, 20, 1000));
            cource6 = (new Cource("一般コース", 6, 20, 1200));
            cource7 = (new Cource("家族コース", 0, 10, 1500));
 
            numericUpDown1.Value = DateTime.Now.Year;
            numericUpDown2.Value = DateTime.Now.Month;

            listBox1.Items.Add("ベビーコース");
            listBox1.Items.Add("幼児コース");
            listBox1.Items.Add("小学生コース");
            listBox1.Items.Add("中学生コース");
            listBox1.Items.Add("レディースコース");
            listBox1.Items.Add("一般コース");
            listBox1.Items.Add("家族コース");


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = listBox1.SelectedIndex;
            int year = (int)numericUpDown1.Value;
            int month = (int)numericUpDown2.Value;

            switch (n)
            {
                case 0:
                    label3.Text = "授業日    ： " + cource1.SchoolDays(year, month);
                    label4.Text = "開始時間 ： " + cource1.Starttime + "時";
                    label5.Text = "授業料    ： " + cource1.SchoolFee(year, month) + "円";
                    break;
                case 1:
                    label3.Text= "授業日    ： " + cource2.SchoolDays(year, month);
                    label4.Text = "開始時間 ： " + cource2.Starttime + "時";
                    label5.Text = "授業料    ： " + cource2.SchoolFee(year, month) + "円";
                    break;
                case 2:
                    label3.Text = "授業日    ： " + cource3.SchoolDays(year, month);
                    label4.Text = "開始時間 ： " + cource3.Starttime + "時";
                    label5.Text = "授業料    ： " + cource3.SchoolFee(year, month) + "円";
                    break;
                case 3:
                    label3.Text = "授業日    ： " + cource4.SchoolDays(year, month);
                    label4.Text = "開始時間 ： " + cource4.Starttime + "時";
                    label5.Text = "授業料    ： " + cource4.SchoolFee(year, month) + "円";
                    break;
                case 4:
                    label3.Text = "授業日    ： " + cource5.SchoolDays(year, month);
                    label4.Text = "開始時間 ： " + cource5.Starttime + "時";
                    label5.Text = "授業料    ： " + cource5.SchoolFee(year, month) + "円";
                    break;
                case 5:
                    label3.Text = "授業日    ： " + cource6.SchoolDays(year, month);
                    label4.Text = "開始時間 ： " + cource6.Starttime + "時";
                    label5.Text = "授業料    ： " + cource6.SchoolFee(year, month) + "円";
                    break;
                case 6:
                    label3.Text = "授業日    ： " + cource7.SchoolDays(year, month);
                    label4.Text = "開始時間 ： " + cource7.Starttime + "時";
                    label5.Text = "授業料    ： " + cource7.SchoolFee(year, month) + "円";
                    break;
                default:
                    label3.Text = "コースを選択してください";
                    label4.Text = "";
                    label5.Text = "";
                    break;
            }



        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
