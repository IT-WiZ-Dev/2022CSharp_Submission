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
        private int alm1Hour = 0;
        private int alm2Hour = 0;
        private int alm3Hour = 0;
        private int alm1Minute = 0;
        private int alm2Minute = 0;
        private int alm3Minute = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            if (checkBox1.Checked == true &&
               alm1Hour == DateTime.Now.Hour &&
               alm1Minute == DateTime.Now.Minute) 
            {
                checkBox1.Checked = false;
                MessageBox.Show("時間ですよ！", "アラーム", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(checkBox2.Checked == true &&
                alm2Hour == DateTime.Now.Hour &&
                alm2Minute == DateTime.Now.Minute)
            {
                checkBox2.Checked = false;
                MessageBox.Show("時間ですよ！", "アラーム", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (checkBox3.Checked == true &&
                alm3Hour == DateTime.Now.Hour &&
                alm3Minute == DateTime.Now.Minute)
            {
                checkBox3.Checked = false;
                MessageBox.Show("時間ですよ！", "アラーム", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 tim1 = new Form2();
            if (tim1.ShowDialog() == DialogResult.OK)
            {
                checkBox1.Checked = true;
                alm1Hour = tim1.alarmHour;
                alm1Minute = tim1.alarmMinute;
                labeltim1.Text = alm1Hour.ToString("00") + ":" + alm1Minute.ToString("00");
            }
            tim1.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 tim2 = new Form2();
            tim2.ShowDialog();
            if (tim2.ShowDialog() == DialogResult.OK)
            {
                checkBox2.Checked = true;
                alm2Hour = tim2.alarmHour;
                alm2Minute = tim2.alarmMinute;
                labeltim2.Text = alm1Hour.ToString("00") + ":"+ alm1Minute.ToString("00");
            }
            tim2.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 tim3 = new Form2();
            tim3.ShowDialog();
            if (tim3.ShowDialog() == DialogResult.OK)
            {
                checkBox3.Checked = true;
                alm3Hour = tim3.alarmHour;
                alm3Minute = tim3.alarmMinute;
                labeltim3.Text = alm1Hour.ToString("00") + ":" + alm1Minute.ToString("00");
            }
            tim3.Dispose();
        }
    }
}
