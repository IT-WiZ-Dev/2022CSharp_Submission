using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'A')
                label1.Text = "A";
            else    // A以外の文字を入力したらそのまま表示
                label1.Text = e.KeyChar.ToString();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
                label2.Text = "A か a";
            else    // A以外の文字を入力したらそのまま表示
                label2.Text = e.KeyCode.ToString();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            label3.Text = "Clickイベント";
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            label3.Text = "DoubleClickイベント";
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            label4.Text = "MouseClickイベント";

            if (e.Button == MouseButtons.Left)
                label5.Text = "左ボタンクリック";
            else if (e.Button == MouseButtons.Middle)
                label5.Text = "中央ボタンクリック";
            else if (e.Button == MouseButtons.Right)
                label5.Text = "右ボタンクリック";
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            label6.Text = "MouseDownイベント";
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            label7.Text = "MouseHoverイベント";
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            label7.Text = "MouseLeaveイベント";
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label8.Text = "MouseMoveイベント";
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            label6.Text = "MouseUpイベント";
        }
    }
}
