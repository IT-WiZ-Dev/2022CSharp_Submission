using System;
using System.Windows.Forms;

namespace MultiAlarm
{
    public partial class Form1 : Form
    {
        private int alarmHour1 = 0; //時
        private int alarmMinute1 = 0; //分
        private int alarmHour2 = 0; //時
        private int alarmMinute2 = 0; //分
        private int alarmHour3 = 0; //時
        private int alarmMinute3 = 0; //分

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Form2 formSet = new Form2())
            {
                if (formSet.ShowDialog() == DialogResult.OK)
                {
                    alarmHour1 = formSet.alarmHour;
                    alarmMinute1 = formSet.alarmMinute;
                    label2.Text = alarmHour1.ToString("00") + ":" + alarmMinute1.ToString("00");
                    checkBox1.Checked = true;
                }
                formSet.Dispose();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Form2 formSet = new Form2())
            {
                if (formSet.ShowDialog() == DialogResult.OK)
                {
                    alarmHour2 = formSet.alarmHour;
                    alarmMinute2 = formSet.alarmMinute;
                    label3.Text = alarmHour2.ToString("00") + ":" + alarmMinute2.ToString("00");
                    checkBox2.Checked = true;
                }
                formSet.Dispose();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Form2 formSet = new Form2())
            {
                if (formSet.ShowDialog() == DialogResult.OK)
                {
                    alarmHour3 = formSet.alarmHour;
                    alarmMinute3 = formSet.alarmMinute;
                    label4.Text = alarmHour3.ToString("00") + ":" + alarmMinute3.ToString("00");
                    checkBox3.Checked = true;
                }
                formSet.Dispose();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            label1.Text = now.ToLongTimeString();


            // アラーム時刻
            if (alarmHour1 == now.Hour && alarmMinute1 == now.Minute && checkBox1.Checked == true)
            {
                // 設定されているアラームのチェックボックスを外す             
                checkBox1.Checked = false;
                MessageBox.Show("時間ですよ！", "アラーム", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (alarmHour2 == now.Hour && alarmMinute2 == now.Minute && checkBox2.Checked == true)
            {
                // 設定されているアラームのチェックボックスを外す
                checkBox2.Checked = false;
                MessageBox.Show("時間ですよ！", "アラーム", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (alarmHour3 == now.Hour && alarmMinute3 == now.Minute && checkBox3.Checked == true)
            {
                // 設定されているアラームのチェックボックスを外す
                checkBox3.Checked = false;
                MessageBox.Show("時間ですよ！", "アラーム", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
