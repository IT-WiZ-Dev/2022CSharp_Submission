// Form2.cs
using System;
using System.Windows.Forms;

namespace MultiAlarm
{
    public partial class Form2 : Form
    {
        internal int alarmHour = 0;
        internal int alarmMinute = 0;
        internal int alarmSecond = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = DateTime.Now.Hour;
            numericUpDown2.Value = DateTime.Now.Minute;
            numericUpDown3.Value = DateTime.Now.Second;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            alarmHour = (int)numericUpDown1.Value;
            alarmMinute = (int)numericUpDown2.Value;
            alarmSecond = (int)numericUpDown3.Value;
            Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
