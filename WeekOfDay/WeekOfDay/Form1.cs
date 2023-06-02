using System.Security.Policy;
using System.Windows.Forms;

namespace WindowsFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //�@�[�N�`�F�b�N
        private static bool IsLeapYear(int year)
        {
            // 4�Ŋ���؂�Ȃ��N�͂��邤�N�ł͂Ȃ�
            if (year % 4 != 0)
                return false;

            // 100�Ŋ���؂�邪400�Ŋ���؂�Ȃ��N�����邤�N�ł͂Ȃ�
            if (year % 100 == 0 && year % 400 != 0)
                return false;

            // ��L�ȊO�̏ꍇ�͂��邤�N�Ɣ���
            return true;
        }
        //�@�N�����̑Ó����`�F�b�N
        private static bool IsValidDate(int year, int month, int day)
        {
            // ����1����12�͈͓̔��ł��邱�Ƃ��m�F
            if (month < 1 || month > 12)
                return false;

            // ����1����31�͈͓̔��ł��邱�Ƃ��m�F
            if (day < 1 || day > 31)
                return false;

            // �����Ƃ̍ő������z��ŕ\��
            int[] maxDays = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            // ���邤�N�̏ꍇ�A2���̍ő������29�ɍX�V
            if (IsLeapYear(year))
                maxDays[1] = 29;

            // �������̍ő�����𒴂��Ă��Ȃ����Ƃ��m�F
            if (day > maxDays[month - 1])
                return false;

            // �Ó��ȓ��t�Ƃ��Ĕ���
            return true;
        }
        //�j���`�F�b�N
        private static string GetDayOfWeek(int year, int month, int day)
        {

            // �c�F���[�̌������g�p���ėj�����v�Z����
            int h = (5 * year / 4 - year / 100 + year / 400 + (26 * month + 16) / 10 + day) % 7;

            // �j���̃C���f�b�N�X�ɑΉ����镶�����Ԃ�
            string[] daysOfWeek = { "���j��", "���j��", "�Ηj��", "���j��", "�ؗj��", "���j��", "�y�j��" };
            return daysOfWeek[h];
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int year) || year < 0)
            {
                label4.Text = "����N�G���[";
                return;
            }

            int month = (int)numericUpDown1.Value;
            int day = (int)numericUpDown2.Value;

            if (!IsValidDate(year, month, day))
            {
                label4.Text = "���肦�Ȃ����t";
                return;
            }

            string dayOfWeek = GetDayOfWeek(year, month, day);
            label4.Text = dayOfWeek;
        }
    }
}