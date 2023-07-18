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
        private Course course1, course2, course3, course4, course5, course6, course7;

        public Form1()
        {
            InitializeComponent();
        }

       
        private void FormSwimming_Load(object sender, EventArgs e)
        {
            // 各コースのインスタンスの生成
            course1 = new Course("ベビーコース", 1, 14, 1000);
            course2 = new Course("幼児コース", 2, 10, 1000);
            course3 = new Course("小学生コース", 3, 17, 800);
            course4 = new Course("中学生コース", 4, 19, 800);
            course5 = new Course("レディースコース", 5, 20, 1000);
            course6 = new Course("一般コース", 6, 20, 1200);
            course7 = new Course("家族コース", 0, 10, 1500);

            
            numericUpDown1.Value = DateTime.Now.Year;
            numericUpDown2.Value = DateTime.Now.Month;

            // リストボックスの項目
            listBox1.Items.Add(course1.Name);
            listBox1.Items.Add(course2.Name);
            listBox1.Items.Add(course3.Name);
            listBox1.Items.Add(course4.Name);
            listBox1.Items.Add(course5.Name);
            listBox1.Items.Add(course6.Name);
            listBox1.Items.Add(course7.Name);
        }

        
        private void ButtonDisplay_Click(object sender, EventArgs e)
        {
            
            int n = listBox1.SelectedIndex;
            int year = (int)numericUpDown1.Value;
            int month = (int)numericUpDown2.Value;

            
            switch (n)
            {
                case 0:
                    label3.Text = "授業日    ： " + course1.SchoolDays(year, month);
                    label4.Text = "開始時間 ： " + course1.StartTime + "時";
                    label5.Text = "授業料    ： " + course1.SchoolFee(year, month) + "円";
                    break;
                case 1:
                    label3.Text = "授業日    ： " + course2.SchoolDays(year, month);
                    label4.Text = "開始時間 ： " + course2.StartTime + "時";
                    label5.Text = "授業料    ： " + course2.SchoolFee(year, month) + "円";
                    break;
                case 2:
                    label3.Text = "授業日    ： " + course3.SchoolDays(year, month);
                    label4.Text = "開始時間 ： " + course3.StartTime + "時";
                    label5.Text = "授業料    ： " + course3.SchoolFee(year, month) + "円";
                    break;
                case 3:
                    label3.Text = "授業日    ： " + course4.SchoolDays(year, month);
                    label4.Text = "開始時間 ： " + course4.StartTime + "時";
                    label5.Text = "授業料    ： " + course4.SchoolFee(year, month) + "円";
                    break;
                case 4:
                    label3.Text = "授業日    ： " + course5.SchoolDays(year, month);
                    label4.Text = "開始時間 ： " + course5.StartTime + "時";
                    label5.Text = "授業料    ： " + course5.SchoolFee(year, month) + "円";
                    break;
                case 5:
                    label3.Text = "授業日    ： " + course6.SchoolDays(year, month);
                    label4.Text = "開始時間 ： " + course6.StartTime + "時";
                    label5.Text = "授業料    ： " + course6.SchoolFee(year, month) + "円";
                    break;
                case 6:
                    label3.Text = "授業日    ： " + course7.SchoolDays(year, month);
                    label4.Text = "開始時間 ： " + course7.StartTime + "時";
                    label5.Text = "授業料    ： " + course7.SchoolFee(year, month) + "円";
                    break;
                default:
                    label3.Text = "コースを選択してください";
                    label4.Text = "";
                    label5.Text = "";
                    break;
            }
        }
    }
}
