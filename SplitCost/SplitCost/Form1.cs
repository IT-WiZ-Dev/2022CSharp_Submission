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
            int money, ninzu, amari, warikan;
            double Tax;
            Tax = 0.1; 

            money = int.Parse(textBox1.Text);
            ninzu = int.Parse(textBox2.Text);

            money = (int)(money * (1 + Tax));
            warikan = money / ninzu;
            amari = money % ninzu;

            label6.Text = warikan + "円";
            label8.Text = amari + "円";
        }
    }
}
