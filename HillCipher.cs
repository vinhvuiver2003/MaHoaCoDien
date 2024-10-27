using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Net.Mime.MediaTypeNames;

namespace MaHoaCoDien
{

    public partial class HillCipher : Form
    {
        int cap = 0;
        int[,] matrix;
        int[,] matrandao;
        public HillCipher()
        {
            InitializeComponent();
        }
        bool checkInput(String x)
        {
            if (String.IsNullOrEmpty(x))
            {
                return true;
            }
            foreach (char c in x)
            {
                if (!char.IsLetter(c))
                {
                    return true;
                }
            }
            return false;
        }



        public int dinhThuc(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            if (n == 1)
            {
                return matrix[0, 0];
            }
            else if (n == 2)
            {
                return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            }
            int det = 0;
            for (int i = 0; i < n; i++)
            {
                int[,] subMatrix = taoMaTranCon(matrix, 0, i);
                det += dinhThuc(subMatrix) * (int)Math.Pow(-1, i) * matrix[0, i];

            }
         
            return det;
        }
        public int[,] taoMaTranCon(int[,] matrix, int hang, int cot)
        {
            int n = matrix.GetLength(0);
            int[,] subMatrix = new int[n - 1, n - 1];
            int r = 0;
            for (int i = 0; i < n; i++)
            {
                if (i == hang)
                {
                    continue;
                }
                int c = 0;
                for (int j = 0; j < n; j++)
                {
                    if (j == cot)
                    {
                        continue;
                    }
                    subMatrix[r, c] = matrix[i, j];
                    c++;
                }
                r++;
            }
            return subMatrix;
        }
        public int[,] taoMatranDao(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int det = (int)dinhThuc(matrix);

            int detND = nghichDao(modunIn_26(det), 26);


            int[,] mtp = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    int[,] subMatrix = taoMaTranCon(matrix, i, j);


                    int dtMatrancon = dinhThuc(subMatrix) * (int)Math.Pow(-1, i + j);

                    mtp[j, i] = (modunIn_26((int)(dtMatrancon * detND))) % 26;
                }
            }

