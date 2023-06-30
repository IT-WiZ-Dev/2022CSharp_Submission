using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi__Alarm
{
    public partial class Form1 : Form
    {

        internal bool alarmSetFlag = false;
        internal int alarmHour = 0;
        internal int alarmMinute = 0;
        internal int alarmSecond = 0;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label4.Text = "";




            label1.Text = "00:00";
            label2.Text = "00:00";
            label3.Text = "00:00";
            checkBox1.Text = "";
            checkBox2.Text = "";
            checkBox3.Text = "";



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            label4.Text = now.ToLongTimeString();
            if (alarmSetFlag == true)
            {
                if (alarmHour == now.Hour &&
                    alarmMinute == now.Minute &&
                    alarmSecond == now.Second)
                {
                    alarmSetFlag = false;
                    MessageBox.Show("時間ですよ！", "アラーム",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);



                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {



            Form2 settingWindo = new Form2();
            settingWindo.ShowDialog();

            alarmSetFlag = true;
            alarmHour = settingWindo.alarmHour;
            alarmMinute = settingWindo.alarmMinute;
            alarmSecond = settingWindo.alarmSecond;
            label1.Text = alarmHour.ToString("00") + ":"
            + alarmMinute.ToString("00") + ":"
            + alarmSecond.ToString("00");


        }






        private void button2_Click(object sender, EventArgs e)
        {

            Form2 settingWindo = new Form2();
            settingWindo.ShowDialog();

            alarmSetFlag = true;
            alarmHour = settingWindo.alarmHour;
            alarmMinute = settingWindo.alarmMinute;
            alarmSecond = settingWindo.alarmSecond;
            label2.Text = alarmHour.ToString("00") + ":"
            + alarmMinute.ToString("00") + ":"
            + alarmSecond.ToString("00");

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form2 settingWindo = new Form2();
            settingWindo.ShowDialog();

            alarmSetFlag = true;
            alarmHour = settingWindo.alarmHour;
            alarmMinute = settingWindo.alarmMinute;
            alarmSecond = settingWindo.alarmSecond;
            label3.Text = alarmHour.ToString("00") + ":"
            + alarmMinute.ToString("00") + ":"
            + alarmSecond.ToString("00");

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }
    }
}

