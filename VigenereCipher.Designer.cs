namespace MaHoaCoDien
{
    partial class VigenereCipher
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            btn_encrypt = new Button();
            btn_decrypt = new Button();
            btn_exit = new Button();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(18, 15);
            label1.Name = "label1";
            label1.Size = new Size(88, 28);
            label1.TabIndex = 0;
            label1.Text = "PlainText";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(125, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(280, 34);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(125, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(280, 34);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(18, 74);
            label2.Name = "label2";
            label2.Size = new Size(44, 28);
            label2.TabIndex = 2;
            label2.Text = "Key";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.Location = new Point(125, 128);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(280, 34);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(18, 131);
            label3.Name = "label3";
            label3.Size = new Size(103, 28);
            label3.TabIndex = 4;
            label3.Text = "CipherText";
            // 
            // btn_encrypt
            // 
            btn_encrypt.Font = new Font("Segoe UI", 12F);
            btn_encrypt.Location = new Point(210, 501);
            btn_encrypt.Name = "btn_encrypt";
            btn_encrypt.Size = new Size(121, 43);
            btn_encrypt.TabIndex = 6;
            btn_encrypt.Text = "Encrypt";
            btn_encrypt.UseVisualStyleBackColor = true;
            btn_encrypt.Click += btn_encrypt_Click;
            // 
            // btn_decrypt
            // 
            btn_decrypt.Font = new Font("Segoe UI", 12F);
            btn_decrypt.Location = new Point(349, 501);
            btn_decrypt.Name = "btn_decrypt";
            btn_decrypt.Size = new Size(121, 43);
            btn_decrypt.TabIndex = 7;
            btn_decrypt.Text = "Decrypt";
            btn_decrypt.UseVisualStyleBackColor = true;
            btn_decrypt.Click += btn_decrypt_Click;
            // 
            // btn_exit
            // 
            btn_exit.Font = new Font("Segoe UI", 12F);
            btn_exit.Location = new Point(476, 501);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(121, 43);
            btn_exit.TabIndex = 8;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(125, 221);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(489, 110);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(125, 351);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(489, 110);
            textBox5.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(16, 221);
            label4.Name = "label4";
            label4.Size = new Size(88, 28);
            label4.TabIndex = 11;
            label4.Text = "PlainText";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(16, 351);
            label5.Name = "label5";
            label5.Size = new Size(103, 28);
            label5.TabIndex = 12;
            label5.Text = "CipherText";
            // 
            // VigenereCipher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 591);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(btn_exit);
            Controls.Add(btn_decrypt);
            Controls.Add(btn_encrypt);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "VigenereCipher";
            Text = "VigenereCipher";
            Load += VigenereCipher_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private Button btn_encrypt;
        private Button btn_decrypt;
        private Button btn_exit;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label4;
        private Label label5;
    }
}