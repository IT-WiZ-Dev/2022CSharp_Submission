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
    public partial class Form2 : Form
    {
        internal int alarmHour = 0;
        internal int alarmMiunite = 0;
        internal int alarmSecond = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = (decimal)DateTime.Now.Hour;
            numericUpDown2.Value = (decimal)DateTime.Now.Minute;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            alarmHour = (int)numericUpDown1.Value;
            alarmMiunite = (int)numericUpDown2.Value;
         

            this.Dispose();

        }
    }
}
