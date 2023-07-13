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
    public partial class FormSwimming : Form
    {
        private Course course1, course2, course3, course4, course5, course6, course7;

        private void numericUpDownMonth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public FormSwimming()
        {
            InitializeComponent();
        }

        
        private void FormSwimming_Load(object sender, EventArgs e)
        {
            
            course1 = new Course("ベビーコース", 1, 14, 1000);
            course2 = new Course("幼児コース", 2, 10, 1000);
            course3 = new Course("小学生コース", 3, 17, 800);
            course4 = new Course("中学生コース", 4, 19, 800);
            course5 = new Course("レディースコース", 5, 20, 1000);
            course6 = new Course("一般コース", 6, 20, 1200);
            course7 = new Course("家族コース", 0, 10, 1500);

            
            numericUpDownYear.Value = DateTime.Now.Year;
            numericUpDownMonth.Value = DateTime.Now.Month;

            
            listBoxCourse.Items.Add(course1.Name);
            listBoxCourse.Items.Add(course2.Name);
            listBoxCourse.Items.Add(course3.Name);
            listBoxCourse.Items.Add(course4.Name);
            listBoxCourse.Items.Add(course5.Name);
            listBoxCourse.Items.Add(course6.Name);
            listBoxCourse.Items.Add(course7.Name);
        }
        private void ButtonDisplay_Click(object sender, EventArgs e)
        {
            
            int z = listBoxCourse.SelectedIndex;
            int year = (int)numericUpDownYear.Value;
            int month = (int)numericUpDownMonth.Value;   
            switch (z)
            {
                case 0:
                    labelDays.Text = "授業日    ： " + course1.SchoolDays(year, month);
                    labelStartTime.Text = "開始時間 ： " + course1.StartTime + "時";
                    labelFee.Text = "授業料    ： " + course1.SchoolFee(year, month) + "円";
                    break;
                case 1:
                    labelDays.Text = "授業日    ： " + course2.SchoolDays(year, month);
                    labelStartTime.Text = "開始時間 ： " + course2.StartTime + "時";
                    labelFee.Text = "授業料    ： " + course2.SchoolFee(year, month) + "円";
                    break;
                case 2:
                    labelDays.Text = "授業日    ： " + course3.SchoolDays(year, month);
                    labelStartTime.Text = "開始時間 ： " + course3.StartTime + "時";
                    labelFee.Text = "授業料    ： " + course3.SchoolFee(year, month) + "円";
                    break;
                case 3:
                    labelDays.Text = "授業日    ： " + course4.SchoolDays(year, month);
                    labelStartTime.Text = "開始時間 ： " + course4.StartTime + "時";
                    labelFee.Text = "授業料    ： " + course4.SchoolFee(year, month) + "円";
                    break;
                case 4:
                    labelDays.Text = "授業日    ： " + course5.SchoolDays(year, month);
                    labelStartTime.Text = "開始時間 ： " + course5.StartTime + "時";
                    labelFee.Text = "授業料    ： " + course5.SchoolFee(year, month) + "円";
                    break;
                case 5:
                    labelDays.Text = "授業日    ： " + course6.SchoolDays(year, month);
                    labelStartTime.Text = "開始時間 ： " + course6.StartTime + "時";
                    labelFee.Text = "授業料    ： " + course6.SchoolFee(year, month) + "円";
                    break;
                case 6:
                    labelDays.Text = "授業日    ： " + course7.SchoolDays(year, month);
                    labelStartTime.Text = "開始時間 ： " + course7.StartTime + "時";
                    labelFee.Text = "授業料    ： " + course7.SchoolFee(year, month) + "円";
                    break;
                default:
                    labelDays.Text = "コースを選択してください";
                    labelStartTime.Text = "";
                    labelFee.Text = "";
                    break;
            }
        }
    }
}
