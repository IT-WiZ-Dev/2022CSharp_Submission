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
        private int alarmHour1 = 0;     
        private int alarmMinute1 = 0;   
        private int alarmHour2 = 0;     
        private int alarmMinute2 = 0;   
        private int alarmHour3 = 0;     
        private int alarmMinute3 = 0;   

        public Form1()
        {
            InitializeComponent();
            InitializeTimer();
        }

       
        private void Form1_Load_1(object sender, EventArgs e)
        {
            labelNow.Text = DateTime.Now.ToLongTimeString();
        }
        private void InitializeTimer()
        {
           
            Timer timerAlarm = new Timer();
            timerAlarm.Interval = 1000;
            timerAlarm.Tick += TimerAlarm_Tick;
            timerAlarm.Start();
        }
        private void TimerAlarm_Tick(object sender, EventArgs e)
        {
            labelNow.Text = DateTime.Now.ToLongTimeString();

        }
        private void timerAlarm_Tick(object sender, EventArgs e)
        {

            labelNow.Text = DateTime.Now.ToLongTimeString();


            if (checkBox1.Checked == true)
            {
                if (alarmHour1 == DateTime.Now.Hour &&
                    alarmMinute1 == DateTime.Now.Minute)
                {
                    MessageBox.Show("時間ですよ！", "アラーム1",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

     
            if (checkBox2.Checked == true)
            {
                if (alarmHour2 == DateTime.Now.Hour &&
                    alarmMinute2 == DateTime.Now.Minute)
                {
                    MessageBox.Show("時間ですよ！", "アラーム2",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

 
            if (checkBox3.Checked == true)
            {
                if (alarmHour3 == DateTime.Now.Hour &&
                    alarmMinute3 == DateTime.Now.Minute)
                {
                    MessageBox.Show("時間ですよ！", "アラーム3",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        
    }
}
