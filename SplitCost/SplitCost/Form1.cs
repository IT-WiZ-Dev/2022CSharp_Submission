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
    public partial class FormAddTax : Form
    {
        public FormAddTax()
        {
            InitializeComponent();
        }

        private void buttonAddTax_Click(object sender, EventArgs e)
        {
            int money;
            int man;
            int money2;
            int money3;
            double addTax;
            const double Tax = 0.1;

            money = int.Parse(textBoxMoney.Text);
            man = int.Parse(textBoxMan.Text);

            addTax = money;
            addTax *= (1 + Tax);
            money = (int)addTax;

            money2 = money / man;
            money3 = money % man;

            labelAddTax1.Text = money2 + "円";
            labelAddTax2.Text = money3 + "円";
        }
    }
}
