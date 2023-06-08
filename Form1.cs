using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            label6.Text = "";
            label8.Text = "";

                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            int x;
            double b;
            double z;
            const double Tax = 0.1;
            a = int.Parse(textBox1.Text);
            x = int.Parse(textBox2.Text);
            b = a;
            b *= (1 + Tax);
            z = b / x;
            b %= x;
            a = (int)z;
            x = (int)b;
            label6.Text = a + "円";
            label8.Text = x + "円";



             
            

        }
    }
}
