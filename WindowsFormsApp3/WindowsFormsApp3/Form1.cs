using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        
        public Form1()
             
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            labelCheckBox.Text = "チェックボックス：" + checkBox1.Checked;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            labelRadioButton1.Text = "ラジオボタン1：" + radioButton1.Checked;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            labelRadioButton2.Text = "ラジオボタン2：" + radioButton2.Checked;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            labelNumericUpDown.Text = "数値："+numericUpDown1.Value ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            labelCheckBox.Text = "チェックボックス：" + checkBox1.Checked;
            radioButton1.Checked = false;
            labelRadioButton1.Text = "ラジオボタン1：" + radioButton1.Checked;
            radioButton2.Checked = true;
            labelRadioButton2.Text = "ラジオボタン2：" + radioButton2.Checked;
            numericUpDown1.Value = 15;
            labelNumericUpDown.Text = "数値：" + numericUpDown1.Value;

        }

      
    }
}
