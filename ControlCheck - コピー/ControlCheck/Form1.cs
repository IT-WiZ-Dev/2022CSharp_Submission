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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            labelCheckBox.Text = "チェックボックス:" + checkBox1.Checked;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            labelRadioButton1.Text = "ラジオボタン1:" + radioButton1.Checked;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            labelRadioBoxButton2.Text = "ラジオボタン2:" + radioButton2.Checked;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            labelNumelicUpDown.Text = "数値:" + numericUpDown2.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelCheckBox.Text = "チェックボックス:" + checkBox1.Checked;
            labelNumelicUpDown.Text = "数値:" + numericUpDown2.Value;
            labelRadioBoxButton2.Text = "ラジオボタン2:" + radioButton2.Checked;
            labelRadioButton1.Text = "ラジオボタン1:" + radioButton1.Checked;
        }
    }
}
