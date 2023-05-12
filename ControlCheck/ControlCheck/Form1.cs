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

        private void labelCheckBox_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*labelCheckBox.Text = "チェックボックス：";
            labelRadioButton1.Text = "ラジオボタン１；";
            labelRadioBotton2.Text = "ラジオボタン２：";
            labelNumericUpDown.Text = "数値：";*/

            labelCheckBox.Text = "チェックボックス：" + checkBox1.Checked;
            labelRadioButton1.Text = "ラジオボタン１；" + radioButton1.Checked;
            labelRadioBotton2.Text = "ラジオボタン２：" + radioButton2.Checked;
            labelNumericUpDown.Text = "数値：" + numericUpDown1.Value;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                labelCheckBox.Text = "チェックボックス：True";
            }
            else
            {
                labelCheckBox.Text = "チェックボックス：False";
            }
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                labelRadioButton1.Text = "ラジオボタン１：True";
            }
            else
            {
                labelRadioButton1.Text = "ラジオボタン１：False";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                labelRadioBotton2.Text = "ラジオボタン2：True";
            }
            else
            {
                labelRadioBotton2.Text = "ラジオボタン2：False";
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            labelNumericUpDown.Text= "数値："+numericUpDown1.Value;
        }
    }
}

