using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int money;
            double addTax;
            const double Tax = 0.1;

            money = int.Parse(textBox1.Text);

            addTax = money;
            addTax *= (1 + Tax);
            money = (int)addTax;

            int okane;

            okane = int.Parse(textBox2.Text);

            int hitori;

            hitori = money / okane;

            int hutari;

            hutari = money % okane;

            label7.Text = hitori + "円";
            label8.Text = hutari + "円";
        }
    }
}
