using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MultiAlarm
{
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();
        private int hour1 = 0;
        private int minute1 = 0;
        private int hour2 = 0;
        private int minute2 = 0;
        private int hour3 = 0;
        private int minute3 = 0;
        private int second1 = 0;
        private int second2 = 0;
        private int second3 = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();



        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (form2.ShowDialog() == DialogResult.OK)
            {
                hour1 = form2.alarmhour;
                minute1 = form2.alarmminute;


                label2.Text = hour1.ToString("00") + ":" + minute1.ToString("00");
                checkBox1.Checked = true;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (form2.ShowDialog() == DialogResult.OK)
            {
                hour2 = form2.alarmhour;
                minute2 = form2.alarmminute;


                label3.Text = hour2.ToString("00") + ":" + minute2.ToString("00");
                checkBox2.Checked = true;

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (form2.ShowDialog() == DialogResult.OK)
            {
                hour3 = form2.alarmhour;
                minute3 = form2.alarmminute;

                label4.Text = hour3.ToString("00") + ":" + minute3.ToString("00");
                checkBox3.Checked = true;

            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("T");


            if (checkBox1.Checked == true)
            {
                if (hour1 == DateTime.Now.Hour && minute1 == DateTime.Now.Minute)
                {
                    checkBox1.Checked = false;
                    MessageBox.Show("時間","Alarm1");
                }
            }
        }


    }
}
