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
            label5000yen.Text = "X";
            label1000yen.Text = "X";
            label500yen.Text = "X";
            label100yen.Text = "X";
            label50yen.Text = "X";
            label10yen.Text = "X";
            label5yen.Text = "X";
            label1yen.Text = "X";

            int oturi = int.Parse(textBoxChange.Text);

            if (oturi >= 5000)
            {
                label5000yen.Text = Convert.ToString(oturi / 5000);
                oturi = oturi % 5000;
            }
            if (oturi >= 1000)
            {
                label1000yen.Text = Convert.ToString(oturi / 1000);
                oturi = oturi % 1000;
            }
            if (oturi >= 500)
            {
                label500yen.Text = Convert.ToString(oturi / 500);
                oturi = oturi % 500;
            }
            if (oturi >= 100)
            {
                label100yen.Text = Convert.ToString(oturi / 100);
                oturi = oturi % 100;
            }
            if (oturi >= 50)
            {
                label50yen.Text = Convert.ToString(oturi / 50);
                oturi = oturi % 50;
            }
            if (oturi >= 10)
            {
                label10yen.Text = Convert.ToString(oturi / 10);
                oturi = oturi % 10;
            }
            if (oturi >= 5)
            {
                label5yen.Text = Convert.ToString(oturi / 5);
                oturi = oturi % 5;
            }
            if (oturi >= 1)
            {
                label1yen.Text = Convert.ToString(oturi / 1);
                oturi = oturi % 1;
            }
        }
    }
}
