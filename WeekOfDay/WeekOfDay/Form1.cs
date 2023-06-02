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
        //　閏年チェック
        private static bool IsLeapYear(int year)
        {
            // 4で割り切れない年はうるう年ではない
            if (year % 4 != 0)
                return false;

            // 100で割り切れるが400で割り切れない年もうるう年ではない
            if (year % 100 == 0 && year % 400 != 0)
                return false;

            // 上記以外の場合はうるう年と判定
            return true;
        }
        //　年月日の妥当性チェック
        private static bool IsValidDate(int year, int month, int day)
        {
            // 月が1から12の範囲内であることを確認
            if (month < 1 || month > 12)
                return false;

            // 日が1から31の範囲内であることを確認
            if (day < 1 || day > 31)
                return false;

            // 月ごとの最大日数を配列で表現
            int[] maxDays = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            // うるう年の場合、2月の最大日数を29に更新
            if (IsLeapYear(year))
                maxDays[1] = 29;

            // 日が月の最大日数を超えていないことを確認
            if (day > maxDays[month - 1])
                return false;

            // 妥当な日付として判定
            return true;
        }
        //曜日チェック
        private static string GetDayOfWeek(int year, int month, int day)
        {

            // ツェラーの公式を使用して曜日を計算する
            int h = (5 * year / 4 - year / 100 + year / 400 + (26 * month + 16) / 10 + day) % 7;

            // 曜日のインデックスに対応する文字列を返す
            string[] daysOfWeek = { "日曜日", "月曜日", "火曜日", "水曜日", "木曜日", "金曜日", "土曜日" };
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
                label4.Text = "西暦年エラー";
                return;
            }

            int month = (int)numericUpDown1.Value;
            int day = (int)numericUpDown2.Value;

            if (!IsValidDate(year, month, day))
            {
                label4.Text = "ありえない日付";
                return;
            }

            string dayOfWeek = GetDayOfWeek(year, month, day);
            label4.Text = dayOfWeek;
        }
    }
}