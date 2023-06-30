using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 第六章練習問題
{
    public partial class Form1 : Form
    {
        int alarmHour = 0;
        int alarmMinute = 0;
        bool alarmSetFlag1 = false;
        bool alarmSetFlag2 = false;
        bool alarmSetFlag3 = false;
        int currentHour = DateTime.Now.Hour;
        int currentMinute = DateTime.Now.Minute;
        string textHour;
        string textMinute;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            timer11.Start();
            label1.Text = DateTime.Now.ToString();

            if (alarmSetFlag1 == true)
            {
                if (alarmHour == currentHour && alarmMinute == currentMinute)
                {
                    alarmSetFlag1 = false;
                    DialogResult dialogResult = MessageBox.Show("時間ですよ", "", MessageBoxButtons.OK);
                    checkBox1.Text = "00:00";
                }
            }
            if (alarmSetFlag2 == true)
            {
                if (alarmHour == currentHour && alarmMinute == currentMinute)
                {
                    alarmSetFlag2 = false;
                    DialogResult dialogResult = MessageBox.Show("時間ですよ", "", MessageBoxButtons.OK);
                    checkBox2.Text = "00:00";
                }
            }
            if (alarmSetFlag3 == true)
            {
                if (alarmHour == currentHour && alarmMinute == currentMinute)
                {
                    alarmSetFlag3 = false;
                    DialogResult dialogResult = MessageBox.Show("時間ですよ", "", MessageBoxButtons.OK);
                    checkBox3.Text = "00:00";
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();

            Form2.ShowDialog();

            alarmSetFlag1 = true;
            alarmHour = Form2.Hour;
            alarmMinute = Form2.Minute;


            checkBox1.Text = Form2.stringHour + ":" + Form2.stringMinute;
            checkBox1.Checked = true;



            Form2.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();

            Form2.ShowDialog();
            
                alarmSetFlag1 = true;
                alarmHour = Form2.Hour;
                alarmMinute = Form2.Minute;

                checkBox2.Text = Form2.stringHour + ":" + Form2.stringMinute;
                checkBox2.Checked = true;



            
            Form2.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();

            Form2.Show();
           
                alarmSetFlag1 = true;
                alarmHour = Form2.Hour;
                alarmMinute = Form2.Minute;

                checkBox3.Text = Form2.stringHour + ":" + Form2.stringMinute;
                checkBox3.Checked = true;



            
            Form2.Dispose();
        }
    }
}
