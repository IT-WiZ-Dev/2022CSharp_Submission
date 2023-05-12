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

        private void Form1_Load(object sender, EventArgs e)
        {
            labelCheckBox.Text = "チェックボックス：" + checkBox1.Checked;

            labelRadioButton1.Text = "ラジオボタン１：" + radioButton1.Checked;

            labelRadioButton2.Text = "ラジオボタン２：" + radioButton2.Checked;

            labelNumericUpDown.Text = "数値：" + numericUpDown1.Value;
        }

        private void labelCheckBox_Click(object sender, EventArgs e)
        {
            
        }

        private void labelRadioButton1_Click(object sender, EventArgs e)
        {
            

        }

        private void labelRadioButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void labelNumericUpDown_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
