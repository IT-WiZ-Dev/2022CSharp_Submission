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

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            label1.Text = now.ToLongTimeString();

            if(alarmSetFlag1 == true)
            {
                if(alarmHour1 == now.Hour &&
                   alarmMinute1 == now.Minute)
                {
                    alarmSetFlag1 = false;
                    MessageBox.Show("時間ですよ！", "アラーム１", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkBox1.Checked = false;
                }
            }
            if (alarmSetFlag2 == true)
            {
                if (alarmHour2 == now.Hour &&
                   alarmMinute2 == now.Minute)
                {
                    alarmSetFlag2 = false;
                    MessageBox.Show("時間ですよ！", "アラーム２", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkBox2.Checked = false;
                }
            }
            if (alarmSetFlag3 == true)
            {
                if (alarmHour3 == now.Hour &&
                   alarmMinute3 == now.Minute)
                {
                    alarmSetFlag3 = false;
                    MessageBox.Show("時間ですよ！", "アラーム３", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkBox3.Checked = false;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 formSet = new Form2();
            if(formSet.ShowDialog() == DialogResult.OK)
            {
                alarmSetFlag1 = true;
                alarmHour1 = formSet.alarmHour;
                alarmMinute1 = formSet.alarmMinute;
                label2.Text = alarmHour1.ToString("00") + ":" + alarmMinute1.ToString("00");
                checkBox1.Checked = true;
            }
            formSet.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 formSet = new Form2();
            if (formSet.ShowDialog() == DialogResult.OK)
            {
                alarmSetFlag2 = true;
                alarmHour2 = formSet.alarmHour;
                alarmMinute2 = formSet.alarmMinute;
                label3.Text = alarmHour2.ToString("00") + ":" + alarmMinute2.ToString("00");
                checkBox2.Checked = true;
            }
            formSet.Dispose();
        } 

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 formSet = new Form2();
            if (formSet.ShowDialog() == DialogResult.OK)
            {
                alarmSetFlag3 = true;
                alarmHour3 = formSet.alarmHour;
                alarmMinute3 = formSet.alarmMinute;
                label4.Text = alarmHour3.ToString("00") + ":" + alarmMinute3.ToString("00"); 
                checkBox3.Checked = true;
            }
            formSet.Dispose();
        }
    }
}
