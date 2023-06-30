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

        private bool alarmSetFlag = false;
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
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            label1.Text = now.ToLongTimeString();

            if (alarmHour == now.Hour &&
               alarmMinute == now.Minute &&
               alarmSecond == now.Second)
            {
                alarmSetFlag = false;
                MessageBox.Show("時間ですよ!", "アラーム",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 formSet = new Form2();
            if(formSet.ShowDialog() == DialogResult.OK)
            {
                alarmSetFlag = true;
                alarmHour = formSet.alarmHour;
                alarmMinute = formSet.alarmMinute;
                label2.Text = alarmHour.ToString("00") + ":" +
                              alarmMinute.ToString("00");
            }
            formSet.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 formSet = new Form2();
            if (formSet.ShowDialog() == DialogResult.OK)
            {
                alarmSetFlag = true;
                alarmHour = formSet.alarmHour;
                alarmMinute = formSet.alarmMinute;
                label3.Text = alarmHour.ToString("00") + ":" +
                              alarmMinute.ToString("00");
            }
            formSet.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 formSet = new Form2();
            if (formSet.ShowDialog() == DialogResult.OK)
            {
                alarmSetFlag = true;
                alarmHour = formSet.alarmHour;
                alarmMinute = formSet.alarmMinute;
                label4.Text = alarmHour.ToString("00") + ":" +
                              alarmMinute.ToString("00");
            }
            formSet.Dispose();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
