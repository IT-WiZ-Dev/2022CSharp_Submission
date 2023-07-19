using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 第6章_演習問題_22310121
{
    public partial class Form3 : Form
    {
        public static bool alarmSetFlag = false;//アラームセット中フラグ
        public static int alarmHour = 0;//アラーム時
        public static int alarmMinute = 0;//アラーム分
        public static int alarmSecond = 0;//アラーム秒

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = DateTime.Now.Hour;
            numericUpDown2.Value = DateTime.Now.Minute;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if(checkBox1.Checkd == true)

            //{
                //アラーム時刻の設定
                alarmHour = (int)numericUpDown1.Value;
                alarmMinute = (int)numericUpDown2.Value;
            //}
            this.Dispose();
        }
    }
}
