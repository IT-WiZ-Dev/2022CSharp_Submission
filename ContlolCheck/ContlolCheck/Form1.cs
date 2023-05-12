namespace ContlolCheck
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

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "チェックボックス:" + checkBox1.Checked;
            label2.Text = "ラジオボタン1:" + radioButton1.Checked;
            label3.Text = "ラジオボタン2:" + radioButton2.Checked;
            label4.Text = "ニューメリックアップダウン:" + numericUpDown1.Value;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "チェックボックス:" + checkBox1.Checked;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "ラジオボタン1:" + radioButton1.Checked;
            label3.Text = "ラジオボタン2:" + radioButton2.Checked;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "ラジオボタン1:" + radioButton1.Checked;
            label3.Text = "ラジオボタン2:" + radioButton2.Checked;
        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            label4.Text = "ニューメリックアップダウン:" + numericUpDown1.Value;
        }
    }
}