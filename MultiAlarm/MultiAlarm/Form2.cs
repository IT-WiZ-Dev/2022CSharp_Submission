﻿using System;
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
        internal int alarmHour = 0;
        internal int alarmMinute = 0;
        internal int alarmSecond = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            alarmHour = (int)numericUpDownHour.Value;
            alarmMinute = (int)numericUpDownMinute.Value;
            alarmSecond = 0;
            
        }

        private void NumericUpDownAlm_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
