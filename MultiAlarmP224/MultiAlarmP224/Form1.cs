using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiAlarmP224
{
    public partial class Form1 : Form
    {
        Form2 f2;
        bool alarmSetFlan1 = false;
        bool alarmSetFlan2 = false;
        bool alarmSetFlan3 = false;
        int alarmHour1 = 0;
        int alarmMinute1 = 0;
        int alarmHour2 = 0;
        int alarmMinute2 = 0;
        int alarmHour3 = 0;
        int alarmMinute3 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            label1.Text = now.ToLongTimeString();
            if (alarmSetFlan1 == true)
            {
                if (alarmHour1 == now.Hour && alarmMinute1 == now.Minute)
                {
                    alarmSetFlan1 = false;
                    MessageBox.Show("時間ですよ！", "アラーム1", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkBox1.Checked = false;
                    label2.Text = "00:00";
                }
            }
            if (alarmSetFlan2 == true)
            {
                if (alarmHour2 == now.Hour && alarmMinute2 == now.Minute)
                {
                    alarmSetFlan2 = false;
                    MessageBox.Show("時間ですよ！", "アラーム2", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkBox2.Checked = false;
                    label5.Text = "00:00";
                }
            }
            if (alarmSetFlan3 == true)
            {
                if (alarmHour3 == now.Hour && alarmMinute3 == now.Minute)
                {
                    alarmSetFlan3 = false;
                    MessageBox.Show("時間ですよ！", "アラーム3", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkBox3.Checked = false;
                    label6.Text = "00:00";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f2 = new Form2();
            if (f2.ShowDialog() == DialogResult.OK)
            {
                alarmSetFlan1 = true;
                alarmHour1 = f2.alarmHour;
                alarmMinute1 = f2.alarmMinute;
                label2.Text = alarmHour1.ToString("00") +" : "+ alarmMinute1.ToString("00");
                checkBox1.Checked = true;
            }
            f2.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            f2 = new Form2();
            if (f2.ShowDialog() == DialogResult.OK)
            {
                alarmSetFlan2 = true;
                alarmHour2 = f2.alarmHour;
                alarmMinute2 = f2.alarmMinute;
                label5.Text = alarmHour2.ToString("00") + " : " + alarmMinute2.ToString("00");
                checkBox2.Checked = true;
            }
            f2.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            f2 = new Form2();
            if (f2.ShowDialog() == DialogResult.OK)
            {
                alarmSetFlan3 = true;
                alarmHour3 = f2.alarmHour;
                alarmMinute3 = f2.alarmMinute;
                label6.Text = alarmHour3.ToString("00") + " : " + alarmMinute3.ToString("00");
                checkBox3.Checked = true;
            }
            f2.Dispose();
        }
    }
}
