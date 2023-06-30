// Form1.cs
using System;
using System.Windows.Forms;

namespace MultiAlarm
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
            label0.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            label0.Text = now.ToLongTimeString();
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
                        else if (i == 1)
                            checkBox2.Checked = false;
                        else if (i == 2)
                            checkBox3.Checked = false;

                    }
                }
            }
            /*
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
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 settingWindo = new Form2();
            settingWindo.ShowDialog();
            checkBox1.Checked = true;

            alarmSetFlag[0] = true;
            alarmHour[0] = settingWindo.alarmHour;
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
            alarmMinute[1] = settingWindo.alarmMinute;
            alarmSecond[1] = settingWindo.alarmSecond;
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
    }
}

