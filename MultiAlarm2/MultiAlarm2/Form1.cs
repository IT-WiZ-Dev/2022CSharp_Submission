using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiAlarm2
{
    public partial class Form1 : Form
    {
        private bool[] alarmSetFlag = new bool[3];
         private int[] alarmHour = new int[3];
         private int[] alarmMiunite = new int[3];
         private int[] alarmSecond = new int[3]; 
        /*private int alarmH1 = 0;
        private int alarmM1 = 0;
        private int alarmH2 = 0;
        private int alarmM2 = 0;
        private int alarmH3 = 0;
        private int alarmM3 = 0;*/

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

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
            for (int i=0;i<=2;i++) {
                if (alarmHour[i] == now.Hour && alarmMiunite[i] == now.Minute && alarmSecond[i] == now.Second)
                {
                    alarmSetFlag[i] = false;
                    MessageBox.Show("時間ですよ！", "アラーム", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (i == 0)
                    {
                        checkBox1.Checked = false;
                        label2.Text = "00:00";
                    }else if (i == 1)
                    {
                        checkBox2.Checked = false;
                        label3.Text = "00:00";
                    }
                    else{
                        checkBox3.Checked = false;
                        label4.Text = "00:00";
                    }
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Console.WriteLine( ((Button)sender).Name);
            string[] str = ((Button)sender).Name.Split('_');
            int btnNum = int.Parse(str[1]);
            
       
            Form2 formSet = new Form2();
            formSet.ShowDialog();

            alarmSetFlag[btnNum - 1] = true;
            alarmHour[0] = formSet.alarmHour;
            alarmMiunite[0] = formSet.alarmMiunite;
            alarmSecond[0] = formSet.alarmSecond;
            label2.Text = alarmHour[0].ToString("00") + ":" +
                     alarmMiunite[0].ToString("00");
            checkBox1.Checked = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            Form2 formSet = new Form2();
            if (formSet.ShowDialog() == DialogResult.OK)
            {
                alarmSetFlag = true;
                alarmHour = formSet.alarmHour;
                alarmMiunite = formSet.alarmMiunite;
                alarmSecond = formSet.alarmSecond;
            }
            */
            Console.WriteLine(((Button)sender).Name);
            string[] str = ((Button)sender).Name.Split('_');
            int btnNum = int.Parse(str[1]);


            Form2 formSet = new Form2();
            formSet.ShowDialog();

            alarmSetFlag[btnNum - 1] = true;
            alarmHour[1] = formSet.alarmHour;
            alarmMiunite[1] = formSet.alarmMiunite;
            alarmSecond[1] = formSet.alarmSecond;
            label3.Text = alarmHour[1].ToString("00") + ":" +
                     alarmMiunite[1].ToString("00");
            checkBox2.Checked = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*
            Form2 formSet = new Form2();
            if (formSet.ShowDialog() == DialogResult.OK)
            {
                alarmSetFlag = true;
                alarmHour = formSet.alarmHour;
                alarmMiunite = formSet.alarmMiunite;
                alarmSecond = formSet.alarmSecond;
            }
            */
            Console.WriteLine(((Button)sender).Name);
            string[] str = ((Button)sender).Name.Split('_');
            int btnNum = int.Parse(str[1]);


            Form2 formSet = new Form2();
            formSet.ShowDialog();

            alarmSetFlag[btnNum - 1] = true;
            alarmHour[2] = formSet.alarmHour;
            alarmMiunite[2] = formSet.alarmMiunite;
            alarmSecond[2] = formSet.alarmSecond;
            label4.Text=alarmHour[2].ToString("00") + ":" +
                     alarmMiunite[2].ToString("00");
            checkBox3.Checked = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
