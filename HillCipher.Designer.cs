namespace MaHoaCoDien
{
    partial class HillCipher
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
            txtInput = new TextBox();
            btn_encrypt = new Button();
            btn_tinh = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btn_decrypt = new Button();
            comboBox1 = new ComboBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            richTextBox1 = new RichTextBox();
            rtb_plainText = new RichTextBox();
            label2 = new Label();
            label6 = new Label();
            rtb_Ciphertext = new RichTextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label1.Location = new Point(30, 41);
            label1.Name = "label1";
            label1.Size = new Size(72, 31);
            label1.TabIndex = 0;
            label1.Text = "Input";
            // 
            // txtInput
            // 
            txtInput.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtInput.Location = new Point(180, 38);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(238, 38);
            txtInput.TabIndex = 1;
            txtInput.TextChanged += txtInput_TextChanged;
            // 
            // btn_encrypt
            // 
            btn_encrypt.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn_encrypt.Location = new Point(829, 238);
            btn_encrypt.Name = "btn_encrypt";
            btn_encrypt.Size = new Size(143, 55);
            btn_encrypt.TabIndex = 2;
            btn_encrypt.Text = "Encrypt";
            btn_encrypt.UseVisualStyleBackColor = true;
            btn_encrypt.Click += btn_encrypt_Click;
            // 
            // btn_tinh
            // 
            btn_tinh.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn_tinh.Location = new Point(829, 161);
            btn_tinh.Name = "btn_tinh";
            btn_tinh.Size = new Size(143, 55);
            btn_tinh.TabIndex = 9;
            btn_tinh.Text = "Tính toán";
            btn_tinh.UseVisualStyleBackColor = true;
            btn_tinh.Click += btn_tinh_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label3.Location = new Point(31, 160);
            label3.Name = "label3";
            label3.Size = new Size(157, 31);
            label3.TabIndex = 10;
            label3.Text = "Ma trận khóa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label4.Location = new Point(456, 160);
            label4.Name = "label4";
            label4.Size = new Size(225, 31);
            label4.TabIndex = 11;
            label4.Text = "Ma trận nghịch đảo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label5.Location = new Point(33, 95);
            label5.Name = "label5";
            label5.Size = new Size(141, 31);
            label5.TabIndex = 13;
            label5.Text = "Ma trận cấp";
            // 
            // btn_decrypt
            // 
            btn_decrypt.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn_decrypt.Location = new Point(829, 313);
            btn_decrypt.Name = "btn_decrypt";
            btn_decrypt.Size = new Size(143, 55);
            btn_decrypt.TabIndex = 19;
            btn_decrypt.Text = "Decrypt";
            btn_decrypt.UseVisualStyleBackColor = true;
            btn_decrypt.Click += btn_decrypt_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "2x2", "3x3", "4x4" });
            comboBox1.Location = new Point(180, 98);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(88, 28);
            comboBox1.TabIndex = 20;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tableLayoutPanel1.Location = new Point(39, 194);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(383, 282);
            tableLayoutPanel1.TabIndex = 21;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(468, 209);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(222, 202);
            richTextBox1.TabIndex = 23;
            richTextBox1.Text = "";
            // 
            // rtb_plainText
            // 
            rtb_plainText.Location = new Point(180, 528);
            rtb_plainText.Name = "rtb_plainText";
            rtb_plainText.ReadOnly = true;
            rtb_plainText.Size = new Size(356, 55);
            rtb_plainText.TabIndex = 24;
            rtb_plainText.Text = "";
            rtb_plainText.TextChanged += richTextBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.Location = new Point(45, 540);
            label2.Name = "label2";
            label2.Size = new Size(111, 31);
            label2.TabIndex = 25;
            label2.Text = "Plaintext";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label6.Location = new Point(45, 599);
            label6.Name = "label6";
            label6.Size = new Size(129, 31);
            label6.TabIndex = 27;
            label6.Text = "CipherText";
            // 
            // rtb_Ciphertext
            // 
            rtb_Ciphertext.Location = new Point(180, 589);
            rtb_Ciphertext.Name = "rtb_Ciphertext";
            rtb_Ciphertext.ReadOnly = true;
            rtb_Ciphertext.Size = new Size(356, 55);
            rtb_Ciphertext.TabIndex = 26;
            rtb_Ciphertext.Text = "";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button1.Location = new Point(829, 392);
            button1.Name = "button1";
            button1.Size = new Size(143, 55);
            button1.TabIndex = 28;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // HillCipher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 652);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(rtb_Ciphertext);
            Controls.Add(label2);
            Controls.Add(rtb_plainText);
            Controls.Add(richTextBox1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(comboBox1);
            Controls.Add(btn_decrypt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btn_tinh);
            Controls.Add(btn_encrypt);
            Controls.Add(txtInput);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "HillCipher";
            Text = "HillCipher";
            Load += HillCipher_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtInput;
        private Button btn_encrypt;
        private Button btn_tinh;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btn_decrypt;
        private ComboBox comboBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private RichTextBox richTextBox1;
        private RichTextBox rtb_plainText;
        private Label label2;
        private Label label6;
        private RichTextBox rtb_Ciphertext;
        private Button button1;
    }
}