using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiAlarm
{
    public partial class FormMain : Form
    {
        // フィールド
        private int alarmHour1 = 0;     // アラーム時1
        private int alarmMinute1 = 0;   // アラーム分1
        private int alarmHour2 = 0;     // アラーム時2
        private int alarmMinute2 = 0;   // アラーム分2
        private int alarmHour3 = 0;     // アラーム時3
        private int alarmMinute3 = 0;   // アラーム分3

        public FormMain()
        {
            InitializeComponent();
        }

        //「メインフォーム」ロードのイベントハンドラ
        private void FormMain_Load(object sender, EventArgs e)
        {
            // タイマーを起動し、現在時刻を表示
            timerAlarm.Start();
            labelNow.Text = DateTime.Now.ToLongTimeString();
        }

        //「タイマー」Tickのイベントハンドラ
        private void TimerAlarm_Tick(object sender, EventArgs e)
        {
            // 現在時刻の表示
            labelNow.Text = DateTime.Now.ToLongTimeString();

            // アラーム1の処理
            if (checkBox1.Checked == true)
            {
                if (alarmHour1 == DateTime.Now.Hour &&
                    alarmMinute1 == DateTime.Now.Minute)
                {
                    checkBox1.Checked = false;
                    MessageBox.Show("時間ですよ！", "アラーム1",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            // アラーム2の処理
            if (checkBox2.Checked == true)
            {
                if (alarmHour2 == DateTime.Now.Hour &&
                    alarmMinute2 == DateTime.Now.Minute)
                {
                    checkBox2.Checked = false;
                    MessageBox.Show("時間ですよ！", "アラーム2",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            // アラーム3の処理
            if (checkBox3.Checked == true)
            {
                if (alarmHour3 == DateTime.Now.Hour &&
                    alarmMinute3 == DateTime.Now.Minute)
                {
                    checkBox3.Checked = false;
                    MessageBox.Show("時間ですよ！", "アラーム3",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //「設定ボタン1」クリックのイベントハンドラ
        private void ButtonSet1_Click(object sender, EventArgs e)
        {
            //「設定ダイアログ」の表示
            FormSet formSet1 = new FormSet();

            if (formSet1.ShowDialog() == DialogResult.OK)
            {
                alarmHour1 = formSet1.AlarmHour;
                alarmMinute1 = formSet1.AlarmMinute;
                labelAlarm1.Text = alarmHour1.ToString("00") + ":" +
                    alarmMinute1.ToString("00");
                checkBox1.Checked = true;
            }
            formSet1.Dispose();
        }

        //「設定ボタン2」クリックのイベントハンドラ
        private void ButtonSet2_Click(object sender, EventArgs e)
        {
            FormSet formSet2 = new FormSet();

            //「設定ダイアログ」の表示
            if (formSet2.ShowDialog() == DialogResult.OK)
            {
                alarmHour2 = formSet2.AlarmHour;
                alarmMinute2 = formSet2.AlarmMinute;
                labelAlarm2.Text = alarmHour2.ToString("00") + ":" +
                    alarmMinute2.ToString("00");
                checkBox2.Checked = true;
            }
            formSet2.Dispose();
        }

        private void ButtonSet3_Click(object sender, EventArgs e)
        {
            //「設定ダイアログ」の表示
            FormSet formSet3 = new FormSet();

            if (formSet3.ShowDialog() == DialogResult.OK)
            {
                alarmHour3 = formSet3.AlarmHour;
                alarmMinute3 = formSet3.AlarmMinute;
                labelAlarm3.Text = alarmHour3.ToString("00") + ":" +
                    alarmMinute3.ToString("00");
                checkBox3.Checked = true;
            }
            formSet3.Dispose();
        }
    }
}
