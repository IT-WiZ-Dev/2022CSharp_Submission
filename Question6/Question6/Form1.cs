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

        private void Form1_Load(object sender, EventArgs e)
        {
            label5000yen.Text = "";
            label1000yen.Text = "";
            label500yen.Text = "";
            label100yen.Text = "";
            label50yen.Text = "";
            label10yen.Text = "";
            label5yen.Text = "";
            label1yen.Text = "";
        }

        private void buttonCul_Click(object sender, EventArgs e)
        {
            int change = NumCheck(textBoxChange.Text);
            if(change == -1)
            {
                return;
            }

            int[] change_num = new int[] { 5000, 1000, 500, 100, 50, 10, 5, 1 };
            for(int i = 0; i < change_num.Length; i++)
            {
                int tmp = change_num[i];
                change_num[i] = change / change_num[i];
                change = change % tmp;
            }

            label5000yen.Text = change_num[0].ToString();
            label1000yen.Text = change_num[1].ToString();
            label500yen.Text = change_num[2].ToString();
            label100yen.Text = change_num[3].ToString();
            label50yen.Text = change_num[4].ToString();
            label10yen.Text = change_num[5].ToString();
            label5yen.Text = change_num[6].ToString();
            label1yen.Text = change_num[7].ToString();

        }

        public int NumCheck(string s)
        {
            int result;
            if (int.TryParse(s, out result))
            {
                result = int.Parse(textBoxChange.Text);
                if(result < 0)
                {
                    System.Windows.Forms.MessageBox.Show("入力が正しくありません。", "確認");
                    result = -1;
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("入力が正しくありません。", "確認");
                result = -1;
            }
            return result;
        }
    }
}
