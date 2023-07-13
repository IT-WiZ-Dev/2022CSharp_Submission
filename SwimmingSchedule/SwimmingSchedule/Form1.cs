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
        //コースのデータの配列
        List<Course> data;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDownYear.Value = DateTime.Now.Year;
            numericUpDownMonth.Value = DateTime.Now.Month;
            data = new List<Course>();
            data.Add(new Course("ベビーコース",     1, 14, 1000));
            data.Add(new Course("幼児コース",       2, 10, 1000));
            data.Add(new Course("小学生コース",     3, 17,  800));
            data.Add(new Course("中学生コース",     4, 19,  800));
            data.Add(new Course("レディースコース", 5, 20, 1000));
            data.Add(new Course("一般コース",       6, 20, 1200));
            data.Add(new Course("家庭コース",       0, 10, 1500));

            foreach ( Course obj in data)
            {
                listBox.Items.Add( obj.CourseName );
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            int index = listBox.SelectedIndex;
            int year = (int)numericUpDownYear.Value;
            int month = (int)numericUpDownMonth.Value;

            switch (index)
            {
                case (0):
                    labelDays.Text = "授業日：" + data[0].SchoolDays(year, month);
                    labelStartTime.Text = "開始時間：" + data[0].StartTime + "時";
                    labelFee.Text = "授業料：" + data[0].SchoolFees(year, month) + "円";
                    break;

                case (1):
                    labelDays.Text = "授業日：" + data[1].SchoolDays(year, month);
                    labelStartTime.Text = "開始時間：" + data[1].StartTime + "時";
                    labelFee.Text = "授業料：" + data[1].SchoolFees(year, month) + "円";
                    break;

                case (2):
                    labelDays.Text = "授業日：" + data[2].SchoolDays(year, month);
                    labelStartTime.Text = "開始時間：" + data[2].StartTime + "時";
                    labelFee.Text = "授業料：" + data[2].SchoolFees(year, month) + "円";
                    break;

                case (3):
                    labelDays.Text = "授業日：" + data[3].SchoolDays(year, month);
                    labelStartTime.Text = "開始時間：" + data[3].StartTime + "時";
                    labelFee.Text = "授業料：" + data[3].SchoolFees(year, month) + "円";
                    break;

                case (4):
                    labelDays.Text = "授業日：" + data[4].SchoolDays(year, month);
                    labelStartTime.Text = "開始時間：" + data[4].StartTime + "時";
                    labelFee.Text = "授業料：" + data[4].SchoolFees(year, month) + "円";
                    break;

                case (5):
                    labelDays.Text = "授業日：" + data[5].SchoolDays(year, month);
                    labelStartTime.Text = "開始時間：" + data[5].StartTime + "時";
                    labelFee.Text = "授業料：" + data[5].SchoolFees(year, month) + "円";
                    break;

                case (6):
                    labelDays.Text = "授業日：" + data[6].SchoolDays(year, month);
                    labelStartTime.Text = "開始時間：" + data[6].StartTime + "時";
                    labelFee.Text = "授業料：" + data[6].SchoolFees(year, month) + "円";
                    break;

            }



        }

        
    }
}
