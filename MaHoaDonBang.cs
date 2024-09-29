﻿using System;
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
        bool inputSelect = false;//kiểm tra xem lựa chọn là nhập hay tạo khóa ngẫu nhiên
        char[] keyInput;//khóa

        Random rand = new Random();

        public MaHoaDonBang()
        {
            InitializeComponent();
        }

        //kiểm tra đầu vào trong th người dùng chọn nhập khóa 
        bool checkKey(String khoa)
        {

            if (khoa.Length == 26 && khoa.All(char.IsLetter) && khoa.Distinct().Count() == 26)
            {
                return true;
            }
            return false;
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

        //mã hóa
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
                    //tìm vị trí của kí tự hiện tại trong alphabet
                    int vt = Array.IndexOf(alphabelUpper, x);
                    if (vt >= 0)
                    {
                        //ánh xạ vị trí của nó lên khóa để có thể lấy được kí tự đã được mã hóa
                        result[i] = khoaHoa[vt];
                    }
                }
                else if (char.IsLower(x))
                {
                    int vt = Array.IndexOf(alphabelLower, x);
                    if (vt >= 0)
                    {
                        result[i] = khoaThuong[vt];
                    }
                }
                else
                {
                    //các trường hợp còn lại thì vẫn thêm kí tự đó vào và không thay đổi
                    result[i] = x;
                }
            }
            return new string(result);
        }

        //giải mã
        String decrypt(String chuoi, string khoa)
        {
            char[] result = new char[chuoi.Length];
            char[] khoaThuong = khoa.ToLower().ToCharArray();
            char[] khoaHoa = khoa.ToUpper().ToCharArray();

            for (int i = 0; i < chuoi.Length; i++)
            {
                char x = chuoi[i];
                //tương tự như mã hóa nhưng đổi ngược lại vị trí
                //thay vì tìm vị trí trong bảng chữ cái thì tìm vị trí trong khóa
                //ánh xạ vị trí đó lên bảng alphabet để giải mã
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
            inputSelect = false;
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
            string khoa = txtKhoa.Text;

            if (inputSelect)
            {
                if (!checkKey(khoa))
                {
                    MessageBox.Show("Khóa không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            txt_Ma.Text = encrypt(banghi, khoa);
        }


        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            string ma = txt_Ma.Text.ToString();
            string khoa = txtKhoa.Text;

            if (inputSelect)
            {
                if (!checkKey(khoa))
                {
                    MessageBox.Show("Khóa không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            txt_BanGhi.Text = decrypt(ma, khoa);
        }


        private void btn_nhap_Click(object sender, EventArgs e)
        {
            txtKhoa.ReadOnly = false;
            inputSelect = true;
        }

        private void txt_Ma_TextChanged(object sender, EventArgs e)
        {
            btn_decrypt.Enabled = !string.IsNullOrWhiteSpace(txt_Ma.Text);
        }

        private void txt_BanGhi_TextChanged(object sender, EventArgs e)
        {
            btn_encrypt.Enabled = !string.IsNullOrWhiteSpace(txt_BanGhi.Text);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
