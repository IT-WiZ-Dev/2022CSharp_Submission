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

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            label7.Text = "";
            label8.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int money;
            double addTax;
            const double Tax = 0.1;

            money = int.Parse(textBox1.Text);

            addTax = money;
            addTax *= (1 + Tax);
            money = (int)addTax;

            int ninzu;
            int money2;
            int amari;

            ninzu = int.Parse(textBox2.Text);

            money2 = money / ninzu;
            amari = money % ninzu;

            label7.Text = money2 + "円";
            label8.Text = amari + "円";

        }
    }
}
