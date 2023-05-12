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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            lable1.Text = checkBox1.Text +  true;


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label2.Text = radioButton1.Text + true;
            }
            else
                label2.Text = radioButton1.Text + false;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label3.Text = radioButton2.Text + true;
            }
            else
                label3.Text = radioButton2.Text + false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
            //int value = (int)numericUpDown1.Value;

            label4.Text = "数値："+numericUpDown1.Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
