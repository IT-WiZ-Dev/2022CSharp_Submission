﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlCheck
{
    public partial class labellabelRadioButton1 : Form
    {
        public labellabelRadioButton1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            labelRadioButton2.Text = "ラジオボタン2" + radioButton2.Checked;
        }

        private void label2_Click(object sender, EventArgs e)
        {
         
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            labelCheckBox.Text = "チェックボックス:" + checkBox1.Checked;
        }

        private void labelCheckbox_Load(object sender, EventArgs e)
        {
            labelCheckBox.Text = "チェックボックス:" + checkBox1.Checked;
            labelRadioButton1.Text = "ラジオボタン1" + radioButton1.Checked;
            labelRadioButton2.Text = "ラジオボタン2" + radioButton2.Checked;
            labelNumericUpDown.Text = "数値" + numericUpDown1.Value;
        }

        private void labelNumericUpDown_Click(object sender, EventArgs e)
        {
            labelNumericUpDown.Text = "数値" + numericUpDown1.Value;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            labelRadioButton1.Text = "ラジオボタン1" + radioButton1.Checked;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            labelNumericUpDown.Text = "数値" + numericUpDown1.Value;
        }
    }
}
