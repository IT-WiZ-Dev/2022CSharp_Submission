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
            int aa = int.Parse(label5000yen.Text);
            int ab = int.Parse(label1000yen.Text);
            int ac = int.Parse(label500yen.Text);
            int ad = int.Parse(label100yen.Text);
            int ae = int.Parse(label50yen.Text);
            int af = int.Parse(label10yen.Text);
            int ag = int.Parse(label5yen.Text);
            int ah = int.Parse(label1yen.Text);
        }

        private void buttonCul_Click(object sender, EventArgs e)
        {
            int a,b,c,d,i,f,g,h;
            a = 0; b = 0; c = 0; d = 0; i = 0; f = 0; g = 0;h = 0;
            int money = int.Parse(textBoxChange.Text);

            if (money > 5000)
            {
                a += 1;
                money -= 5000;
            }
            if(money>1000)
            {
                b += 1;
                money -= 1000;
            }
             if (money > 1000)
            {
                b += 1;
                money -= 1000;
            }
             if (money > 1000)
            {
                b += 1;
                money -= 1000;
            }
            if (money > 1000)
            {
                b += 1;
                money -= 1000;
            }
            if(money>500)
            {
                c += 1;
                money -= 500;
            }
            if(money>100)
            {
                d += 1;
                money -= 100;
            }
            if (money > 100)
            {
                d += 1;
                money -= 100;
            }
            if (money > 100)
            {
                d += 1;
                money -= 100;
            }
            if (money > 100)
            {
                d += 1;
                money -= 100;
            }
            if(money>50)
            {
                f += 1;
                money -= 50;
            }
            if(money>10)
            {
                i += 1;
                money -= 10;
            }
            if (money > 10)
            {
                i += 1;
                money -= 10;
            }
            if (money > 10)
            {
                i += 1;
                money -= 10;
            }
            if (money > 10)
            {
                i += 1;
                money -= 10;
            }
            if(money>5)
            {
                g += 1;
                money -= 5;
            }
            if(money>1)
            {
                h += 1;
                money -= 1;
            }
            if (money > 1)
            {
                h += 1;
                money -= 1;
            }

            if (money > 1)
            {
                h += 1;
                money -= 1;
            }

            if (money > 1)
            {
                h += 1;
                money -= 1;
            }





           aa = a;
            label1000yen.Text = b;
            label500yen.Text = c;
            label100yen.Text =d ;
            label10yen.Text =i ;
            label50yen.Text =f ;
            label5yen.Text =g ;
            label1yen.Text =h ;
        }

      
    }
}
