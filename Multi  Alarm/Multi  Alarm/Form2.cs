using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi__Alarm
{
    public partial class Form2 : Form
    {
        internal int alarmHour = 0;
        internal int alarmMinute = 0;
        internal int alarmSecond = 0;
        internal int hour;
        internal int minute;
        

        



        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = DateTime.Now.Hour;
            numericUpDown2.Value = DateTime.Now.Minute;
            

        }

        private void NumericUpDownAlm_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            alarmHour = (int)numericUpDown1.Value;
            alarmMinute = (int)numericUpDown2.Value;
            alarmSecond = 0;
            Dispose();
         












            /*
            DateTime dtNow = DateTime.Now;
            TimeSpan addSpan =
                new TimeSpan(0, (int)numericUpDown1.Value,
                                (int)numericUpDown2.Value);
            DateTime setTime = dtNow.Add(addSpan);
            alarmHour = setTime.Hour;
            alarmMinute = setTime.Minute;
            alarmSecond = setTime.Second;
            */





        }


    }
}
