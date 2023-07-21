using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reidai6
{
    public partial class Form2 : Form
    {
        internal int alarmHour = 0;      
        internal int alarmMinute = 0;     
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            numericUpDownHour.Value = DateTime.Now.Hour;
            numericUpDownMinute.Value = DateTime.Now.Minute;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            alarmHour = (int)numericUpDownHour.Value;
            alarmMinute = (int)numericUpDownMinute.Value;
        }
    }
}
