using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //CheckBox1_CheckedChangedイベントハンドラ
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            labelCheckBox.Text = "チェックボックス：" + checkBox1.Checked;
        }

        //radioButton1_CheckedChangedイベントハンドラ
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            labelRadioButton1.Text = "ラジオボタン1：" + radioButton1.Checked;
        }

        //radioButton2_CheckedChangedイベントハンドラ
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            labelRadioButton2.Text = "ラジオボタン2：" + radioButton2.Checked;
        }

        //numericUpDown1_CheckedChangedイベントハンドラ
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            labelNumericUpDown.Text = "数値：" + numericUpDown1.Value;
        }
    }
}
