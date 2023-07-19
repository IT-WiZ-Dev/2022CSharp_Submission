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
            label5000yen.Text = "0";
            label1000yen.Text = "0";
            label500yen.Text = "0";
            label100yen.Text = "0";
            label50yen.Text = "0";
            label10yen.Text = "0";
            label5yen.Text = "0";
            label1yen.Text = "0";
            int total = int.Parse(textBoxChange.Text);

            int num = total / 5000;
            if (num > 0)
            {
                label5000yen.Text = num.ToString();
                total = total % 5000;
            }
            num = total / 1000;
            if (num > 0)
            {
                label1000yen.Text = num.ToString();
                total = total % 1000;
            }
            num = total / 500;
            if (num > 0)
            {
                label500yen.Text = num.ToString();
                total = total % 500;
            }
            num = total / 100;
            if (num > 0)
            {
                label100yen.Text = num.ToString();
                total = total % 100;
            }
            num = total / 50;
            if (num > 0)
            {
                label50yen.Text = num.ToString();
                total = total % 50;
            }
            num = total / 10;
            if (num > 0)
            {
                label10yen.Text = num.ToString();
                total = total % 10;
            }
            num = total / 5;
            if (num > 0)
            {
                label5yen.Text = num.ToString();
                total = total % 5;
            }
            if (total > 0)
            {
                label1yen.Text = total.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
