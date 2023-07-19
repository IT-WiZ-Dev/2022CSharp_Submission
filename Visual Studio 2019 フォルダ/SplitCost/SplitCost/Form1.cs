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

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label6.Text = "";
            label8.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int money;
            double SplitCost;
            const double Cost = 0.1;

            money = int.Parse(textBox1.Text);

            SplitCost = money;
            SplitCost *= (1 + Cost);
            money = (int)SplitCost;

            int money_sub;
            money_sub = int.Parse(textBox2.Text);

            label6.Text = money / money_sub + " 円";
            label8.Text = money % money_sub + " 円";
        }
    }
}
