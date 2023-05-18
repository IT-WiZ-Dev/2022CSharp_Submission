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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int money;
            int people;
            int syou;
            int amari;
            double addTax;
            const double Tax = 0.1;
            money = int.Parse(textBox1.Text);
            people = int.Parse(textBox2.Text);

            addTax = money;
            money = (int)(money * (1 + Tax));
            syou = money / people;
            amari = money % people;
            label7.Text = syou + "円";
            label8.Text = amari + "円";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label7.Text = "";
            label8.Text = "";
        }
    }
}
