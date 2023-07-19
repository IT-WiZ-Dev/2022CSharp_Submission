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
    public partial class Forｍ1 : Form
    {
        private bool alarmSetFlag = false;
        private int alarmHour = 0;
        private int alarmMinute = 0;
        private int alarmH = 0;
        private int alarmM = 0;
        private int aHour = 0;
        private int aMinute = 0;
        public Forｍ1()
        {
            InitializeComponent();
        }

        private void Forｍ1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            checkBoxAlam1.Text = "00:00";
            checkBoxAlam2.Text = "00:00";
            checkBoxAlam3.Text = "00:00";
            labelTime.Text = DateTime.Now.ToLongTimeString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelTime.Text = now.ToLongTimeString();
            if (alarmSetFlag == true)
            {
                if(checkBoxAlam1.Checked == true || checkBoxAlam2.Checked == true || checkBoxAlam3.Checked == true) 
                {
                    if (alarmHour == now.Hour && alarmMinute == now.Minute)
                    {
                        alarmSetFlag = false;
                        MessageBox.Show("時間ですよ！", "アラーム", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        checkBoxAlam1.Checked = false;
                        checkBoxAlam1.Text = "00:00";
                    }
                    else if (alarmH == now.Hour && alarmM == now.Minute)
                    {
                        alarmSetFlag = false;
                        MessageBox.Show("時間ですよ！", "アラーム", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        checkBoxAlam2.Checked = false;
                        checkBoxAlam2.Text = "00:00";
                    }else if (aHour == now.Hour && aMinute == now.Minute) 
                    {
                        alarmSetFlag = false;
                        MessageBox.Show("時間ですよ！", "アラーム", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        checkBoxAlam3.Checked = false;
                        checkBoxAlam3.Text = "00:00";
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 formset = new Form2();
            if (formset.ShowDialog() == DialogResult.OK)
            {
                alarmSetFlag = true;
                checkBoxAlam1.Checked = true;
                alarmHour = formset.alarmHour;
                alarmMinute = formset.alarmMinute;
                checkBoxAlam1.Text = alarmHour.ToString("00") + ":" + alarmMinute.ToString("00");
            }
            formset.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 formset = new Form2();
            if (formset.ShowDialog() == DialogResult.OK)
            {
                alarmSetFlag = true;
                checkBoxAlam2.Checked = true;
                alarmH = formset.alarmHour;
                alarmM = formset.alarmMinute;
                checkBoxAlam2.Text = alarmH.ToString("00") + ":" + alarmM.ToString("00");
            }
            formset.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 formset = new Form2();
            if (formset.ShowDialog() == DialogResult.OK)
            {
                alarmSetFlag = true;
                checkBoxAlam3.Checked = true;
                aHour = formset.alarmHour;
                aMinute = formset.alarmMinute;
                checkBoxAlam3.Text = aHour.ToString("00") + ":" + aMinute.ToString("00");
            }
            formset.Dispose();
        }
    }
}
