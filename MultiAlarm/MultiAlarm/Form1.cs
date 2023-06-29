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
        int alarmhour1, alarmminute1, alarmhour2, alarmminute2, alarmhour3, alarmminute3;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label4.Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if(form2.ShowDialog() == DialogResult.OK)
            {
                label1.Text = (form2.alarmhour + ":" + form2.alarmminute);
                checkBox1.Checked = true;
                alarmhour1 = form2.alarmhour;
                alarmminute1 = form2.alarmminute;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                label2.Text = (form2.alarmhour + ":" + form2.alarmminute);
                checkBox2.Checked = true;
                alarmhour2 = form2.alarmhour;
                alarmhour2 = form2.alarmminute;
            }
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                label3.Text = (form2.alarmhour + ":" + form2.alarmminute);
                checkBox3.Checked = true;
                alarmhour3 = form2.alarmhour;
                alarmminute3 = form2.alarmminute;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            label4.Text = now.ToLongTimeString();
            if(alarmhour1 == now.Hour &&
                alarmminute1 == now.Minute &&
                1 == now.Second)
            {
                MessageBox.Show("時間ですよ!");
                checkBox1.Checked = false;

            }
            if (alarmhour2 == now.Hour &&
                alarmminute2 == now.Minute &&
                1 == now.Second)
            {
                MessageBox.Show("時間ですよ!");
                checkBox2.Checked = false;
            }
            if (alarmhour3 == now.Hour &&
                alarmminute3 == now.Minute &&
                0 == now.Second)
            {
                MessageBox.Show("時間ですよ!");
                checkBox3.Checked = false;
            }
        }
    }
}
