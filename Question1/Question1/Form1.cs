using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int num1 = (int)textBox1.Text;
            //int num2 = (int)textBox2.Text;
            label1.Text = textBox1.Text + textBox2.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
