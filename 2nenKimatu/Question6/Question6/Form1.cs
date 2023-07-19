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
            int change = int.Parse(textBoxChange.Text);

            int yen5000 = change / 5000;
            change %= 5000;

            int yen1000 = change / 1000;
            change %= 1000;

            int yen500 = change / 500;
            change %= 500;

            int yen100 = change / 100;
            change %= 100;

            int yen50 = change / 50;
            change %= 50;

            int yen10 = change / 10;
            change %= 10;

            int yen5 = change / 5;
            change %= 5;

            int yen1 = change;

            label5000yen.Text = yen5000.ToString();
            label1000yen.Text = yen1000.ToString();
            label500yen.Text = yen500.ToString();
            label100yen.Text = yen100.ToString();
            label50yen.Text = yen50.ToString();
            label10yen.Text = yen10.ToString();
            label5yen.Text = yen5.ToString();
            label1yen.Text = yen1.ToString();
        }
    }
}
