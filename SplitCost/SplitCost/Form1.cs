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

        }

        private void buttonKeisan_Click(object sender, EventArgs e)
        {
            int money;
            int nin;
            double addTax;
            const double Tax = 0.1;
            int hitori;
            int amari;

            money = int.Parse(textBox1.Text);
            nin = int.Parse(textBox2.Text);

            addTax = money;
            addTax *= (1 + Tax);
            money = (int)addTax;

            hitori = money / nin;
            amari = money % nin;

            labelHitori.Text = hitori + "円";
            labelAmari.Text = amari + "円";

        }
    }
}