            return mtp;
        }


        int _GCD(int a, int b)
        {
            if (a == 0)
            {
                return b;
            }
            if (b == 0)
            {
                return a;
            }
            return _GCD(b % a, a);
        }
        int modunIn_26(int n)
        {
            return (n > 0) ? n % 26 : 26 - Math.Abs(n) % 26;
        }

        private int[,] GetMatrixValues(int n)
        {
            int[,] matrix = new int[n, n];
            int index = 0;

            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is TextBox textBox)
                {
                    int value;
                    if (int.TryParse(textBox.Text, out value))
                    {
                        matrix[index / n, index % n] = value;
                        index++;
                    }
                    else
                    {
                        MessageBox.Show($"Giá trị nhập vào ma trận không hợp lệ trong ô: {textBox.Name}");
                        return null;
                    }
                }
            }
            return matrix;
        }
        public string encrypt(string plainText, int[,] matrix)
        {
            StringBuilder cipherText = new StringBuilder();
            int n = matrix.GetLength(0);


            while (plainText.Length % n != 0)
            {
                plainText += 'X';
            }

            for (int i = 0; i < plainText.Length; i += n)
            {
                int[] arr = new int[n];


                for (int j = 0; j < n; j++)
                {
                    arr[j] = plainText[i + j] - 65;
                }


                for (int j = 0; j < n; j++)
                {
                    int sum = 0;
                    for (int x = 0; x < n; x++)
                    {
                        sum += arr[x] * matrix[j, x];
                    }

                    cipherText.Append((char)((sum % 26) + 'A'));
                }
            }

            return cipherText.ToString();
        }


        string decrypt(string cipherText, int[,] matrix)
        {
            StringBuilder plainText = new StringBuilder();
            int n = matrix.GetLength(0);
            int[] arr = new int[n];
            for (int i = 0; i < cipherText.Length; i += n)
            {

                for (int j = 0; j < n; j++)
                {
                    if (i + j < cipherText.Length)
                    {
                        arr[j] = cipherText[i + j] - 65;
                    }
                    else
                    {
                        arr[j] = 'X' - 65;
                    }
                }


                for (int j = 0; j < n; j++)
                {
                    int sum = 0;
                    for (int x = 0; x < n; x++)
                    {
                        int q = arr[x] * matrix[j, x];
                        sum += q;
                    }

                    plainText.Append((char)((sum % 26) + 65));
                }
            }
            return plainText.ToString();
        }
        private void btn_encrypt_Click(object sender, EventArgs e)
        {

            String text = txtInput.Text.ToUpper().Replace(" ", "");
            if (checkInput(text))
            {

                MessageBox.Show("plaintext phải là chữ cái và không có kí tự đặc biệt");
                txtInput.Focus();
                return;
            }
            txtInput.Clear();
            rtb_Ciphertext.Text = encrypt(text, matrix);
            rtb_plainText.Text = text;

        }

        int nghichDao(int a, int m)
        {
            int m0 = m, t, q;
            int x0 = 0, x1 = 1;


            while (a > 1)
            {

                q = a / m;
                t = m;

                m = a % m;
                a = t;
                t = x0;

                x0 = x1 - q * x0;
                x1 = t;
            }


            if (x1 < 0)
                x1 += m0;

            return x1;
        }


        private void btn_nhapk_Click(object sender, EventArgs e)
        {

        }

        private void btn_tinh_Click(object sender, EventArgs e)
        {
            btn_encrypt.Enabled = true;
            if (GetMatrixValues(cap) == null)
            {
                MessageBox.Show("Lỗi nhập ma trận");
                return;
            }

            matrix = GetMatrixValues(cap);
            int det = dinhThuc(matrix);
            if (det == 0)
            {
                MessageBox.Show("Không tồn tại ma trận đảo ngược");
                return;
            }
            if (_GCD(modunIn_26((int)det), 26) != 1)
            {
                MessageBox.Show("Không tồn tại Khả nghịch của k trong 26");
                return;
            }
            String matrixNghich = "";
            matrandao = taoMatranDao(matrix);
            for (int i = 0; i < cap; i++)
            {
                for (int j = 0; j < cap; j++)
                {
                    matrixNghich += (matrandao[i, j]) + " ";
                }
                matrixNghich += "\n";
            }
            richTextBox1.Text = matrixNghich;
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            String text = txtInput.Text.ToUpper().Replace(" ", "");
            if (checkInput(text))
            {
                MessageBox.Show("plaintext phải là chữ cái và không có kí tự đặc biệt");
                txtInput.Focus();
                return;
            }

            rtb_plainText.Text = decrypt(text, matrandao);
            rtb_Ciphertext.Text = text;
        }

        private void HillCipher_Load(object sender, EventArgs e)
        {
            taoMatrantext(2);
            btn_encrypt.Enabled = false;
            cap = 2;
        }
        private void taoMatrantext(int n)
        {
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowCount = n;
            tableLayoutPanel1.ColumnCount = n;

            for (int i = 0; i < n; i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / n));
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / n));
            }
            for (int i = 0; i < n * n; i++)
            {
                TextBox textBox = new TextBox()
                {
                    Multiline = true,
                    Dock = DockStyle.Top,
                    Width = 100,
                    Height = 100,
                    Name = $"o_thu_{i}"
                };
                tableLayoutPanel1.Controls.Add(textBox);
            }

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("2x2"))
            {
                cap = 2;
                taoMatrantext(2);

            }
            else if (comboBox1.Text.Equals("3x3"))
            {
                cap = 3;
                taoMatrantext(3);

            }
            else if (comboBox1.Text.Equals("4x4"))
            {
                cap = 4;
                taoMatrantext(4);
            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            rtb_plainText.Clear();
            rtb_Ciphertext.Clear();
        }
    }
}
