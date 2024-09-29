namespace MaHoaCoDien
{
    partial class MaHoaDonBang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btn_shuffle = new Button();
            btn_nhap = new Button();
            txtKhoa = new TextBox();
            txt_BanGhi = new TextBox();
            txt_Ma = new TextBox();
            btn_encrypt = new Button();
            btn_decrypt = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(271, 25);
            label1.Name = "label1";
            label1.Size = new Size(328, 50);
            label1.TabIndex = 0;
            label1.Text = "Mã hóa đơn bảng";
            // 
            // btn_shuffle
            // 
            btn_shuffle.Font = new Font("Segoe UI", 12F);
            btn_shuffle.Location = new Point(38, 394);
            btn_shuffle.Name = "btn_shuffle";
            btn_shuffle.Size = new Size(205, 45);
            btn_shuffle.TabIndex = 1;
            btn_shuffle.Text = "Tạo khóa ngẫu nhiên";
            btn_shuffle.UseVisualStyleBackColor = true;
            btn_shuffle.Click += button1_Click;
            // 
            // btn_nhap
            // 
            btn_nhap.Font = new Font("Segoe UI", 12F);
            btn_nhap.Location = new Point(271, 395);
            btn_nhap.Name = "btn_nhap";
            btn_nhap.Size = new Size(140, 43);
            btn_nhap.TabIndex = 2;
            btn_nhap.Text = "Nhập khóa";
            btn_nhap.UseVisualStyleBackColor = true;
            btn_nhap.Click += btn_nhap_Click;
            // 
            // txtKhoa
            // 
            txtKhoa.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtKhoa.Location = new Point(295, 143);
            txtKhoa.Name = "txtKhoa";
            txtKhoa.Size = new Size(477, 38);
            txtKhoa.TabIndex = 3;
            // 
            // txt_BanGhi
            // 
            txt_BanGhi.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_BanGhi.Location = new Point(295, 211);
            txt_BanGhi.Multiline = true;
            txt_BanGhi.Name = "txt_BanGhi";
            txt_BanGhi.Size = new Size(477, 62);
            txt_BanGhi.TabIndex = 4;
            txt_BanGhi.TextChanged += txt_BanGhi_TextChanged;
            // 
            // txt_Ma
            // 
            txt_Ma.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Ma.Location = new Point(295, 298);
            txt_Ma.Multiline = true;
            txt_Ma.Name = "txt_Ma";
            txt_Ma.Size = new Size(477, 61);
            txt_Ma.TabIndex = 5;
            txt_Ma.TextChanged += txt_Ma_TextChanged;
            // 
            // btn_encrypt
            // 
            btn_encrypt.Font = new Font("Segoe UI", 12F);
            btn_encrypt.Location = new Point(447, 395);
            btn_encrypt.Name = "btn_encrypt";
            btn_encrypt.Size = new Size(138, 43);
            btn_encrypt.TabIndex = 6;
            btn_encrypt.Text = "Encrypt";
            btn_encrypt.UseVisualStyleBackColor = true;
            btn_encrypt.Click += btn_encrypt_Click;
            // 
            // btn_decrypt
            // 
            btn_decrypt.Font = new Font("Segoe UI", 12F);
            btn_decrypt.Location = new Point(622, 394);
            btn_decrypt.Name = "btn_decrypt";
            btn_decrypt.Size = new Size(129, 43);
            btn_decrypt.TabIndex = 7;
            btn_decrypt.Text = "Decrypt";
            btn_decrypt.UseVisualStyleBackColor = true;
            btn_decrypt.Click += btn_decrypt_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(195, 148);
            label2.Name = "label2";
            label2.Size = new Size(66, 28);
            label2.TabIndex = 8;
            label2.Text = "Khóa :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(195, 216);
            label3.Name = "label3";
            label3.Size = new Size(77, 28);
            label3.TabIndex = 9;
            label3.Text = "Bản rõ :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(195, 303);
            label4.Name = "label4";
            label4.Size = new Size(90, 28);
            label4.TabIndex = 10;
            label4.Text = "Bản mã : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(195, 96);
            label5.Name = "label5";
            label5.Size = new Size(92, 28);
            label5.TabIndex = 11;
            label5.Text = "Alphabet";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(293, 91);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(477, 38);
            textBox1.TabIndex = 12;
            // 
            // MaHoaDonBang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 490);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_decrypt);
            Controls.Add(btn_encrypt);
            Controls.Add(txt_Ma);
            Controls.Add(txt_BanGhi);
            Controls.Add(txtKhoa);
            Controls.Add(btn_nhap);
            Controls.Add(btn_shuffle);
            Controls.Add(label1);
            Name = "MaHoaDonBang";
            Text = "MaHoaDonBang";
            Load += MaHoaDonBang_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_shuffle;
        private Button btn_nhap;
        private TextBox txtKhoa;
        private TextBox txt_BanGhi;
        private TextBox txt_Ma;
        private Button btn_encrypt;
        private Button btn_decrypt;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
    }
}