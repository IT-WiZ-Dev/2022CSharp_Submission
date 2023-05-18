using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int money;
            int people;
            double addTax;
            const double Tax = 0.1;

            money = int.Parse(textBoxMoney.Text);
            people = int.Parse(textBoxPeople.Text);

            addTax = money;
            addTax *= (1 + Tax);
            money = (int)addTax;


            label5.Text = money / people + "円";
            label6.Text = money % people + "円";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
