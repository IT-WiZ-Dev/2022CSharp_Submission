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

            int hito;

            int ans1;

            int ans2;

            double add;

            const double Tax = 1.1;


            money = int.Parse(textBox1.Text);
         
            add = money;

            add = add * Tax;

            money = (int)add;

            hito = int.Parse(textBox2.Text);

            ans1 = money / hito;

            ans2 = money % hito;


            label7.Text = ans1 + "円";

            label8.Text = ans2 + "円";


        }
    }
}
