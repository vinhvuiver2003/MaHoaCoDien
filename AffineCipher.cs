using System;
using System.Text;
using System.Windows.Forms;

namespace MaHoaCoDien
{
    public partial class AffineCipher : Form
    {
        public AffineCipher()
        {
            InitializeComponent();
        }
        public int gcd(int a, int b)
        {
            if (b == 0) return a;
            return gcd(b, a % b);
        }
        public int nghichDao(int a, int m)
        {
            for (int i = 1; i < m; i++)
            {
                if ((a * i) % m == 1)
                {
                    return i;
                }
            }
            return -1;
        }

        String encrypt(String plaintext, int a, int b)
        {   String kq = "";
            kq += "Chuỗi plaintext "+plaintext+"\n";
            StringBuilder cipherText = new StringBuilder();
            for (int i = 0; i < plaintext.Length; i++)
            {
                
                char x = char.ToUpper(plaintext[i]);
                if (char.IsLetter(x))
                {
                    int x1 = (int)x - 65;
                    char tg = (char)(((x - 'A') * a + b) % 26 + 'A');
                    kq += "\n\nVới kí tự :" + x + " :" + x1;
                    kq += string.Format("\n({0,2}*{1,2}+{2,2}) mod26 = {3,2}", a, (int)x1, (int)b, (int)tg - 65);
                    kq += "\nThành kí tự :" + tg;
                    cipherText.Append(tg);
                }
                else
                {
                    kq += "\nKí tự không thay đổi +'" + x + "'";
                    cipherText.Append(x);
                }
            }
            kq += "\nKết quả mã hóa :\n"+cipherText.ToString();
            richTextBox1.Text = kq;
            return cipherText.ToString();
            
        }

        String decrypt(String cipherText, int a, int b)
        {
            if (!(gcd(a,26)==1))
            {
                throw new Exception("Không tồn tại nghịch đảo của a");
            }
            String giaiMa="";
            giaiMa += "Chuỗi ciphertext: " + cipherText + "\n";
            StringBuilder plainText = new StringBuilder();
            int a1 = nghichDao(a, 26);
            

            for (int i = 0; i < cipherText.Length; i++)
            {
                char x = char.ToUpper(cipherText[i]);
                int b1 = b % 26;
                if (char.IsLetter(x))
                {
                    int x1 = (int)x - 65;

                    char tg = (char)(((a1 * (x1 - b1 + 26)) % 26) + 'A');
                    giaiMa += "\n\nVới kí tự :" + x+" :"+x1;
                    giaiMa += string.Format("\n{0,2}*({1,2}-{2,2}))mod26 = {3,2}", a1, (int)x1, (int)b, (int)tg-65);
                    giaiMa += "\nThành kí tự :" + tg;
                    
                    plainText.Append(tg);
                }      
                else
                {   
                    giaiMa+= "\nKí tự không thay đổi +'"+x+"'";
                    plainText.Append(x);
                }
            }
            giaiMa += "\n\nKết quả giải mã : " + plainText.ToString();
            richTextBox1.Text = giaiMa;
            
            return plainText.ToString();
        }

        bool checkInput(String x)
        {
            return String.IsNullOrEmpty(x);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            if (checkInput(txtPlaintext.Text) || !int.TryParse(textBox1.Text, out a) || !int.TryParse(textBox2.Text, out b))
            {
                MessageBox.Show("Nhập sai dữ liệu hoặc 'a' không phải là số nguyên tố với 26.");
                return;
            }
            if (nghichDao(a,26)==-1)
            {
                MessageBox.Show("Không tồn tại nghịch đảo của a");
                return;
            }
            textBox3.Text = txtPlaintext.Text;
            textBox4.Text = encrypt(txtPlaintext.Text, a, b);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b;
            if (checkInput(txtPlaintext.Text) || !int.TryParse(textBox1.Text, out a) || !int.TryParse(textBox2.Text, out b) || (nghichDao(a, 26) == -1))
            {
                MessageBox.Show("Nhập sai dữ liệu hoặc 'a' không phải là số nguyên tố với 26.");
                return;
            }
            textBox4.Text = txtPlaintext.Text;
            textBox3.Text = decrypt(txtPlaintext.Text, a, b);
        }

        private void txtPlaintext_TextChanged(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
