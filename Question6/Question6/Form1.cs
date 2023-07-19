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
            string s = textBoxChange.Text;
            int all = int.Parse(s);

            int higuti = 0;
            int noguti = 0;
            int Gcoin = 0;
            int Hcoin = 0;
            int gcoin = 0;
            int Jcoin = 0;
            int HJcoin = 0;

            while(all != 0)
            {
                if( all >= 5000)
                {
                    higuti = all / 5000;
                    all = all % 5000;
                }else if (all >= 1000)
                {
                    noguti = all / 1000;
                    all = all % 1000;
                }else if (all >= 500)
                {
                    Gcoin = all / 500;
                    all = all % 500;
                }else if (all >= 100)
                {
                    Hcoin = all / 100;
                    all = all % 100;
                }else if (all >= 50)
                {
                    gcoin = all / 50;
                    all = all % 50;
                }else if (all >= 10)
                {
                    Jcoin = all / 10;
                    all = all % 10;
                }else if (all >= 5)
                {
                    HJcoin = all / 5;
                    all = all % 5;
                }
            }
            label1yen.Text = all.ToString();
            label5yen.Text = HJcoin.ToString();
            label10yen.Text = Jcoin.ToString();
            label50yen.Text = gcoin.ToString();
            label100yen.Text = Hcoin.ToString();
            label500yen.Text = Gcoin.ToString();
            label1000yen.Text = noguti.ToString();
            label5000yen.Text = higuti.ToString();



        }
    }
}
