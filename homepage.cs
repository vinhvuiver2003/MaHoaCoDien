using CaesarCipher;
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
    public partial class homepage : Form
    {
        public homepage()
        {
            InitializeComponent();
        }

        private void btn_caesar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void btn_donbang_Click(object sender, EventArgs e)
        {
            MaHoaDonBang form2 = new MaHoaDonBang();
            form2.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Playfair playfair = new Playfair();
            playfair.ShowDialog();
        }

        private void btn_mahoavie_Click(object sender, EventArgs e)
        {
           VigenereCipher vigenereCipher = new VigenereCipher();
            vigenereCipher.ShowDialog();
        }
    }
}
