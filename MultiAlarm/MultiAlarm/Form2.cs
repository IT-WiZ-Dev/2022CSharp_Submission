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
    public partial class Form2 : Form
    {
        internal int  alarmhour,alarmminute;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            alarmhour = (int)numericUpDown1.Value;
            alarmminute = (int)numericUpDown2.Value;
            Dispose();
        }
    }
}
