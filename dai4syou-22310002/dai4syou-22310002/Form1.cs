using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dai4syou_22310002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void youbidasu_Click(object sender, EventArgs e)
        {
            int nen = 0;
            label1.Text = "";
            try
            {
                 nen = int.Parse(textBox1.Text);
            }
            catch (FormatException ex)
            {
                label1.Text = "西暦年エラー";
               
            }

            int tuki = (int)numericUpDown1.Value;
            int hi = (int)numericUpDown2.Value;
            int W =0;
            if (nen > 0)
            {
                if ((nen % 4 == 0 && nen / 100 != 0) || (nen / 400 == 0))
                {
                    if (tuki == 1 || tuki == 3 || tuki == 5 || tuki == 7 || tuki == 8 || tuki == 10 || tuki == 12)
                    {
                        if (tuki == 1)
                        {
                            nen = nen - 1;
                            tuki = tuki + 12;
                        }
                        W = (5 * nen / 4 - nen / 100 + nen / 400 + (26 * tuki + 16) / 10 + hi) % 7;
                    }
                    else if (tuki == 2)
                    {
                        if (hi > 29)
                        {
                            label1.Text = "ありえない日付";
                        }
                        else
                        {

                            nen = nen - 1;
                            W = (5 * nen / 4 - nen / 100 + nen / 400 + (26 * 14 + 16) / 10 + hi) % 7;
                        }
                    }
                    else
                    {
                        if (hi > 30)
                        {
                            label1.Text = "ありえない日付";
                        }
                        else
                        {
                            W = (5 * nen / 4 - nen / 100 + nen / 400 + (26 * tuki + 16) / 10 + hi) % 7;
                        }
                    }



                }//うる年
                else
                {
                    if (tuki == 1 || tuki == 3 || tuki == 5 || tuki == 7 || tuki == 8 || tuki == 10 || tuki == 12)
                    {
                        if (tuki == 1)
                        {
                            nen = nen - 1;
                            tuki = tuki + 12;
                        }
                        W = (5 * nen / 4 - nen / 100 + nen / 400 + (26 * tuki + 16) / 10 + hi) % 7;
                    }
                    else if (tuki == 2)
                    {
                        if (hi > 28)
                        {
                            label1.Text = "ありえない日付";
                        }
                        else
                        {
                            nen = nen - 1;
                            W = ((5 * nen) / 4 - nen / 100 + nen / 400 + ((26 * 14) + 16) / 10 + hi) % 7;
                        }
                    }
                    else
                    {
                        if (hi > 30)
                        {
                            label1.Text = "ありえない日付";
                        }
                        else
                        {
                            W = (5 * nen / 4 - nen / 100 + nen / 400 + (26 * tuki + 16) / 10 + hi) % 7;
                        }
                    }
                }//うる年じゃない
                if (label1.Text == "")
                {
                    string ww = W.ToString();
                    label1.Text = ww;
                    if (ww == "0")
                    {
                        label1.Text = "日曜日";
                    }
                    else if (ww == "1")
                    {
                        label1.Text = "月曜日";
                    }
                    else if (ww == "2")
                    {
                        label1.Text = "火曜日";
                    }
                    else if (ww == "3")
                    {
                        label1.Text = "水曜日";
                    }
                    else if (ww == "4")
                    {
                        label1.Text = "木曜日";
                    }
                    else if (ww == "5")
                    {
                        label1.Text = "金曜日";
                    }

                    else if (ww == "6")
                    {
                        label1.Text = "土曜日";
                    }


                }




            }
            else
            {
                label1.Text = "西暦年エラー";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
