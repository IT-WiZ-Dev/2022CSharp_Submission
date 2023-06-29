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
        private bool alarmSetFlg1 = false;
        private bool alarmSetFlg2 = false;
        private bool alarmSetFlg3 = false;
        private int alarmHour1 = 0;
        private int alarmHour2 = 0;
        private int alarmHour3 = 0;
        private int alarmMinute1 = 0;
        private int alarmMinute2 = 0;
        private int alarmMinute3 = 0;

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
            DateTime now = DateTime.Now;
            labelTime.Text = now.ToLongTimeString();

            if(alarmSetFlg1 == true)
            {
                if(alarmHour1 == now.Hour && alarmMinute1 == now.Minute)
                {
                    alarmSetFlg1 = false;
                    checkBoxStatus1.Checked = false;
                    MessageBox.Show("時間ですよ！", "アラーム2", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkBoxStatus1.Text = "00:00";
                }
            }

            if (alarmSetFlg2 == true)
            {
                if (alarmHour2 == now.Hour && alarmMinute2 == now.Minute)
                {
                    alarmSetFlg2 = false;
                    checkBoxStatus2.Checked = false;
                    MessageBox.Show("時間ですよ！", "アラーム2", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkBoxStatus2.Text = "00:00";
                }
            }

            if (alarmSetFlg3 == true)
            {
                if (alarmHour3 == now.Hour && alarmMinute3 == now.Minute)
                {
                    alarmSetFlg3 = false;
                    checkBoxStatus3.Checked = false;
                    MessageBox.Show("時間ですよ！", "アラーム2", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkBoxStatus3.Text = "00:00";
                }
            }
        }

        private void buttonSet1_Click(object sender, EventArgs e)
        {
            FormSet formSet = new FormSet();
            if(formSet.ShowDialog() == DialogResult.OK)
            {
                alarmSetFlg1 = true;
                alarmHour1 = formSet.alarmHour;
                alarmMinute1 = formSet.alarmMinute;
                checkBoxStatus1.Text = alarmHour1.ToString("00") + ":" + alarmMinute1.ToString("00");
                checkBoxStatus1.Checked = true;
            }
            formSet.Dispose();
        }

        private void buttonSet2_Click(object sender, EventArgs e)
        {
            FormSet formSet = new FormSet();
            if (formSet.ShowDialog() == DialogResult.OK)
            {
                alarmSetFlg2 = true;
                alarmHour2 = formSet.alarmHour;
                alarmMinute2 = formSet.alarmMinute;
                checkBoxStatus2.Text = alarmHour2.ToString("00") + ":" + alarmMinute2.ToString("00");
                checkBoxStatus2.Checked = true;

            }
            formSet.Dispose();
        }

        private void buttonSet3_Click(object sender, EventArgs e)
        {
            FormSet formSet = new FormSet();
            if (formSet.ShowDialog() == DialogResult.OK)
            {
                alarmSetFlg3 = true;
                alarmHour3 = formSet.alarmHour;
                alarmMinute3 = formSet.alarmMinute;
                checkBoxStatus3.Text = alarmHour3.ToString("00") + ":" + alarmMinute3.ToString("00");
                checkBoxStatus3.Checked = true;
            }
            formSet.Dispose();
        }
    }
}
