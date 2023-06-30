using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 第六章練習問題
{
    public partial class Form2 : Form
    {
        internal int Hour = 0;
        internal int Minute = 0;
        internal string stringHour;
        internal string stringMinute;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Hour = (int)numericUpDownHour.Value;
            int Minute = (int)numericUpDownMnt.Value;
            decimal numeric1 = numericUpDownHour.Value;
            decimal numeric2 = numericUpDownMnt.Value;
            stringHour = numeric1.ToString("00");
            stringMinute = numeric2.ToString("00");
               

            
            this.Close();
        }
    }
}