using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace コントロールの状態
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "チェックボックス　:　" + labelCheckBox.Checked;
            label2.Text = "ラジオボタン1　：　" + radioButton1.Checked;
            label3.Text = "ラジオボタン2　：　" + radioButton2.Checked;
            label4.Text = "ニューメリックアップダウン　：　" + numericUpDown1.Value;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "ラジオボタン１ ：" + radioButton1.Checked;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "チェックボックス ：" + labelCheckBox.Checked;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label4.Text = "ニューメリックアップダウン ：" + numericUpDown1.Value;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "ラジオボタン2 ：" + radioButton2.Checked;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
