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
     
        internal int AlarmHour = 0;    
        internal int AlarmMinute = 0;     

        public FormSet()
        {
            InitializeComponent();
        }

       
        private void FormSet_Load(object sender, EventArgs e)
        {
           
            numericUpDownHour.Value = DateTime.Now.Hour;
            numericUpDownMinute.Value = DateTime.Now.Minute;
        }

        
        private void ButtonOK_Click(object sender, EventArgs e)
        {
           
            AlarmHour = (int)numericUpDownHour.Value;
            AlarmMinute = (int)numericUpDownMinute.Value;
        }
    }
}
