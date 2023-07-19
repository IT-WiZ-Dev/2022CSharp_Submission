using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 第7章練習問題_SwimmingSchedule_
{
    public partial class FormMain : Form
    {

        private Course course1, course2, course3, course4, course5, course6, course7;


        public FormMain()
        {
            InitializeComponent();
        }



        private void FormMain_Load(object sender, EventArgs e)
        {
            course1 = /*data.Add(*/new Course("ベビーコース", 1, 14, 1000)/*)*/;
            course2 = /*data.Add(*/new Course("幼児コース", 2, 10, 1000)/*)*/;
            course3 = /*data.Add(*/new Course("小学生コース", 3, 17, 800)/*)*/;
            course4 = /*data.Add(*/new Course("中学生コース", 4, 19, 800)/*)*/;
            course5 = /*data.Add(*/new Course("レディースコース", 5, 20, 1000)/*)*/;
            course6 = /*data.Add(*/new Course("一般コース", 6, 20, 1200)/*)*/;
            course7 = /*data.Add(*/new Course("家族コース", 0, 10, 1500)/*)*/;

            

            // リストボックスに項目を追加する
            listBoxCourseSelect.Items.Add(course1.CourseName);
            listBoxCourseSelect.Items.Add(course2.CourseName);
            listBoxCourseSelect.Items.Add(course3.CourseName);
            listBoxCourseSelect.Items.Add(course4.CourseName);
            listBoxCourseSelect.Items.Add(course5.CourseName);
            listBoxCourseSelect.Items.Add(course6.CourseName);
            listBoxCourseSelect.Items.Add(course7.CourseName);

            //起動時にニューメリックに現在の年月を入れる
            numericUpDownYear.Value = DateTime.Now.Year;
            numericUpDownMonth.Value = DateTime.Now.Month;

        }



        //実行ボタンを押したとき
        private void buttonjikkou_Click(object sender, EventArgs e)
        {

            //年月を整数値に変換する
            int n, year, month;
            n = listBoxCourseSelect.SelectedIndex;
            year = (int)numericUpDownYear.Value;
            month = (int)numericUpDownMonth.Value;

            //授業日、開始時刻、授業料を表示する
            switch (n)
            {
                case 0: //ベビーコースを選んだ時
                    labelday.Text = course1.SDays(year, month);  //day = 1(月曜日)
                    labelstarttime.Text = course1.StartTime + "時";  // 14
                    labelprice.Text = course1.SPrice(year, month) + "円";  // 1000
                    break;

                case 1:　//幼児コースを選んだ時
                    labelday.Text = course2.SDays(year, month);  //day = 2(火曜日)
                    labelstarttime.Text = course2.StartTime + "時";  // 10
                    labelprice.Text = course2.SPrice(year, month) + "円";  // 1000
                    break;

                case 2:  //小学生コースを選んだ時
                    labelday.Text = course3.SDays(year, month);  //day = 3(水曜日)
                    labelstarttime.Text = course3.StartTime + "時";  // 17
                    labelprice.Text = course3.SPrice(year, month) + "円";  // 800
                    break;

                case 3:  //中学生コースを選んだ時
                    labelday.Text = course4.SDays(year, month);  //day = 4(木曜日)
                    labelstarttime.Text = course4.StartTime + "時";  // 19
                    labelprice.Text = course4.SPrice(year, month) + "円";  // 800
                    break;

                case 4:  //レディースコースを選んだ時
                    labelday.Text = course5.SDays(year, month);  //day = 5(金曜日)
                    labelstarttime.Text = course5.StartTime + "時";  // 20
                    labelprice.Text = course5.SPrice(year, month) + "円";  // 1000
                    break;

                case 5:  //一般コースを選んだ時
                    labelday.Text = course6.SDays(year, month);  //day = 6(土曜日)
                    labelstarttime.Text = course6.StartTime + "時";  // 20
                    labelprice.Text = course6.SPrice(year, month) + "円";  // 1200
                    break;

                case 6:  //家族コースを選んだ時時
                    labelday.Text = course7.SDays(year, month);  //day = 0(日曜日)
                    labelstarttime.Text = course7.StartTime + "時";  // 10
                    labelprice.Text = course7.SPrice(year, month) + "円";  // 1500
                    break;

                default:
                    labelday.Text = "コースを選択してください";
                    labelstarttime.Text = "";
                    labelprice.Text = "";
                    break;
            }





            //曜日の比較
            //data[index].day == (int)t.DayOfWeek;
        }
    }
}
