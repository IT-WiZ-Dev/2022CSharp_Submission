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
        int oturi;
        int gmai;
        int smai;
        int gimai;
        int simai;
        int gemai;
        int semai;
        int gmmai;
        int smmai;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCul_Click(object sender, EventArgs e)
        {
            oturi = int .Parse(textBoxChange.Text);
            if (oturi > 5000)
            {
                while (oturi > 5000)
                {
                    oturi = oturi - 5000;
                    gmai += 1;
                    if (oturi == 0)
                    {
                        break;
                    }
                }
            }
                label5000yen.Text = gmai + "枚";
            if (oturi > 1000)
            {
                while (oturi > 1000)
                {
                    oturi = oturi - 1000;
                    smai += 1;
                    if (oturi == 0)
                    {
                        break;
                    }
                }
            }
                label1000yen.Text = smai + "枚";
            if (oturi > 500)
            {
                while (oturi > 500)
                {
                    oturi = oturi - 500;
                    gimai += 1;
                    if (oturi == 0)
                    {
                        break;
                    }
                }
            }
                label500yen.Text = gimai + "枚";
            if (oturi > 100)
            {
                while (oturi > 100)
                {
                    oturi = oturi - 100;
                    simai += 1;
                    if (oturi == 0)
                    {
                        break;
                    }
                }
            }
                label100yen.Text = simai + "枚";
            if (oturi > 50)
            {
                while (oturi > 50)
                {
                    oturi = oturi - 50;
                    gemai += 1;
                    if (oturi == 0)
                    {
                        break;
                    }
                }
            }
                label50yen.Text = gemai + "枚";
        
            if (oturi > 10)
            {
                while (oturi > 10)
                {
                    oturi = oturi - 10;
                    semai += 1;
                    if (oturi == 0)
                    {
                        break;
                    }
                }
            }
                label10yen.Text = semai + "枚";
            if (oturi > 5)
            {
                while (oturi > 5)
                {
                    oturi = oturi - 5;
                    gmmai += 1;
                    if (oturi == 0)
                    {
                        break;
                    }
                }
            }
                label5yen.Text = gmmai + "枚";
            if (oturi >= 1)
            {
                while (oturi > 1)
                {
                    oturi = oturi - 1;
                    smmai += 1;
                    if (oturi == 0)
                    {
                        break;
                    }
                }
            }
            label1yen.Text = smmai + "枚";
        }
    }
}
