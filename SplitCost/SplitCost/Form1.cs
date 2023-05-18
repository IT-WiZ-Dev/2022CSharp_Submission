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
            int addMoney;
            double addtax;
            int human;
            int addHuman;

            money = int.Parse(textBoxMoney.Text);
            human = int.Parse(textBoxHuman.Text);

            addtax = money;
            addtax *= 1.1;
            money = (int)addtax;

            addMoney = money / human;
            addHuman = money % human;

            labelMoney1.Text = addMoney + "円";
            labelMoney2.Text = addHuman + "円";

        }
    }
}
