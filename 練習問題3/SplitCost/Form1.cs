using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplitCost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int money = int.Parse(textBox1.Text);   
            int number = int.Parse(textBox2.Text); 
            const double Tax = 0.1;                    
            int addTax;                         
            int result1, result2;

            
            addTax = (int)(money * (1 + Tax));

            
            result1 = addTax / number;
            result2 = addTax % number;

            
            label6.Text = result1 + " 円";
            label9.Text = result2 + " 円";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label6.Text = "";
            label9.Text = "";
        }
    }
}
