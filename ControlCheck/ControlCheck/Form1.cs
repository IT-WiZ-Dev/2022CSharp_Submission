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
            label1.Text = checkBox1.Text+":"+checkBox1.Checked;
            label2.Text = radioButton1.Text + ":" + radioButton1.Checked;
            label3.Text = radioButton2.Text + ":" + radioButton2.Checked;
            label4.Text = "数値:" + numericUpDown1.Value;
        }
    }
}
