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


        private void button1_Click(object sender, EventArgs e)
        {
            int money;
            double tax;
            double addtax;
            int ninzu;
            double warikan;
            double amari;
            money = int.Parse(textBox1.Text);
            ninzu = int.Parse(textBox2.Text);
            tax = 1.1;
            addtax = money * tax;
            warikan = (int)addtax / ninzu;
            amari = (int)addtax % ninzu;
            label7.Text = warikan + "円";
            label8.Text = amari + "円";
        }
    }
}
