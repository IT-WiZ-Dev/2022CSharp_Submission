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
    public partial class FormSet : Form
    {
        internal int alarmHour = 0;
        internal int alarmMinute = 0;

        public FormSet()
        {
            InitializeComponent();
        }

        private void FormSet_Load(object sender, EventArgs e)
        {
            numericUpDownAImHour.Value = DateTime.Now.Hour;
            numericUpDownAImMnt.Value = DateTime.Now.Minute;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            alarmHour = (int)numericUpDownAImHour.Value;
            alarmMinute = (int)numericUpDownAImMnt.Value;
        }
    }
}
