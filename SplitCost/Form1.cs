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
            int money, result;
            double addTax;
            const double Tax = 0.1;

            money = int.Parse(textBox1.Text);
            int multi = int.Parse(textBox2.Text);

            addTax = money;
            addTax *= (1 + Tax);
            result = (int)addTax;

            label2.Text = result / multi + " 円";
            label3.Text = result % multi + " 円";
        }
    }
}
