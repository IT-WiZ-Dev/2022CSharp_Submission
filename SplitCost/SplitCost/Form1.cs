using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplitCost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxzeinuki.Text = "0";
            textBoxninzu.Text = "0";
            labelwarikan.Text="";
            labelamari.Text = "";
        }

        private void buttonkeisan_Click(object sender, EventArgs e)
        {
            double zei = 0.1;
            int zeinuki=int.Parse(textBoxzeinuki.Text);
            int ninzu = int.Parse(textBoxninzu.Text);
            zei=(1+zei)*zeinuki;
            zeinuki = (int)zei;
            int warikan = zeinuki / ninzu;
            labelwarikan.Text = warikan+"円";
            labelamari.Text = (zeinuki-(warikan*ninzu)) + "円";
        }
    }
}
