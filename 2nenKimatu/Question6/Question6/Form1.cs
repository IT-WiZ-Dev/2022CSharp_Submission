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
            string inputText = textBoxChange.Text;
            int yen = Convert.ToInt32(inputText);

            int b5k, b1k, c500, c100, c50, c10, c5, c1;
            
            b5k = yen / 5000;
            yen = yen % 5000;
            b1k = yen / 1000;
            yen = yen % 1000;
            c500 = yen / 500;
            yen = yen % 500;
            c100 = yen / 100;
            yen = yen % 100;
            c50 = yen / 50;
            yen = yen % 50;
            c10 = yen / 10;
            yen = yen % 10;
            c5 = yen / 5;
            c1 = yen % 5;

            string a = Convert.ToString(b5k);
            label5000yen.Text = a;

            string b = Convert.ToString(b1k);
            label1000yen.Text = b;

            string c = Convert.ToString(c500);
            label500yen.Text = c;

            string d = Convert.ToString(c100);
            label100yen.Text = d;

            string e1 = Convert.ToString(c50);
            label50yen.Text = e1;

            string f = Convert.ToString(c10);
            label10yen.Text = f;

            string g = Convert.ToString(c5);
            label5yen.Text = g;

            string h = Convert.ToString(c1);
            label1yen.Text = h;
        }

        private void textBoxChange_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
