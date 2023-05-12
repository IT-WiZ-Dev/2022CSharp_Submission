using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "チェックボックス：" + checkBox1.Checked;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label5.Text = "数値：" + numericUpDown1.Value.ToString();
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            checkBox1.Text
                           = "チェックボックス：" + checkBox1.Checked;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "チェックボックス：" + checkBox1.Checked;
            label2.Text = "ラジオボタン1：" + radioButton1.Checked;
            label3.Text = "ラジオボタン2：" + radioButton2.Checked;
            label5.Text = "数値：" + numericUpDown1.Value.ToString();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "ラジオボタン1：" + radioButton1.Checked;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "ラジオボタン2：" + radioButton2.Checked;
        }
    }
}
