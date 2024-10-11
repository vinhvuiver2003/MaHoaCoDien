namespace MaHoaCoDien
{
    partial class Playfair
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
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            btn_encrypt = new Button();
            btn_decrypt = new Button();
            btn_exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.Location = new Point(40, 118);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 0;
            label1.Text = "PlainText";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.8F);
            textBox1.Location = new Point(138, 115);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(274, 31);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10.8F);
            textBox2.Location = new Point(138, 168);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(274, 31);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.Location = new Point(40, 171);
            label2.Name = "label2";
            label2.Size = new Size(40, 25);
            label2.TabIndex = 2;
            label2.Text = "Key";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.Location = new Point(40, 224);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 4;
            label3.Text = "Matrix";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F);
            label4.Location = new Point(138, 224);
            label4.Name = "label4";
            label4.Size = new Size(61, 25);
            label4.TabIndex = 5;
            label4.Text = "Matrix";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 10.8F);
            textBox3.Location = new Point(138, 499);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(313, 31);
            textBox3.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F);
            label5.Location = new Point(40, 502);
            label5.Name = "label5";
            label5.Size = new Size(93, 25);
            label5.TabIndex = 6;
            label5.Text = "CipherText";
            // 
            // btn_encrypt
            // 
            btn_encrypt.Font = new Font("Segoe UI", 10.8F);
            btn_encrypt.Location = new Point(463, 114);
            btn_encrypt.Name = "btn_encrypt";
            btn_encrypt.Size = new Size(105, 33);
            btn_encrypt.TabIndex = 8;
            btn_encrypt.Text = "Encrypt";
            btn_encrypt.UseVisualStyleBackColor = true;
            btn_encrypt.Click += btn_encrypt_Click;
            // 
            // btn_decrypt
            // 
            btn_decrypt.Font = new Font("Segoe UI", 10.8F);
            btn_decrypt.Location = new Point(463, 171);
            btn_decrypt.Name = "btn_decrypt";
            btn_decrypt.Size = new Size(105, 33);
            btn_decrypt.TabIndex = 9;
            btn_decrypt.Text = "Decrypt";
            btn_decrypt.UseVisualStyleBackColor = true;
            btn_decrypt.Click += btn_decrypt_Click;
            // 
            // btn_exit
            // 
            btn_exit.Font = new Font("Segoe UI", 10.8F);
            btn_exit.Location = new Point(463, 237);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(105, 33);
            btn_exit.TabIndex = 10;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            // 
            // Playfair
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 583);
            Controls.Add(btn_exit);
            Controls.Add(btn_decrypt);
            Controls.Add(btn_encrypt);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Playfair";
            Text = "Playfair";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private Button btn_encrypt;
        private Button btn_decrypt;
        private Button btn_exit;
    }
}