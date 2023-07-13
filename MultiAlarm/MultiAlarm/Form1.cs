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
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelTime.Text = DateTime.Now.ToLongTimeString();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToLongTimeString();



            //アラーム1設定中
            if (checkBox1.Checked == true)
            {
                //設定時刻になった
                if (alarmHour1 == DateTime.Now.Hour &&
                    alarmMinute1 == DateTime.Now.Minute)
                {
                    checkBox1.Checked = false;
                    MessageBox.Show("時間です！", "アラーム１",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //アラーム2設定中
            if (checkBox2.Checked == true)
            {
                //設定時刻になった
                if (alarmHour2 == DateTime.Now.Hour &&
                    alarmMinute2 == DateTime.Now.Minute)
                {
                    checkBox2.Checked = false;
                    MessageBox.Show("時間です！", "アラーム２",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //アラーム3設定中
            if (checkBox3.Checked == true)
            {
                //設定時刻になった
                if (alarmHour3 == DateTime.Now.Hour &&
                    alarmMinute3 == DateTime.Now.Minute)
                {
                    checkBox3.Checked = false;
                    MessageBox.Show("時間です！", "アラーム３",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            if (form3.ShowDialog() == DialogResult.OK)
            {
                alarmHour1 = form3.alarmHour;
                alarmMinute1 = form3.alarmMinute;
                checkBox1.Checked = true;
            }
            form3.Dispose();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form2 = new Form3();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                alarmHour2 = form2.alarmHour;
                alarmMinute2 = form2.alarmMinute;
                checkBox2.Checked = true;
            }
            form2.Dispose();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            if (form3.ShowDialog() == DialogResult.OK)
            {
                alarmHour3 = form3.alarmHour;
                alarmMinute3 = form3.alarmMinute;
                checkBox3.Checked = true;
            }
            form3.Dispose();
        }




    }
}