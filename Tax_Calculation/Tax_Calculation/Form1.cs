namespace Tax_Calculation
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
            double addTax;
            const double Tax = 0.1;
            int human;
            int spriting_bills;
            int remainder;

            money = int.Parse(textBox1.Text);
            human = int.Parse(textBox2.Text);

            addTax = money;
            addTax *= (1 + Tax);
            money = (int)addTax;

            spriting_bills = money / human;
            remainder = money % human;

            label7.Text = spriting_bills + "‰~";
            label8.Text = remainder + "‰~";


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            label7.Text = "";
            label8.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}