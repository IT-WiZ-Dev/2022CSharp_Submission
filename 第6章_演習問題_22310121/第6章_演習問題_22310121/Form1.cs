using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 第6章_演習問題_22310121
{
    public partial class Form1 : Form
    {
        private int alarmHour1 = 0;//アラーム時
        private int alarmMinute1 = 0;//アラーム分
        private int alarmHour2 = 0;//アラーム時
        private int alarmMinute2 = 0;//アラーム分
        private int alarmHour3 = 0;//アラーム時
        private int alarmMinute3 = 0;//アラーム分


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // タイマーの間隔(ミリ秒)
            Timer timer = new Timer();
            timer.Interval = 1000;

            // タイマーを開始する
            timer.Start();
            label1.Text = DateTime.Now.ToLongTimeString();

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 formSet = new Form3();
            formSet.ShowDialog();

            alarmHour1 = Form3.alarmHour;
            alarmMinute1 = Form3.alarmMinute;
            label2.Text = alarmHour1.ToString("00") + ":"
                        + alarmMinute1.ToString("00");
            checkBox1.Checked = true;

            formSet.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 formSet = new Form3();
            formSet.ShowDialog();

                alarmHour2 = Form3.alarmHour;
                alarmMinute2 = Form3.alarmMinute;
                label3.Text = alarmHour2.ToString("00") + ":"
                            + alarmMinute2.ToString("00");
                checkBox2.Checked = true;
            
            formSet.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 formSet = new Form3();
            formSet.ShowDialog();

                alarmHour3 = Form3.alarmHour;
                alarmMinute3 = Form3.alarmMinute;
                label4.Text = alarmHour3.ToString("00") + ":"
                            + alarmMinute3.ToString("00");
                checkBox3.Checked = true;
            
            formSet.Dispose();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();

            //1
            if (checkBox1.Checked == true)
            {
                if (alarmHour1 == DateTime.Now.Hour &&
                    alarmMinute1 == DateTime.Now.Minute)
                {
                    checkBox1.Checked = false;
                    MessageBox.Show("時間ですよ。", "アラーム1",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }


            //2
            if (checkBox1.Checked == true)
            {
                if (alarmHour1 == DateTime.Now.Hour &&
                    alarmMinute1 == DateTime.Now.Minute)
                {
                    checkBox1.Checked = false;
                    MessageBox.Show("時間ですよ。", "アラーム1",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }



            //3
            if (checkBox1.Checked == true)
            {
                if (alarmHour1 == DateTime.Now.Hour &&
                    alarmMinute1 == DateTime.Now.Minute)
                {
                    checkBox1.Checked = false;
                    MessageBox.Show("時間ですよ。", "アラーム1",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
