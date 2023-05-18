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
            labelSplitCost.Text = "";
            labelSurplus.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int taxFreeMoney, num,sum,fraction;
            double addTax;
            const double Tax = 0.1;

            taxFreeMoney = int.Parse(Money.Text);
            num = int.Parse(People.Text);
            addTax = taxFreeMoney + (taxFreeMoney * Tax);
            sum = (int)addTax;

            labelSplitCost.Text = (sum / num).ToString() + "円";
            labelSurplus.Text = (sum % num).ToString() + "円";

        }
    }
}
