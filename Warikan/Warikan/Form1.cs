using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warikan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int money;
            int nokori;
            int bunkatu;
            int ninzu;
            double addtax;
            const double tax = 0.1;

            money = int.Parse(textBox1.Text);
            ninzu = int.Parse(textBox2.Text);
            addtax = (money*tax + money);
            money = (int)addtax;
            bunkatu = money / ninzu;
            nokori = money - (bunkatu * ninzu);

            label5.Text = "一人当たり\n\n"　+ bunkatu + "円";
            label6.Text = "余り\n\n" + nokori + "円";
            
            
        }
    }
}
