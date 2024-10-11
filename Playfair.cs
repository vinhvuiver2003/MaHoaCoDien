using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MaHoaCoDien
{
    public partial class Playfair : Form
    {
        private char[,] matrix = new char[5, 5];

        public Playfair()
        {
            InitializeComponent();
        }

       
        bool validInput(String input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }
        bool checkInput(String input)
        {
            return String.IsNullOrWhiteSpace(input);
        }

        void createPlayFairMatrix(String key)
        {
            key = key.ToUpper().Replace("I", "J");
            HashSet<char> keys = new HashSet<char>();
            int index = 0;

            foreach (char c in key)
            {
                if (c >= 'A' && c <= 'Z' && keys.Add(c))
                {
                    matrix[index / 5, index % 5] = c;
                    index++;
                }
            }

            for (char x = 'A'; x <= 'Z'; x++)
            {
                if (x == 'J')
                {
                    continue;
                }
                else
                {
                    if (keys.Add(x))
                    {
                        matrix[index / 5, index % 5] = x;
                        index++;
                    }
                }
            }
        }

        private (int x, int y) GetPosition(char c)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] == c)
                    {
                        return (i, j);
                    }
                }
            }
            return (-1, -1); 
        }

        private String encrypt(String plainText)
        {

            plainText = plainText.ToUpper().Replace(" ", "").Replace("J", "I");
            List<char> preparedText = PrepareText(plainText);
            string ciphertext = "";

            for (int i = 0; i < preparedText.Count; i += 2)
            {
                char a = preparedText[i];
                char b = preparedText[i + 1];
                var pos1 = GetPosition(a);
                var pos2 = GetPosition(b);

                if (pos1.x == pos2.x)
                {
                    ciphertext += matrix[pos1.x, (pos1.y + 1) % 5];
                    ciphertext += matrix[pos2.x, (pos2.y + 1) % 5];
                }
                else if (pos1.y == pos2.y)
                {
                    ciphertext += matrix[(pos1.x + 1) % 5, pos1.y];
                    ciphertext += matrix[(pos2.x + 1) % 5, pos2.y];
                }
                else
                {
                    ciphertext += matrix[pos1.x, pos2.y];
                    ciphertext += matrix[pos2.x, pos1.y];
                }
            }

            return ciphertext;
        }

        public string Decrypt(string ciphertext)
        {
            ciphertext = ciphertext.ToUpper().Replace(" ", "");
            List<char> preparedText = PrepareText(ciphertext);
            string plaintext = "";

            for (int i = 0; i < preparedText.Count; i += 2)
            {
                char a = preparedText[i];
                char b = preparedText[i + 1];
                var pos1 = GetPosition(a);
                var pos2 = GetPosition(b);

                if (pos1.x == pos2.x)
                {
                    plaintext += matrix[pos1.x, (pos1.y + 4) % 5];
                    plaintext += matrix[pos2.x, (pos2.y + 4) % 5];
                }
                else if (pos1.y == pos2.y)
                {
                    plaintext += matrix[(pos1.x + 4) % 5, pos1.y];
                    plaintext += matrix[(pos2.x + 4) % 5, pos2.y];
                }
                else
                {
                    plaintext += matrix[pos1.x, pos2.y];
                    plaintext += matrix[pos2.x, pos1.y];
                }
            }
            return plaintext.TrimEnd('X');
        }

        private List<char> PrepareText(string text)
        {
            List<char> preparedText = new List<char>();
            for (int i = 0; i < text.Length; i++)
            {
                char c1 = text[i];

                if (c1 < 'A' || c1 > 'Z')
                    continue;
                preparedText.Add(c1);

                if (i + 1 < text.Length)
                {
                    char c2 = text[i + 1];
                    if (c2 < 'A' || c2 > 'Z') continue;
                    if (c1 == c2)
                    {
                        preparedText.Add('X');
                        i--;
                    }
                    else
                    {
                        preparedText.Add(c2);
                        i++;
                    }
                }
                else
                {
                    preparedText.Add('X');
                }
            }
            return preparedText;
        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            if (checkInput(textBox1.Text) || checkInput(textBox2.Text))
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu");
            }
            else
            {
                if (!validInput(textBox2.Text))
                {
                    MessageBox.Show("Lỗi khóa");
                    return;
                }
                try
                {
                    createPlayFairMatrix(textBox2.Text);
                    PrintMatrix();
                    String cipherText = encrypt(textBox1.Text);
                    textBox3.Text = cipherText;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Không xử lý được");
                }
            }
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            if (checkInput(textBox3.Text) || checkInput(textBox2.Text))
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu");
            }
            else
            {
                try
                {
                    if (!validInput(textBox2.Text))
                    {
                        MessageBox.Show("Lỗi khóa");
                        return;
                    }
                    createPlayFairMatrix(textBox2.Text);
                    PrintMatrix();
                    String plainText = Decrypt(textBox3.Text);
                    textBox1.Text = plainText;
                } catch (Exception ex) {
                    MessageBox.Show("Lỗi Không xử lý được");
                }
                
            }
        }

        public void PrintMatrix()
        {
            String x = "Playfair Matrix:\n";
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    x += String.Format("{0,-10}", matrix[i, j]) ;
                }
                x += "\n";
            }
            label4.Text = x;
        }
    }
}
