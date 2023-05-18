using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tax_rensyu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int money;
            int amari;
            double addTax;
            const double Tax = 0.1;
            int nin;

            money = int.Parse(textBoxmoney.Text);
            nin = int.Parse(people.Text);

            addTax = money;
            addTax *= (1 + Tax);
            money = (int)addTax / nin;
            amari = (int)addTax % nin;

            labelmoney.Text = money + "円";
            labelamari.Text = amari + "円";




            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelmoney.Text = "円";
            labelamari.Text = "円";
        }
    }
}
