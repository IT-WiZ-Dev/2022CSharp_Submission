using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_MultiAlarm
{
    public partial class FormSet : Form
    {
        internal int alarmHour = 0;
        internal int alarmMinute = 0;
        internal int alarmSecond = 0;
        public FormSet()
        {
            InitializeComponent();
        }

        private void FormSet_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = DateTime.Now.Hour;
            numericUpDown2.Value = DateTime.Now.Minute;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            alarmHour = (int)numericUpDown1.Value;
            alarmMinute = (int)numericUpDown2.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
