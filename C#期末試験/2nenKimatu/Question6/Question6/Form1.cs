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
            int money = int.Parse(textBoxChange.Text);
            int a = 0;
            label5000yen.Text = "X";
            label1000yen.Text = "X";
            label500yen.Text = "X";
            label100yen.Text = "X";
            label50yen.Text = "X";
            label10yen.Text = "X";
            label5yen.Text = "X";
            label1yen.Text = "X";
            while (money >= 5000)
            {
                money -= 5000;
                a += 1;
            }
            if (a >= 1)
            {
                label5000yen.Text += a.ToString();
                a = 0;
            }
            else
            {
                label5000yen.Text += "0";
            }

            while (money >= 1000)
            {
                money -= 1000;
                a += 1;
            }
            if (a >= 1)
            {
                label1000yen.Text += a.ToString();
                a = 0;
            }
            else
            {
                label1000yen.Text += "0";
            }

            while (money >= 500)
            {
                money -= 500;
                a += 1;
            }
            if (a >= 1)
            {
                label500yen.Text += a.ToString();
                a = 0;
            }
            else
            {
                label500yen.Text += "0";
            }

            while (money >= 100)
            {
                money -= 100;
                a += 1;
            }
            if (a >= 1)
            {
                label100yen.Text += a.ToString();
                a = 0;
            }
            else
            {
                label100yen.Text += "0";
            }

            while (money >= 50)
            {
                money -= 50;
                a += 1;
            }
            if (a >= 1)
            {
                label50yen.Text += a.ToString();
                a = 0;
            }
            else
            {
                label50yen.Text += "0";
            }

            while (money >= 10)
            {
                money -= 10;
                a += 1;
            }
            if (a >= 1)
            {
                label10yen.Text += a.ToString();
                a = 0;
            }
            else
            {
                label10yen.Text += "0";
            }

            while (money >= 5)
            {
                money -= 5;
                a += 1;
            }
            if (a >= 1)
            {
                label5yen.Text += a.ToString();
                a = 0;
            }
            else
            {
                label5yen.Text += "0";
            }

            while (money >= 1)
            {
                money -= 1;
                a += 1;
            }
            if (a >= 1)
            {
                label1yen.Text += a.ToString();
                a =  0;
            }
            else
            {
                label1yen.Text += "0";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label5000yen.Text = "X" ;
            label1000yen.Text = "X" ;
            label500yen.Text = "X" ;
            label100yen.Text = "X" ;
            label50yen.Text = "X" ;
            label10yen.Text = "X" ;
            label5yen.Text = "X" ;
            label1yen.Text = "X" ;
        }
    }
}
