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
             int higuti;
            int noguti;
            int yen500;
            int yen100;
            int yen50;
            int yen10;
            int yen5;
            int yen1;

            string inputText = textBoxChange.Text;
            int Otsuri = Convert.ToInt32(inputText);

            higuti = Otsuri / 5000;
            Otsuri = Otsuri % 5000;

            noguti = Otsuri / 1000;
            Otsuri = Otsuri % 1000;

            yen500 = Otsuri / 500;
            Otsuri = Otsuri % 500;

            yen100 = Otsuri / 100;
            Otsuri = Otsuri % 100;

            yen50 = Otsuri / 50;
            Otsuri = Otsuri % 50;

            yen10 = Otsuri / 10;
            Otsuri = Otsuri % 10;

            yen5 = Otsuri / 5;
            Otsuri = Otsuri % 5;

            yen1 = Otsuri / 1;
            Otsuri = Otsuri % 1;

            label5000yen.Text = higuti.ToString();
            label1000yen.Text = noguti.ToString();
            label500yen.Text = yen500.ToString();
            label100yen.Text = yen100.ToString();
            label50yen.Text = yen50.ToString();
            label10yen.Text = yen10.ToString();
            label5yen.Text = yen5.ToString();
            label1yen.Text = yen1.ToString();


        }
    }
}
