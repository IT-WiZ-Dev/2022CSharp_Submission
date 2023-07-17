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

        // フィールド
        private int alarmHour1 = 0;     // アラーム時1
        private int alarmMinute1 = 0;   // アラーム分1
        private int alarmHour2 = 0;     // アラーム時2
        private int alarmMinute2 = 0;   // アラーム分2
        private int alarmHour3 = 0;     // アラーム時3
        private int alarmMinute3 = 0;   // アラーム分3


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

            // 現在時刻
            labelTime.Text = DateTime.Now.ToLongTimeString();

            // アラーム1
            if (checkBox1.Checked == true)
            {
                if (alarmHour1 == DateTime.Now.Hour &&
                    alarmMinute1 == DateTime.Now.Minute)
                {
                    checkBox1.Checked = false;
                    MessageBox.Show("時間です", "アラーム1",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            // アラーム2
            if (checkBox2.Checked == true)
            {
                if (alarmHour2 == DateTime.Now.Hour &&
                    alarmMinute2 == DateTime.Now.Minute)
                {
                    checkBox2.Checked = false;
                    MessageBox.Show("時間です", "アラーム2",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            // アラーム3
            if (checkBox3.Checked == true)
            {
                if (alarmHour3 == DateTime.Now.Hour &&
                    alarmMinute3 == DateTime.Now.Minute)
                {
                    checkBox3.Checked = false;
                    MessageBox.Show("時間です", "アラーム3",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
  
       }


       

       

        //設定1
        private void button1_Click_1(object sender, EventArgs e)
        {
            //「設定ダイアログ」の表示
            Form2 formSet1 = new Form2();

            if (formSet1.ShowDialog() == DialogResult.OK)
            {
                alarmHour1 = formSet1.AlarmHour;
                alarmMinute1 = formSet1.AlarmMinute;
                label1.Text = alarmHour1.ToString("00") + ":" +
                    alarmMinute1.ToString("00");
                checkBox1.Checked = true;
            }
            formSet1.Dispose();
        }

        //設定2
        private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 formSet2 = new Form2();

           
            if (formSet2.ShowDialog() == DialogResult.OK)
            {
                alarmHour2 = formSet2.AlarmHour;
                alarmMinute2 = formSet2.AlarmMinute;
                label2.Text = alarmHour2.ToString("00") + ":" +
                    alarmMinute2.ToString("00");
                checkBox2.Checked = true;
            }
            formSet2.Dispose();
        }
        //設定3
        private void button3_Click_1(object sender, EventArgs e)
        {
            
            Form2 formSet3 = new Form2();

            if (formSet3.ShowDialog() == DialogResult.OK)
            {
                alarmHour3 = formSet3.AlarmHour;
                alarmMinute3 = formSet3.AlarmMinute;
                label3.Text = alarmHour3.ToString("00") + ":" +
                    alarmMinute3.ToString("00");
                checkBox3.Checked = true;
            }
            formSet3.Dispose();
        }
    }

}
