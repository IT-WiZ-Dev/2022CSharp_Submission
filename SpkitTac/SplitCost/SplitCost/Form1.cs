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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            labelooo1.Text = "";
            labelooo2.Text = "";
        }



        private void ButtonSplit_Click(object sender, EventArgs e)
        {
            int money = int.Parse(labelooo1.Text);
            int number = int.Parse(labelooo2.Text);
            const double Tax = 0.1;
            int addTax;
            int result1, result2;


            addTax = (int)(money * (1 + Tax));


            result1 = addTax / number;
            result2 = addTax % number;


            labelooo1.Text = result1 + " 円";
            labelooo2.Text = result2 + " 円";
        }
    }
}