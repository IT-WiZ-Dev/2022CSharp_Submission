using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 第6章練習問題_MultiAlarm_
{
    public partial class FormMain : Form
    {
        private int alarmHour1 = 0; //アラーム時1
        private int alarmMinute1 = 0; //アラーム分1
        private int alarmHour2 = 0; //アラーム時2
        private int alarmMinute2 = 0; //アラーム分2
        private int alarmHour3 = 0; //アラーム時3
        private int alarmMinute3 = 0; //アラーム分3

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelTime.Text = DateTime.Now.ToLongTimeString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //現在日時の表示
            labelTime.Text = DateTime.Now.ToLongTimeString();

            //アラーム1設定中
            if (checkAlarm1.Checked == true)
            {
                //設定時刻になった
                if (alarmHour1 == DateTime.Now.Hour &&
                   alarmMinute1 == DateTime.Now.Minute)
                {
                    checkAlarm1.Checked = false;
                    MessageBox.Show("時間ですよ！", "アラーム1", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            //アラーム2設定中
            if (checkAlarm2.Checked == true)
            {
                //設定時刻になった
                if (alarmHour2 == DateTime.Now.Hour &&
                   alarmMinute2 == DateTime.Now.Minute)
                {
                    checkAlarm2.Checked = false;
                    MessageBox.Show("時間ですよ！", "アラーム", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            //アラーム3設定中
            if (checkAlarm3.Checked == true)
            {
                //設定時刻になった
                if (alarmHour3 == DateTime.Now.Hour &&
                   alarmMinute3 == DateTime.Now.Minute)
                {
                    checkAlarm3.Checked = false;
                    MessageBox.Show("時間ですよ！", "アラーム", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        //設定ボタン１
        private void buttonAlarmSet1_Click(object sender, EventArgs e)
        {
            FormSet formSet1 = new FormSet();

            formSet1.ShowDialog();
            //アラームの設定
            alarmHour1 = formSet1.AlarmHour;
            alarmMinute1 = formSet1.AlarmMinute;
            labelAlarmTime1.Text = alarmHour1.ToString("00") + ":" + alarmMinute1.ToString("00");
            checkAlarm1.Checked = true;


            

        }


        //設定ボタン2
        private void buttonAlarmSet2_Click(object sender, EventArgs e)
        {
            FormSet formSet2 = new FormSet();


            formSet2.ShowDialog();
                //アラームの設定
                alarmHour2 = formSet2.AlarmHour;
                alarmMinute2 = formSet2.AlarmMinute;
                labelAlarmTime2.Text = alarmHour2.ToString("00") + ":" + alarmMinute2.ToString("00");
                checkAlarm2.Checked = true;
            
        }

        //設定ボタン3
        private void buttonAlarmSet3_Click(object sender, EventArgs e)
        {
            FormSet formSet3 = new FormSet();

            formSet3.ShowDialog();
                //アラームの設定
                alarmHour3 = formSet3.AlarmHour;
                alarmMinute3 = formSet3.AlarmMinute;
                labelAlarmTime3.Text = alarmHour3.ToString("00") + ":" + alarmMinute3.ToString("00");
                checkAlarm3.Checked = true;
            
        }


    }
}

