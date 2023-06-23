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
        private int alarmHour1 = 0;
        private int alarmHour2 = 0;
        private int alarmHour3 = 0;
        private int alarmMinute1 = 0;
        private int alarmMinute2 = 0;
        private int alarmMinute3 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //現在日時の表示
            DateTime now = DateTime.Now;
            label1.Text = now.ToLongTimeString();
            //アラーム設定中
            if (alarmSetFlag1 == true && checkBox1.Checked == true) 
            {
                //設定時刻になった
                if(alarmHour1 == now.Hour && alarmMinute1 == now.Minute)
                {
                    alarmSetFlag1 = false;
                    MessageBox.Show("時間ですよ！", "アラーム2",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkBox1.Checked = false;
                }
            }else if (alarmSetFlag2 == true && checkBox2.Checked == true) 
            {
                //設定時刻になった
                if (alarmHour2 == now.Hour && alarmMinute2 == now.Minute)
                {
                    alarmSetFlag2 = false;
                    MessageBox.Show("時間ですよ！", "アラーム2",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkBox2.Checked = false;
                }
            }else if (alarmSetFlag3 == true && checkBox3.Checked == true) 
            {
                //設定時刻になった
                if (alarmHour3 == now.Hour && alarmMinute3 == now.Minute)
                {
                    alarmSetFlag3 = false;
                    MessageBox.Show("時間ですよ！", "アラーム2",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkBox3.Checked = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //設定ダイアログボックスの表示
            Form2 formSet = new Form2();
            if(formSet.ShowDialog() == DialogResult.OK)
            {
                //アラームの設定
                alarmSetFlag1 = true;
                alarmHour1 = formSet.alarmHour;
                alarmMinute1 = formSet.alarmMinute;
                checkBox1.Text = alarmHour1.ToString("00") + ":"
                                 + alarmMinute1.ToString("00");
                checkBox1.Checked = true;
            }
            formSet.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //設定ダイアログボックスの表示
            Form2 formSet = new Form2();
            if (formSet.ShowDialog() == DialogResult.OK)
            {
                //アラームの設定
                alarmSetFlag2 = true;
                alarmHour2 = formSet.alarmHour;
                alarmMinute2 = formSet.alarmMinute;
                checkBox2.Text = alarmHour2.ToString("00") + ":"
                                 + alarmMinute2.ToString("00");
                checkBox2.Checked = true;
            }
            formSet.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //設定ダイアログボックスの表示
            Form2 formSet = new Form2();
            if (formSet.ShowDialog() == DialogResult.OK)
            {
                //アラームの設定
                alarmSetFlag3 = true;
                alarmHour3 = formSet.alarmHour;
                alarmMinute3 = formSet.alarmMinute;
                checkBox3.Text = alarmHour3.ToString("00") + ":"
                                 + alarmMinute3.ToString("00");
                checkBox3.Checked = true;
            }
            formSet.Dispose();
        }
    }
}
