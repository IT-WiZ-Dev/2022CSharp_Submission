using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCul_Click(object sender, EventArgs e)
        {
            int money;
            int oturi;
            int amari;
            money = int.Parse(textBoxChange.Text);
            if(money >= 5000)
            {
                oturi = money / 5000;
                label5000yen.Text = oturi.ToString();
                amari = money % 5000;
                money = amari;
            }
            if (money >= 1000 && money > 0)
            {
                oturi = money / 1000;
                label1000yen.Text = oturi.ToString();
                amari = money % 1000;
                money = amari;
            }
            if (money >= 500 && money > 0)
            {
                oturi = money / 500;
                label500yen.Text = oturi.ToString();
                amari = money % 500;
                money = amari;
            }
            if (money >= 100 && money > 0)
            {
                oturi = money / 100;
                label100yen.Text = oturi.ToString();
                amari = money % 100;
                money = amari;
            }
            if (money >= 50 && money > 0)
            {
                oturi = money / 50;
                label50yen.Text = oturi.ToString();
                amari = money % 50;
                money = amari;
            }
            if (money >= 10 && money > 0)
            {
                oturi = money / 10;
                label10yen.Text = oturi.ToString();
                amari = money % 10;
                money = amari;
            }
            if (money >= 5 && money > 0)
            {
                oturi = money / 5;
                label5yen.Text = oturi.ToString();
                amari = money % 5;
                money = amari;
            }
            if (money >= 1 && money > 0)
            {
                label1yen.Text = money.ToString();
            }
        }
    }
}
