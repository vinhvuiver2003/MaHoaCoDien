using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MaHoaCoDien
{
    public partial class MahoaHang : Form
    {
        public MahoaHang()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string plaintext = txtPlaintext.Text;
            string key = txtKey.Text;
            if (txtKey.Text == "")
            {
                MessageBox.Show("Chưa nhập khóa.");
            }

            if (!IsNumeric(key))
            {
                MessageBox.Show("Khóa chỉ được nhập số.");
                return;
            }
            if (!IsUnique(key))
            {
                MessageBox.Show("Khóa không được trùng lặp.");
                return;
            }
            if (txtPlaintext.Text == "")
            {
                MessageBox.Show("Chưa nhập bản rõ.");
            }
            string ciphertext = Encrypt(plaintext, key);
            txtoutput.Text = ciphertext;
            lblMatrix.Text = "Matrix:\n" + PrintMatrixWithIndex(GenerateEncryptMatrix(plaintext, key));
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string ciphertext = txtCipherText.Text;
            string key = txtKey.Text;

            if (txtKey.Text == "")
            {
                MessageBox.Show("Chưa nhập khóa.");
            }
            if (!IsNumeric(key))
            {
                MessageBox.Show("Khóa chỉ được nhập số.");
                return;
            }
            if (!IsUnique(key))
            {
                MessageBox.Show("Khóa không được trùng lặp.");
                return;
            }
            if (txtCipherText.Text == "")
            {
                MessageBox.Show("Chưa nhập bản mã.");
            }
            List<List<char>> decryptedMatrix = GenerateDecryptedMatrix(ciphertext, key);
            lblMatrix.Text = "Matrix *:\n" + PrintMatrixWithIndex(decryptedMatrix);
            string decryptedText = Decrypt(ciphertext, key, decryptedMatrix);
            lblMatrix.Text += "\nMatrix:\n" + PrintMatrixWithIndex(decryptedMatrix);
            txtoutput.Text = decryptedText;
        }
        private bool IsNumeric(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsDigit(c)) 
                {
                    return false;
                }
            }
            return true; 
        }

        private bool IsUnique(string str)
        {
            HashSet<char> charSet = new HashSet<char>();
            foreach (char c in str)
            {
                if (!charSet.Add(c)) 
                {
                    return false; 
                }
            }
            return true; 
        }

        private string Encrypt(string plaintext, string key)
        {
            string ciphertext = "";
            List<List<char>> charGroups = new List<List<char>>();
            int count = 0;
            while (count < plaintext.Length)
            {
                List<char> group = new List<char>();
                for (int i = 0; i < key.Length; i++)
                {
                    if (count == plaintext.Length)
                        break;
                    group.Add(plaintext[count]);
                    count++;
                }
                charGroups.Add(group);
            }
            char[] sortedKeyArray = key.ToCharArray();
            Array.Sort(sortedKeyArray);
            string sortedKey = new string(sortedKeyArray);
            for (int x = 0; x < sortedKey.Length; x++)
            {
                int originalIndex = key.IndexOf(sortedKey[x]);
                foreach (List<char> group in charGroups)
                {
                    if (group.Count > originalIndex)
                        ciphertext += group[originalIndex];
                }
            }

            return ciphertext;
        }

        private string Decrypt(string ciphertext, string key, List<List<char>> charGroups)
        {
            string plaintext = "";
            int count = 0;
            for (int i = 0; i < key.Length; i++)
            {
                for (int j = 0; j < charGroups.Count; j++)
                {
                    int index = nextIndex(i, key);
                    if (charGroups[j][index] == '*')
                    {
                        if (count < ciphertext.Length)
                        {
                            charGroups[j][index] = ciphertext[count];
                            count++;
                        }
                    }
                }
            }
            foreach (var group in charGroups)
            {
                foreach (var character in group)
                {
                    if (character != '.')
                    {
                        plaintext += character;
                    }
                }
            }

            return plaintext;
        }

        private List<List<char>> GenerateEncryptMatrix(string plaintext, string key)
        {
            List<List<char>> charGroups = new List<List<char>>();
            int count = 0;
            while (count < plaintext.Length)
            {
                List<char> group = new List<char>();
                for (int i = 0; i < key.Length; i++)
                {
                    if (count == plaintext.Length)
                        break;
                    group.Add(plaintext[count]);
                    count++;
                }
                charGroups.Add(group);
            }
            return charGroups;
        }

        private List<List<char>> GenerateDecryptedMatrix(string ciphertext, string key)
        {
            List<List<char>> charGroups = new List<List<char>>();
            int count = 0;
            while (count < ciphertext.Length)
            {
                List<char> group = new List<char>();
                for (int i = 0; i < key.Length; i++)
                {
                    if (count < ciphertext.Length)
                    {
                        group.Add('*'); 
                        count++;
                    }
                    else
                    {
                        group.Add('.'); 
                    }
                }
                charGroups.Add(group);
            }
            return charGroups;
        }

        private string PrintMatrixWithIndex(List<List<char>> charGroups)
        {
            string result = "  ";
            foreach (char c in txtKey.Text)
            {
                result += $" {c} ";
            }
            result += "\n";

            foreach (var group in charGroups)
            {
                result += string.Join("  ", group);
                result += "\n";
            }
            return result.Trim();
        }
        private int nextIndex(int current, string key)
        {
            List<int> keyValues = new List<int>();
            foreach (var c in key)
            {
                keyValues.Add(Convert.ToInt16(c));
            }
            keyValues.Sort();
            int targetValue = keyValues[current];
            for (int i = 0; i < key.Length; i++)
            {
                if (Convert.ToInt16(key[i]) == targetValue)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
