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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            course1 = new Course("ベビーコース", 1, 14, 1000);
            course2 = new Course("幼児コース", 2, 10, 1000);
            course3 = new Course("小学生コース", 3, 17, 800);
            course4 = new Course("中学生コース", 4, 19, 800);
            course5 = new Course("レディースコース", 5, 20, 1000);
            course6 = new Course("一般コース", 6, 20, 1200);
            course7 = new Course("家族コース", 0, 10, 1500);

            numericUpDown1.Value = DateTime.Now.Year;
            numericUpDown2.Value = DateTime.Now.Month;


            listBox1.Items.Add(course1.Name);
            listBox1.Items.Add(course2.Name);
            listBox1.Items.Add(course3.Name);
            listBox1.Items.Add(course4.Name);
            listBox1.Items.Add(course5.Name);
            listBox1.Items.Add(course6.Name);
            listBox1.Items.Add(course7.Name);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            int n = listBox1.SelectedIndex;
            int year = (int)numericUpDown1.Value;
            int month = (int)numericUpDown2.Value;

          
            switch (n)
            {
                case 0:
                    label4.Text =course1.SchoolDays(year, month);
                    label6.Text =course1.StartTime + "時";
                    label8.Text = course1.SchoolFee(year, month) + "円";
                    break;
                case 1:
                    label4.Text = course2.SchoolDays(year, month);
                    label6.Text =  course2.StartTime + "時";
                    label8.Text = course2.SchoolFee(year, month) + "円";
                    break;
                case 2:
                    label4.Text = course3.SchoolDays(year, month);
                    label6.Text = course3.StartTime + "時";
                    label8.Text =  course3.SchoolFee(year, month) + "円";
                    break;
                case 3:
                    label4.Text = course4.SchoolDays(year, month);
                    label6.Text =  course4.StartTime + "時";
                    label8.Text =  course4.SchoolFee(year, month) + "円";
                    break;
                case 4:
                    label4.Text = course5.SchoolDays(year, month);
                    label6.Text =  course5.StartTime + "時";
                    label8.Text =  course5.SchoolFee(year, month) + "円";
                    break;
                case 5:
                    label4.Text = course6.SchoolDays(year, month);
                    label6.Text =  course6.StartTime + "時";
                    label8.Text = course6.SchoolFee(year, month) + "円";
                    break;
                case 6:
                    label4.Text =course7.SchoolDays(year, month);
                    label6.Text =  course7.StartTime + "時";
                    label8.Text = course7.SchoolFee(year, month) + "円";
                    break;
                default:
                    label4.Text = "コースを選択してください";
                    label6.Text = "";
                    label8.Text = "";
                    break;
            }
        }
    }

    
}
