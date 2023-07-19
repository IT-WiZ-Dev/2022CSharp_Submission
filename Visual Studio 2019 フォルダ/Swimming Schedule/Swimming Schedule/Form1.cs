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
        private Course courseA, courseB, courseC, courseD, courseE, courseF, courseG;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            courseA = new Course("ベビーコース", 1, 14, 1000);
            courseB = new Course("幼児コース", 2, 10, 1000);
            courseC = new Course("小学生コース", 3, 17, 800);
            courseD = new Course("中学生コース", 4, 19, 800);
            courseE = new Course("レディースコース", 5, 20, 1000);
            courseF = new Course("一般コース", 6, 20, 1200);
            courseG = new Course("家族コース", 0, 10, 1500);

            numericUpDown1.Value = DateTime.Now.Year;
            numericUpDown2.Value = DateTime.Now.Month;

            listBox1.Items.Add(courseA.Name);
            listBox1.Items.Add(courseB.Name);
            listBox1.Items.Add(courseC.Name);
            listBox1.Items.Add(courseD.Name);
            listBox1.Items.Add(courseE.Name);
            listBox1.Items.Add(courseF.Name);
            listBox1.Items.Add(courseG.Name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = listBox1.SelectedIndex;
            int year = (int)numericUpDown1.Value;
            int month = (int)numericUpDown2.Value;

            switch (n)
            {
                case 0:
                    label1.Text = "授業日    ： " + courseA.SchoolDays(year, month);
                    label2.Text = "開始時間 ： " + courseA.StartTime + "時";
                    label3.Text = "授業料    ： " + courseA.SchoolFee(year, month) + "円";
                    break;
                case 1:
                    label1.Text = "授業日    ： " + courseB.SchoolDays(year, month);
                    label2.Text = "開始時間 ： " + courseB.StartTime + "時";
                    label3.Text = "授業料    ： " + courseB.SchoolFee(year, month) + "円";
                    break;
                case 2:
                    label1.Text = "授業日    ： " + courseC.SchoolDays(year, month);
                    label2.Text = "開始時間 ： " + courseC.StartTime + "時";
                    label3.Text = "授業料    ： " + courseC.SchoolFee(year, month) + "円";
                    break;
                case 3:
                    label1.Text = "授業日    ： " + courseD.SchoolDays(year, month);
                    label2.Text = "開始時間 ： " + courseD.StartTime + "時";
                    label3.Text = "授業料    ： " + courseD.SchoolFee(year, month) + "円";
                    break;
                case 4:
                    label1.Text = "授業日    ： " + courseE.SchoolDays(year, month);
                    label2.Text = "開始時間 ： " + courseE.StartTime + "時";
                    label3.Text = "授業料    ： " + courseE.SchoolFee(year, month) + "円";
                    break;
                case 5:
                    label1.Text = "授業日    ： " + courseF.SchoolDays(year, month);
                    label2.Text = "開始時間 ： " + courseF.StartTime + "時";
                    label3.Text = "授業料    ： " + courseF.SchoolFee(year, month) + "円";
                    break;
                case 6:
                    label1.Text = "授業日    ： " + courseG.SchoolDays(year, month);
                    label2.Text = "開始時間 ： " + courseG.StartTime + "時";
                    label3.Text = "授業料    ： " + courseG.SchoolFee(year, month) + "円";
                    break;
                default:
                    label1.Text = "コースを選択してください";
                    label2.Text = "";
                    label3.Text = "";
                    break;
            }
        }
    }
}
