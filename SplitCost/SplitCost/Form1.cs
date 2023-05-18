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
            int ninzu;
            double SplitCost;
            const double Cost = 0.1;

            money = int.Parse(textBox1.Text);
            ninzu = int.Parse(textBox2.Text);


            SplitCost = money;
            SplitCost *= (1 + Cost);
            money = (int)SplitCost;

            label7.Text = money / ninzu + "円";
            label8.Text = money % ninzu + "円";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label8.Text = "";
            label7.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}
