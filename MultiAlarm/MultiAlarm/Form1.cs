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
        private bool alarmSetFlag1 = false;
        private bool alarmSetFlag2 = false;
        private bool alarmSetFlag3 = false;
        private int alarmHour = 0;
        private int alarmMinute = 0;
        private int alarmSecond = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelTime.Text = DateTime.Now.ToLongTimeString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelTime.Text = now.ToLongTimeString();

            if(alarmSetFlag1 == true)
            {
                checkTime1.Checked = true;
                if(alarmHour == now.Hour &&
                   alarmMinute == now.Minute &&
                   alarmSecond == now.Second)
                {
                    alarmSetFlag1 = false;
                    MessageBox.Show("時間ですよ！", "アラーム",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkTime1.Checked = false;
                }
            }
            if (alarmSetFlag2 == true)
            {
                checkTime2.Checked = true;
                if (alarmHour == now.Hour &&
                   alarmMinute == now.Minute &&
                   alarmSecond == now.Second)
                {
                    alarmSetFlag2 = false;
                    MessageBox.Show("時間ですよ！", "アラーム",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkTime2.Checked = false;
                }
            }
            if (alarmSetFlag3 == true)
            {
                checkTime3.Checked = true;
                if (alarmHour == now.Hour &&
                   alarmMinute == now.Minute &&
                   alarmSecond == now.Second)
                {
                    alarmSetFlag3 = false;
                    MessageBox.Show("時間ですよ！", "アラーム",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkTime3.Checked = false;
                }
            }

        }

        private void buttonset1_Click(object sender, EventArgs e)
        {
            Form2 formSet = new Form2();
            formSet.ShowDialog();
            formSet.Dispose();

            alarmSetFlag1 = true;
            alarmSetFlag3 = true;
            alarmSetFlag2 = true;
            alarmHour = formSet.alarmHour;
            alarmMinute = formSet.alarmMinute;
            alarmSecond = formSet.alarmSecond;
            checkTime1.Text = alarmHour.ToString("00") + ":"
                                + alarmMinute.ToString("00");
        }

        private void buttonset2_Click(object sender, EventArgs e)
        {
            Form2 formSet = new Form2();
            formSet.ShowDialog();
            formSet.Dispose();

            alarmSetFlag1 = true;
            alarmSetFlag2 = true;
            alarmSetFlag3 = true;
            alarmHour = formSet.alarmHour;
            alarmMinute = formSet.alarmMinute;
            alarmSecond = formSet.alarmSecond;
            checkTime1.Text = alarmHour.ToString("00") + ":"
                                + alarmMinute.ToString("00");
        }

        private void buttonset3_Click(object sender, EventArgs e)
        {
            Form2 formSet = new Form2();
            formSet.ShowDialog();
            formSet.Dispose();

            alarmSetFlag1 = true;
            alarmSetFlag2 = true;
            alarmSetFlag3 = true;
            alarmHour = formSet.alarmHour;
            alarmMinute = formSet.alarmMinute;
            alarmSecond = formSet.alarmSecond;
            checkTime1.Text = alarmHour.ToString("00") + ":"
                                + alarmMinute.ToString("00");
        }
    }
}
