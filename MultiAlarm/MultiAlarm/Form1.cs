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

        private int alarmhour1 = 0;
        private int alarmhour2 = 0;
        private int alarmhour3 = 0;

        private int alarminute1 = 0;
        private int alarminute2 = 0;
        private int alarminute3 = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelTime.Text = now.ToLongTimeString();
            if (alarmSetFlag1 == true)
            {
                if (alarmhour1 == now.Hour &&
                    alarminute1 == now.Minute)
                {
                    alarmSetFlag1 = false;
                    MessageBox.Show("時間ですよ！","アラーム", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    checkBox1.Checked = false;
                }
            }
            if (alarmSetFlag2 == true)
            {
                if (alarmhour2 == now.Hour &&
                    alarminute2 == now.Minute)
                {
                    alarmSetFlag2 = false;
                    MessageBox.Show("時間ですよ！", "アラーム", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkBox2.Checked = false;
                }
            }
            if (alarmSetFlag3 == true)
            {
                if (alarmhour3 == now.Hour &&
                    alarminute3 == now.Minute)
                {
                    alarmSetFlag3 = false;
                    MessageBox.Show("時間ですよ！", "アラーム", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkBox3.Checked = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if(form2.ShowDialog() == DialogResult.OK)
            {
                alarmSetFlag1 = true;
                alarmhour1 = form2.alarmHour;
                alarminute1 = form2.alarmMinute;
               
                checkBox1.Text = alarmhour1.ToString("00") + "：" +
                                 alarminute1.ToString("00");
                checkBox1.Checked = true;
            }
            form2.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                alarmSetFlag2 = true;
                alarmhour2 = form2.alarmHour;
                alarminute2 = form2.alarmMinute;
               
                checkBox2.Text = alarmhour2.ToString("00") + "：" +
                                 alarminute2.ToString("00");
                checkBox2.Checked = true;
                form2.Dispose();
            }
   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                alarmSetFlag3 = true;
                alarmhour3 = form2.alarmHour;
                alarminute3 = form2.alarmMinute;
               
                checkBox3.Text = alarmhour3.ToString("00") + "：" +
                                 alarminute3.ToString("00");
                checkBox3.Checked = true;
            }
                
            form2.Dispose();
        }
    }
}
