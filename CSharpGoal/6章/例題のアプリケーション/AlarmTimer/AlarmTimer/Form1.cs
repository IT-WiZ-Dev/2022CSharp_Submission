using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmTimer
{
    public partial class FormMain : Form
    {
        private bool alarmSetFlag = false;  // アラームセット中フラグ
        private int alarmHour = 0;          // アラーム時
        private int alarmMinute = 0;        // アラーム分
        private int alarmSecond = 0;        // アラーム秒

        public FormMain()
        {
            InitializeComponent();
        }

        //「メインフォーム」ロードのイベントハンドラ
        private void FormMain_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelStatus.Text = "";
            labelDate.Text = DateTime.Today.ToString("yyyy年MM月dd日(ddd)");
            labelTime.Text = DateTime.Now.ToLongTimeString();
        }

        //「タイマー」Tickのイベントハンドラ
        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelTime.Text = now.ToLongTimeString();
            labelDate.Text = DateTime.Today.ToString("yyyy年MM月dd日(ddd)");

            // アラーム設定中
            if (alarmSetFlag == true)
            {
                // 設定時刻になった
                if (alarmHour == now.Hour &&
                    alarmMinute == now.Minute &&
                    alarmSecond == now.Second)
                {
                    alarmSetFlag = false;
                    MessageBox.Show("時間ですよ！", "アラーム",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    labelStatus.Text = "";
                }
            }
        }

        //「設定ボタン」クリックのイベントハンドラ
        private void ButtonSet_Click(object sender, EventArgs e)
        {
            // 設定ダイアログボックスの表示
            FormSet formSet = new FormSet();
            if (formSet.ShowDialog() == DialogResult.OK)
            {
                // アラームの設定
                alarmSetFlag = true;
                alarmHour = formSet.alarmHour;
                alarmMinute = formSet.alarmMinute;
                alarmSecond = formSet.alarmSecond;
                labelStatus.Text = "♪ " + alarmHour.ToString("00") + ":"
                                        + alarmMinute.ToString("00") + ":"
                                        + alarmSecond.ToString("00");
            }
            formSet.Dispose();
        }

        //「リセットボタン」クリックのイベントハンドラ
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            alarmSetFlag = false;
            labelStatus.Text = "";
        }
    }
}
