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

        internal bool[] alarmSetFlag = new bool[3];
        internal int[] alarmHour = new int[3];
        internal int[] alarmMinute = new int[3];
        internal int[] alarmSecond = new int[3];



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
            for (int i = 0; i < alarmSetFlag.Length; i++)
            {
                if (alarmSetFlag[i] == true)
                {
                    if (alarmHour[i] == now.Hour &&
                        alarmMinute[i] == now.Minute &&
                        alarmSecond[i] == now.Second)
                    {
                        alarmSetFlag[i] = false;
                        MessageBox.Show("時間ですよ！", "アラーム",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (i == 0)
                            checkBox1.Checked = false;
                        else
                        if (i == 1)
                            checkBox1.Checked = false;
                        else
                        if (i == 2)
                            checkBox1.Checked = false;



                    }
                }

            }
            
         


        }

        private void button1_Click(object sender, EventArgs e)
        {



            Form2 settingWindo = new Form2();
            settingWindo.ShowDialog();
            checkBox1.Checked = true;

            alarmSetFlag[0] = true;
            alarmHour[0]= settingWindo.alarmHour;
            alarmMinute[0] = settingWindo.alarmMinute;
            alarmSecond[0] = settingWindo.alarmSecond;
            label1.Text = alarmHour[0].ToString("00") + ":"
            + alarmMinute[0].ToString("00") + ":"
            + alarmSecond[0].ToString("00");


        }






        private void button2_Click(object sender, EventArgs e)
        {

            Form2 settingWindo = new Form2();
            settingWindo.ShowDialog();
            checkBox2.Checked = true;

            alarmSetFlag[1] = true;
            alarmHour[1] = settingWindo.alarmHour;
            alarmMinute [1]= settingWindo.alarmMinute;
            alarmSecond [1]= settingWindo.alarmSecond;
            label2.Text = alarmHour[1].ToString("00") + ":"
            + alarmMinute[1].ToString("00") + ":"
            + alarmSecond[1].ToString("00");

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form2 settingWindo = new Form2();
            settingWindo.ShowDialog();
            checkBox3.Checked = true;

            alarmSetFlag[2] = true;
            alarmHour[2] = settingWindo.alarmHour;
            alarmMinute[2] = settingWindo.alarmMinute;
            alarmSecond[2] = settingWindo.alarmSecond;
            label3.Text = alarmHour[2].ToString("00") + ":"
            + alarmMinute[2].ToString("00") + ":"
            + alarmSecond[2].ToString("00");

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          
        
        }
    }
}

