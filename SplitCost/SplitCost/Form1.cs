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
            labelPerperson.Text = "";
            labelRemainder.Text = "";
        }

        private void buttonCalculation_Click(object sender, EventArgs e)
        {
            int taxlessmoney;
            int people;
            int permoney;
            int remainder;
            double addTax;
            const double Tax = 0.1;

            taxlessmoney = int.Parse(textBoxTaxLess.Text);

            addTax = taxlessmoney;
            addTax *= (1 + Tax);
            taxlessmoney = (int)addTax;

            people = int.Parse(textBoxPeople.Text);
            permoney = taxlessmoney / people;
            remainder = taxlessmoney % people;
            labelPerperson.Text = permoney + "円";
            labelRemainder.Text = remainder + "円";
        }
    }
}
