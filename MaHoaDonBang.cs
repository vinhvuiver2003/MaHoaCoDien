using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaHoaCoDien
{
    public partial class MaHoaDonBang : Form
    {
        char[] alphabelUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        char[] alphabelLower = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        bool inputSelect = false;
        char[] keyInput;

        Random rand = new Random();

        public MaHoaDonBang()
        {
            InitializeComponent();
        }

        void Shuffle_Key(char[] array)
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                char temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }

        String encrypt(String chuoi, string khoa)
        {
            char[] result = new char[chuoi.Length];
            char[] khoaThuong = khoa.ToLower().ToCharArray();
            char[] khoaHoa = khoa.ToUpper().ToCharArray();

            for (int i = 0; i < chuoi.Length; i++)
            {
                char x = chuoi[i];
                if (char.IsUpper(x))
                {
                    int vt = Array.IndexOf(alphabelUpper, x);
                    if (vt >= 0)
                        result[i] = khoaHoa[vt];
                }
                else if (char.IsLower(x))
                {
                    int vt = Array.IndexOf(alphabelLower, x);
                    if (vt >= 0)
                        result[i] = khoaThuong[vt];
                }
                else
                {
                    result[i] = x;
                }
            }
            return new string(result);
        }

        String decrypt(String chuoi, string khoa)
        {
            char[] result = new char[chuoi.Length];
            char[] khoaThuong = khoa.ToLower().ToCharArray();
            char[] khoaHoa = khoa.ToUpper().ToCharArray();

            for (int i = 0; i < chuoi.Length; i++)
            {
                char x = chuoi[i];
                if (char.IsUpper(x))
                {
                    int vt = Array.IndexOf(khoaHoa, x);
                    if (vt >= 0)
                        result[i] = alphabelUpper[vt];
                }
                else if (char.IsLower(x))
                {
                    int vt = Array.IndexOf(khoaThuong, x);
                    if (vt >= 0)
                        result[i] = alphabelLower[vt];
                }
                else
                {
                    result[i] = x;
                }
            }
            return new string(result);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtKhoa.ReadOnly = true;
            btn_decrypt.Enabled = true;
            btn_encrypt.Enabled = true;

            keyInput = new char[alphabelLower.Length];
            alphabelLower.CopyTo(keyInput, 0);
            Shuffle_Key(keyInput);
            txtKhoa.Text = new string(keyInput);
        }

        private void MaHoaDonBang_Load(object sender, EventArgs e)
        {
            txtKhoa.ReadOnly = true;
            btn_decrypt.Enabled = false;
            btn_encrypt.Enabled = false;
            textBox1.Text = "abcdefghijklmnopqrstuvwxyz";
        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            string banghi = txt_BanGhi.Text.ToString();
            txt_Ma.Text = encrypt(banghi, new string(keyInput));
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            string ma = txt_Ma.Text.ToString();
            txt_BanGhi.Text = decrypt(ma, new string(keyInput));
        }

        private void btn_nhap_Click(object sender, EventArgs e)
        {
            txtKhoa.ReadOnly = false;
        }

        private void txt_Ma_TextChanged(object sender, EventArgs e)
        {
            btn_decrypt.Enabled = false;
            btn_decrypt.Enabled = true;
            txt_Ma.Clear();
        }

        private void txt_BanGhi_TextChanged(object sender, EventArgs e)
        {
            btn_encrypt.Enabled = true;
            btn_decrypt.Enabled = false;
            txt_BanGhi.Clear();
        }
    }
}
