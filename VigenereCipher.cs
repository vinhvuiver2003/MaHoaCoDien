using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaHoaCoDien
{
    public partial class VigenereCipher : Form
    {
        public VigenereCipher()
        {
            InitializeComponent();
        }
        bool validInput(String text, String key)
        {
            if (String.IsNullOrWhiteSpace(text) || String.IsNullOrWhiteSpace(key))
            {
                return false;
            }
            foreach (char c in key)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }

            }
            return true;
        }
        public String encrypt(String plainText, string key)
        {
            StringBuilder cipherText = new StringBuilder();
            int m = key.Length;
            int index = 0;
            for (int i = 0; i < plainText.Length; i++)
            {
                char c = plainText[i];
                char d = key[index % m];
                if (char.IsLetter(c))
                {
                    char tg = (char)((c + d - 2 * 97) % 26 + 97);
                    cipherText.Append(tg);
                    index++;
                }
                else
                {
                    cipherText.Append(c);
                }
            }

            return cipherText.ToString();
        }
        private string decrypt(String cipherText, String key)
        {
            StringBuilder plainText = new StringBuilder();
            int m = key.Length;
            int index = 0;
            for (int i = 0; i < cipherText.Length; i++)
            {
                char c = cipherText[i];
                char d = key[index % m];
                if (char.IsLetter(c))
                {
                    char tg = (char)((c - d + 26) % 26 + 97);
                    plainText.Append(tg);
                    index++;
                }
                else
                {
                    plainText.Append(c);
                }
            }

            return plainText.ToString();

        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            if (!validInput(textBox1.Text, textBox2.Text))
            {
                MessageBox.Show("chưa nhập đúng, nhập lại:");
            }
            else
            {
                String x = encrypt(textBox1.Text.ToLower(), textBox2.Text.ToLower().Replace(" ", ""));
                textBox3.Text = x;
                textBox4.Text = textBox1.Text;
                textBox5.Text = x;
                textBox3.Clear();
                textBox1.Clear();
            }

        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            if (!validInput(textBox3.Text, textBox2.Text))
            {
                MessageBox.Show("chưa nhập đúng, nhập lại:");
            }
            else
            {
                String x = decrypt(textBox3.Text.ToLower(), textBox2.Text.ToLower().Replace(" ", ""));
                textBox1.Text = x;
                textBox4.Text = x;
                textBox5.Text = textBox3.Text;
                textBox3.Clear();
                textBox1.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btn_decrypt.Enabled = false;
            btn_encrypt.Enabled = true;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            btn_encrypt.Enabled = false;
            btn_decrypt.Enabled = true;


        }

        private void VigenereCipher_Load(object sender, EventArgs e)
        {
            btn_encrypt.Enabled = false;
            btn_decrypt.Enabled = false;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

