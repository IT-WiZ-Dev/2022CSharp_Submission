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
            string oturi_text = textBoxChange.Text;
            int oturi2 = int.Parse(oturi_text);

            int oturi_5000 = 0;
            int oturi_1000 = 0;
            int oturi_500 = 0;
            int oturi_100 = 0;
            int oturi_50 = 0;
            int oturi_10 = 0;
            int oturi_5 = 0;
            int oturi_1 = 0;

            if (oturi2 >= 5000)
            {
                do
                {
                    oturi2 = oturi2 - 5000;
                    oturi_5000 = oturi_5000+1;
                } while (oturi2 >= 5000);
            }

            if (oturi2 >= 1000)
            {
                do
                {
                    oturi2 = oturi2 - 1000;
                    oturi_1000 = oturi_1000+1;
                } while (oturi2 >= 1000);
            }

            if (oturi2 >= 500)
            {
                do
                {
                    oturi2 = oturi2 - 500;
                    oturi_500 = oturi_500+1;
                } while (oturi2 >= 500);
            }

            if (oturi2 >= 100)
            {
                do
                {
                    oturi2 = oturi2 - 100;
                    oturi_100 = oturi_100+1;
                } while (oturi2 >= 100);
            }

            if (oturi2 >= 50)
            {
                do
                {
                    oturi2 = oturi2 - 50;
                    oturi_50 = oturi_50+1;
                } while (oturi2 >= 50);
            }

            if (oturi2 >= 10)
            {
                do
                {
                    oturi2 = oturi2 - 10;
                    oturi_10 = oturi_10+1;
                } while (oturi2 >= 10);
            }

            if (oturi2 >= 5)
            {
                do
                {
                    oturi2 = oturi2 - 5;
                    oturi_5 = oturi_5+1;
                } while (oturi2 >= 5);
            }

            if (oturi2 >= 1)
            {
                do
                {
                    oturi2 = oturi2 - 1;
                    oturi_1 = oturi_1+1;
                } while (oturi2 >= 1);
            }

            label5000yen.Text = Convert.ToString(oturi_5000);
            label1000yen.Text = Convert.ToString(oturi_1000);
            label500yen.Text = Convert.ToString(oturi_500);
            label100yen.Text = Convert.ToString(oturi_100);
            label50yen.Text = Convert.ToString(oturi_50);
            label10yen.Text = Convert.ToString(oturi_10);
            label5yen.Text = Convert.ToString(oturi_5);
            label1yen.Text = Convert.ToString(oturi_1);

        }
    }
}
