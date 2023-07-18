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
        private int alarmHour1 = 0;
        private int alarmMinute1 = 0;

        private bool alarmSetFlag2 = false;
        private int alarmHour2 = 0;
        private int alarmMinute2 = 0;

        private bool alarmSetFlag3 = false;
        private int alarmHour3 = 0;
        private int alarmMinute3 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            Form2 formSet = new Form2();
            if (formSet.ShowDialog() == DialogResult.OK)
            {
                alarmSetFlag1 = true;
                alarmHour1 = formSet.alarmHour;
                alarmMinute1 = formSet.alarmMinute;
                checkBox1.Text = alarmHour1.ToString("00") + "："
                                + alarmMinute1.ToString("00");
            }else
            {
                checkBox1.Checked = false;
            }
            formSet.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkBox2.Checked = true;
            Form2 formSet = new Form2();
            if (formSet.ShowDialog() == DialogResult.OK)
            {
                alarmSetFlag2 = true;
                alarmHour2 = formSet.alarmHour;
                alarmMinute2 = formSet.alarmMinute;
                checkBox2.Text = alarmHour2.ToString("00") + "："
                                + alarmMinute2.ToString("00");
            }
            else
            {
                checkBox2.Checked = false;
            }
            formSet.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkBox3.Checked = true;
            Form2 formSet = new Form2();
            if (formSet.ShowDialog() == DialogResult.OK)
            {
                alarmSetFlag3 = true;
                alarmHour3 = formSet.alarmHour;
                alarmMinute3 = formSet.alarmMinute;
                checkBox3.Text = alarmHour3.ToString("00") + "："
                                + alarmMinute3.ToString("00");
            }else
            {
                checkBox3.Checked = false;
            }
            formSet.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Text = DateTime.Now.ToLongTimeString();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            label1.Text = now.ToLongTimeString();

            if (alarmSetFlag1 == true )
            {
                if (alarmHour1 == now.Hour && alarmMinute1 == now.Minute)
                {
                    alarmSetFlag1 = false;
                    checkBox1.Checked = false;
                    MessageBox.Show("時間ですよ！", "アラーム",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkBox1.Text = "00：00";
                }
            }
             
            if(alarmSetFlag2 == true)
            {
                if (alarmHour2 == now.Hour && alarmMinute2 == now.Minute)
                {
                    alarmSetFlag2 = false;
                    checkBox2.Checked = false;
                    MessageBox.Show("時間ですよ！", "アラーム",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkBox2.Text = "00：00";
                }
            }

            if(alarmSetFlag3 == true)
            {
                if (alarmHour3 == now.Hour && alarmMinute3 == now.Minute)
                {
                    alarmSetFlag3 = false;
                    checkBox3.Checked = false;
                    MessageBox.Show("時間ですよ！", "アラーム",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkBox3.Text = "00：00";
                }
            }
        }
    }
}
