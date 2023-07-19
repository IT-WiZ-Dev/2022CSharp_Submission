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
            int change = int.Parse(textBoxChange.Text);

            int num1 = change / 5000;
            label5000yen.Text = num1.ToString();
            change %= 5000;

            int num2 = change / 1000;
            label1000yen.Text = num2.ToString();
            change %= 1000;

            int num3 = change / 500;
            label500yen.Text = num3.ToString();
            change %= 500;

            int num4 = change / 100;
            label100yen.Text = num4.ToString();
            change %= 100;

            int num5 = change / 50;
            label50yen.Text = num5.ToString();
            change %= 50;

            int num6 = change / 10;
            label10yen.Text = num6.ToString();
            change %= 10;

            int num7 = change / 5;
            label5yen.Text = num7.ToString();
            change %= 5;

            int num8 = change / 1;
            label1yen.Text = num8.ToString();
        }
    }
}
