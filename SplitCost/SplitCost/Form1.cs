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

        private void buttonMoney_Click(object sender, EventArgs e)
        {
            int money;
            int people;
            int qmoney;
            int mod;
            double  addTax;
            const double Tax = 0.1;

            money = int.Parse(textBoxMoney.Text);
            people = int.Parse(textBoxPeople.Text);

            //消費税
            addTax = money;
            addTax *= 1 + Tax;
            money = (int)addTax;

            //計算
            qmoney = money / people;
            mod = money % people;

            //テキストへの挿入
            labelMoney.Text = qmoney + "円";
            labelMod.Text = mod + "円";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    
}
