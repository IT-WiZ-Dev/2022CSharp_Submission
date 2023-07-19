using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_Alarm
{
    public partial class Form2 : Form
    {
        internal int Alarm1 = 0;     
        internal int Alarm2 = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = DateTime.Now.Hour;
            numericUpDown2.Value = DateTime.Now.Minute;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDownHour_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownMinute_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alarm1 = (int)numericUpDown1.Value;
            Alarm2 = (int)numericUpDown2.Value;
        }
    }
}
