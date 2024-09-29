using System.Text;

namespace CaesarCipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public String encrypt(String text, int k)
        {
           
            
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                if (Char.IsLower(c))
                {
                    char tg = (char)(((c - 97 + k) % 26) + 97);
                    result.Append(tg);
                }
                else if (Char.IsUpper(c))
                {
                    char tg = (char)(((c - 65 + k) % 26) + 65);
                    result.Append(tg);
                }
                else
                {
                    result.Append(c);
                }
               
                }
            return result.ToString();
               
        }
        public Boolean isNumber(String text)
        {
            foreach (char x in text)
            {
                if (!char.IsDigit(x))
                {
                    return false;
                    break;
                }
            }
            return true;
        }
        private void btnEnscrypt_Click(object sender, EventArgs e)
        {

            if (textScypt.Text.Equals("")||txtK.Text.Equals("") || !isNumber(txtK.Text.ToString()))
            {
                MessageBox.Show("Chưa nhập số K hoặc nhập số không hợp lệ");
                return;

            }
            String x = textScypt.Text;
            string y = encrypt(x, int.Parse(txtK.Text));
            string result = "Mã ban đầu: " + x + "\n";
            
            result += " mã hóa khóa k: " + int.Parse(txtK.Text) + "\n";
            result += string.Format("{0,10} {1,15} -> {2,25}","lần lặp", "Mã ban đầu", "mã sau biên dịch") + "\n";
            for (int i = 0; i < x.Length; i++)
            {
                result += string.Format("{0,10} {1,15} ->{2,25}", i, x[i], y[i])+"\n";

            }
            result += "Mã sau mã hóa: " + y;
            MessageBox.Show(result);
            enscriptTxt.Text = y;
        }
        public String descypt(String text, int k)
        {
           string y = encrypt(text, 26-k%26);
            return y;
        }

        private void descryptBtn_Click(object sender, EventArgs e)
        {
            if (enscriptTxt.Text.Equals(""))
            {
                MessageBox.Show("Chưa nhập văn bản");
                return;
            }
            if (txtK.Text.Equals("") || !isNumber(txtK.Text.ToString()))
            {
                MessageBox.Show("Chưa nhập số K hoặc nhập số không hợp lệ");
                return;

            }
            
            
            String x = enscriptTxt.Text;
            string y = descypt(x,int.Parse(txtK.Text));
            string result = "Mã đã mã hóa: "+x+"\n";
            result += "Biên dịch lại với mã khóa K " + txtK.Text.ToString() + "\n";
            result += string.Format("{0,10} {1,15} -> {2,25}", "lần lặp", "Mã sau dịch", "mã ban đầu") + "\n";
            for (int i = 0; i < x.Length; i++)
            {
                result += string.Format("{0,10} {1,15} -> {2,25}", i, x[i], y[i]) + "\n";

            }
            result += "Mã ban đầu: "+y;
            MessageBox.Show(result);
            textScypt.Text = y;
        }
    }
}
