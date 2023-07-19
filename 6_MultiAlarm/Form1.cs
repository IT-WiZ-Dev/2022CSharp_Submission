using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_MultiAlarm
{
    public partial class Form1 : Form
    {
        private bool[] alarmSetFlag = { false, false, false };
        private int[] alarmHour = { 0, 0, 0 };
        private int[] alarmMinute = { 0, 0, 0 };
        private int[] alarmSecond = { 0, 0, 0 };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 0;
            FormSet formSet = new FormSet();
            if(formSet.ShowDialog() == DialogResult.OK)
            {
                alarmSetFlag[num] = true;
                alarmHour[num] = formSet.alarmHour;
                alarmMinute[num] = formSet.alarmMinute;
                checkBox1.Text = alarmHour[num] + ":" + alarmMinute[num];
            }
            formSet.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            label1.Text = now.ToString("T");
            for(int i = 0; i < 3; i++)
            {
                if (alarmSetFlag[i])
                {
                    if (alarmHour[i] == now.Hour &&
                        alarmMinute[i] == now.Minute &&
                        alarmSecond[i] == now.Second)
                    {
                        alarmSetFlag[i] = false;
                        MessageBox.Show("時間ですよ！", $"アラーム{i+1}", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        switch (i)
                        {
                            case 1:
                                checkBox1.Checked = false;
                                break;
                            case 2:
                                checkBox2.Checked = false;
                                break;
                            case 3:
                                checkBox3.Checked = false;
                                break;
                        }
                    }
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num = 1;
            FormSet formSet = new FormSet();
            if (formSet.ShowDialog() == DialogResult.OK)
            {
                alarmSetFlag[num] = true;
                alarmHour[num] = formSet.alarmHour;
                alarmMinute[num] = formSet.alarmMinute;
                checkBox2.Text = alarmHour[num] + ":" + alarmMinute[num];
            }
            formSet.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num = 2;
            FormSet formSet = new FormSet();
            if (formSet.ShowDialog() == DialogResult.OK)
            {
                alarmSetFlag[num] = true;
                alarmHour[num] = formSet.alarmHour;
                alarmMinute[num] = formSet.alarmMinute;
                checkBox3.Text = alarmHour[num] + ":" + alarmMinute[num];
            }
            formSet.Dispose();
        }
    }
}
