using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
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
            //現在時刻の設定
            numericUpDownAlmHour.Value = DateTime.Now.Hour;
            numericUpDownAlmMnt.Value = DateTime.Now.Minute;
        }

        private void numericUpDownAlmHour_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            alarmHour = (int)numericUpDownAlmHour.Value;
            alarmMinute = (int)numericUpDownAlmMnt.Value;
        }
    }
}
