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
            int kazu;
            int a, b;
            double addTax;
            const double Tax = 0.1;

            money = int.Parse(textBox1.Text);

            addTax = money;
            addTax *= (1 + Tax);
            money = (int)addTax;
            
            kazu = int.Parse(textBox2.Text);
            a = money / kazu;
            label7.Text = a.ToString()+"円";
            b = money % kazu;
            label8.Text = b.ToString() + "円";
       }

     
    }
}
