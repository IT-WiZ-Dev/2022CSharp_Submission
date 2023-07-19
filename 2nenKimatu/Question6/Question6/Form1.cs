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

        private void textBoxChange_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCul_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBoxChange.Text);
            int num = a / 5000;
            int c = a % 5000;
            label5000yen.Text = num.ToString();
            a = c;

            num = a / 1000;
            c = a % 1000;
            label1000yen.Text = num.ToString();
            a = c;

            num = a / 500;
            c = a % 500;
            label500yen.Text = num.ToString();
            a = c;

            num = a / 100;
            c = a % 100;
            label100yen.Text = num.ToString();
            a = c;

            num = a / 50;
            c = a % 50;
            label50yen.Text = num.ToString();
            a = c;

            num = a / 10;
            c = a % 10;
            label10yen.Text = num.ToString();
            a = c;

            num = a / 5;
            c = a % 5;
            label5yen.Text = num.ToString();
            a = c;

            label1yen.Text = a.ToString();


        }
    }
}
