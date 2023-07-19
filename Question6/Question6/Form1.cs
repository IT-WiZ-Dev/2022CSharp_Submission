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
            int x;
            int money = int.Parse(textBoxChange.Text);
            if(money >= 5000)
            {
                label5000yen.Text = "1";
                money =  money - 5000;
            }
            
            if (money >= 1000)
            {
                x = (money / 1000);
                label1000yen.Text = x.ToString();
                money = money - (1000 * x);
            }
            if (money >= 500)
            {
                label500yen.Text = "1";
                money = money - 500;
            }

            if (money >= 100)
            {
                x = (money / 100);
                label100yen.Text = x.ToString();
                money = money - (100 * x);
            }

            if (money >= 50)
            {
                x = (money / 50);
                label50yen.Text = "1";
                money = money - 50;
            }

            if (money >= 10)
            {
                x = (money / 10);
                label10yen.Text = x.ToString();
                money = money - (10 * x);
            }

            if (money >= 5)
            {
                x = (money / 5);
                label5yen.Text = "1";
                money = money - 5;
            }
            
            if (money >= 1)
            {
                x = (money / 1);
                label1yen.Text = x.ToString();
            }
        }
    }
}
