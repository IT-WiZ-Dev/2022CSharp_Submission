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
            int Change = int.Parse(textBoxChange.Text);
            MoneyCal(Change, 5000, label5000yen);
            Change = Change % 5000;
            MoneyCal(Change, 1000, label1000yen);
            Change = Change % 1000;
            MoneyCal(Change, 500, label500yen);
            Change = Change % 500;
            MoneyCal(Change, 100, label100yen);
            Change = Change % 100;
            MoneyCal(Change, 50, label50yen);
            Change = Change % 50;
            MoneyCal(Change, 10, label10yen);
            Change = Change % 10;
            MoneyCal(Change, 5, label5yen);
            Change = Change % 5;
            MoneyCal(Change, 1, label1yen);
        }

        public void MoneyCal(int Change, int money, Label label)
        {
            int money_Num = Change / money;
            label.Text = money_Num.ToString();
        }
    }
}
