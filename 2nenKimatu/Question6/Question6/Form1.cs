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
            string str = textBoxChange.Text;
            int oturi = int.Parse(str);

            int en5000 = oturi / 5000;
            oturi = oturi - en5000*5000;
            int en1000 = oturi / 1000;
            oturi = oturi - en1000*1000;
            int en500 = oturi / 500;
            oturi = oturi - en500*500;
            int en100 = oturi / 100;
            oturi = oturi - en100*100;
            int en50 = oturi / 50;
            oturi = oturi - en50*50;
            int en10 = oturi / 10;
            oturi = oturi - en10*10;
            int en5 = oturi / 5;
            oturi = oturi - en5*5;
            int en1 = oturi / 1;
            oturi = oturi - en1*1;

            string str5000 = Convert.ToString(en5000);
            label5000yen.Text = str5000;

            string str1000 = Convert.ToString(en1000);
            label1000yen.Text = str1000;

            string str500 = Convert.ToString(en500);
            label500yen.Text = str500;

            string str100 = Convert.ToString(en100);
            label100yen.Text = str100;

            string str50 = Convert.ToString(en50);
            label50yen.Text = str50;

            string str10 = Convert.ToString(en10);
            label10yen.Text = str10;

            string str5 = Convert.ToString(en5);
            label5yen.Text = str5;

            string str1 = Convert.ToString(en1);
            label1yen.Text = str1;
        }
    }
}
