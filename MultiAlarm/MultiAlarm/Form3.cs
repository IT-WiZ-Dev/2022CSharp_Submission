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
    public partial class Form3 : Form
    {
        internal int alarmHour = 0;
        internal int alarmMinute = 0;
        public Form3()
        {
            InitializeComponent();
        }



        private void Form2_Load(object sender, EventArgs e)
        {
            //現在時刻の表示
            numericUpDownHour.Value = DateTime.Now.Hour;
            numericUpDownMnt.Value = DateTime.Now.Minute;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            alarmHour = (int)numericUpDownHour.Value;
            alarmMinute = (int)numericUpDownMnt.Value;
        }
    }
}