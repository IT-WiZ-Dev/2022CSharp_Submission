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

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "チェックボックス:" + checkBox1.Checked;
            label2.Text = "ラジオボタン:" + radioButton1.Checked;
            label3.Text = "ラジオボタン:" + radioButton2.Checked;
            label4.Text = "ニューメリック:" + numericUpDown1.Value.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "チェックボックス:" + checkBox1.Checked;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "ラジオボタン:" + radioButton1.Checked;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "ラジオボタン:" + radioButton2.Checked;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label4.Text = "ニューメリック:" + numericUpDown1.Value.ToString();
        }
    }
}
