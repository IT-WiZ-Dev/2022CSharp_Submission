﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class FormAddTax : Form
    {
        public FormAddTax()
        {
            InitializeComponent();
        }

        private void buttonAddTax_Click(object sender, EventArgs e)
        {
            int money;
            double addTax;
            const double Tax = 0.1;


            //「金額」テキストボックスの値を整数型変数に取得
            money = int.Parse(textBoxMoney.Text);

            //消費税を加算し税込金額を算出
            addTax = money;
            addTax *= (1 + Tax);
            money = (int)addTax;

            //税込金額をラベルに表示
            labelAddTax.Text = money + " 円 ";
        }
    }
}
