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
    public partial class Form1 : Form
    {
        private int alarmHour1 = 0;     // アラーム時1
        private int alarmMinute1 = 0;   // アラーム分1
        private int alarmHour2 = 0;     // アラーム時2
        private int alarmMinute2 = 0;   // アラーム分2
        private int alarmHour3 = 0;     // アラーム時3
        private int alarmMinute3 = 0;   // アラーム分3

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // タイマーを起動し、現在時刻を表示
            timerAlarm.Start();
            labelNow.Text = DateTime.Now.ToLongTimeString();
        }

        private void timerAlarm_Tick(object sender, EventArgs e)
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

        // アラーム1の「設定」
        private void buttonSet1_Click(object sender, EventArgs e)
        {
            Form2 formSet1 = new Form2();
            if (formSet1.ShowDialog() == DialogResult.OK)
            {
                alarmHour1 = formSet1.alarmHour;
                alarmMinute1 = formSet1.alarmMinute;
                labelAlarm1.Text = alarmHour1.ToString("00") + ":" +
                    alarmMinute1.ToString("00");
                checkBox1.Checked = true;
            }
            formSet1.Dispose();
        }

        // アラーム2の「設定」
        private void buttonSet2_Click(object sender, EventArgs e)
        {
            Form2 formSet2 = new Form2();
            if (formSet2.ShowDialog() == DialogResult.OK)
            {
                alarmHour2 = formSet2.alarmHour;
                alarmMinute2 = formSet2.alarmMinute;
                labelAlarm2.Text = alarmHour2.ToString("00") + ":" +
                    alarmMinute2.ToString("00");
                checkBox2.Checked = true;
            }
            formSet2.Dispose();
        }

        // アラーム3の「設定」
        private void buttonSet3_Click(object sender, EventArgs e)
        {
            Form2 formSet3 = new Form2();
            if (formSet3.ShowDialog() == DialogResult.OK)
            {
                alarmHour3 = formSet3.alarmHour;
                alarmMinute3 = formSet3.alarmMinute;
                labelAlarm3.Text = alarmHour3.ToString("00") + ":" +
                    alarmMinute3.ToString("00");
                checkBox3.Checked = true;
            }
            formSet3.Dispose();
        }
    }
}
