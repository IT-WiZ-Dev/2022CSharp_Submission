using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dai6syou
{
   
    public partial class Formmain : Form
    {
       
        private bool alarmSetFlag1 = false;
        private bool alarmSetFlag2 = false;
        private bool alarmSetFlag3 = false;
        private int alarmHour1 = 0;
        private int alarmMinute1 = 0;

        private int alarmHour2 = 0;
        private int alarmMinute2 = 0;
        private int alarmHour3 = 0;
        private int alarmMinute3 = 0;



        public Formmain()
        {
            InitializeComponent();
        }

        private void Formmain_Load(object sender, EventArgs e)
        {
           timer1.Start();
            label2.Text = "00 : 00 ";
            label3.Text = "00 : 00";
            label4.Text = "00 : 00 ";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            label1.Text = now.ToLongTimeString();
            //アラーム設定中
            if (alarmSetFlag1 == true)
            {
                if(alarmHour1 == now.Hour && alarmMinute1 == now.Minute)
                {
                    alarmSetFlag1 = false;
                    MessageBox.Show("時間ですよ！","アラーム",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label2.Text = "00 : 00";
                    checkBox1.Checked = false;

                }
            }
            if (alarmSetFlag2 == true)
            {
                if (alarmHour2 == now.Hour && alarmMinute2 == now.Minute)
                {
                    alarmSetFlag2 = false;
                    MessageBox.Show("時間ですよ！", "アラーム", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label3.Text = "00 : 00";
                    checkBox2.Checked = false;

                }
            }
            if (alarmSetFlag3 == true)
            {
                if (alarmHour3 == now.Hour && alarmMinute3 == now.Minute)
                {
                    alarmSetFlag3 = false;
                    MessageBox.Show("時間ですよ！", "アラーム", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label4.Text = "00 : 00";
                    checkBox3.Checked = false;

                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2= new Form2();
           
            if(form2.ShowDialog() == DialogResult.OK)
            {
                alarmSetFlag1= true;
                alarmHour1 = form2.alarmHour;
                alarmMinute1=form2.alarmMinute;
                label2.Text=alarmHour1.ToString("00")+":"+alarmMinute1.ToString("00");
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
                alarmHour2 = form2.alarmHour;
                alarmMinute2 = form2.alarmMinute;
                label3.Text = alarmHour2.ToString("00") + ":" + alarmMinute2.ToString("00");
                checkBox2.Checked = true;
            }

            form2.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            if (form2.ShowDialog() == DialogResult.OK)
            {
                alarmSetFlag3 = true;
                alarmHour3 = form2.alarmHour;
                alarmMinute3 = form2.alarmMinute;
                label4.Text = alarmHour3.ToString("00") + ":" + alarmMinute3.ToString("00");
                checkBox3.Checked = true;
            }

            form2.Dispose();
        }
    }
}
