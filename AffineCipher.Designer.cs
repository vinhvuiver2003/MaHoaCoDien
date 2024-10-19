namespace MaHoaCoDien
{
    partial class AffineCipher
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
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtPlaintext = new TextBox();
            button1 = new Button();
            button2 = new Button();
            textBox3 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label1.Location = new Point(609, 69);
            label1.Name = "label1";
            label1.Size = new Size(96, 31);
            label1.TabIndex = 0;
            label1.Text = "Nhập a:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.Location = new Point(609, 144);
            label2.Name = "label2";
            label2.Size = new Size(104, 31);
            label2.TabIndex = 1;
            label2.Text = "Nhập b: ";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            textBox1.Location = new Point(711, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(48, 38);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            textBox2.Location = new Point(711, 141);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(48, 38);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label3.Location = new Point(615, 201);
            label3.Name = "label3";
            label3.Size = new Size(90, 31);
            label3.TabIndex = 4;
            label3.Text = "M = 26";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label4.Location = new Point(31, 69);
            label4.Name = "label4";
            label4.Size = new Size(72, 31);
            label4.TabIndex = 5;
            label4.Text = "input";
            // 
            // txtPlaintext
            // 
            txtPlaintext.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtPlaintext.Location = new Point(156, 69);
            txtPlaintext.Name = "txtPlaintext";
            txtPlaintext.Size = new Size(199, 38);
            txtPlaintext.TabIndex = 6;
            txtPlaintext.TextChanged += txtPlaintext_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button1.Location = new Point(156, 448);
            button1.Name = "button1";
            button1.Size = new Size(167, 70);
            button1.TabIndex = 9;
            button1.Text = "Encrypt";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button2.Location = new Point(459, 448);
            button2.Name = "button2";
            button2.Size = new Size(140, 70);
            button2.TabIndex = 10;
            button2.Text = "Decrypt";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            textBox3.Location = new Point(156, 141);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(443, 82);
            textBox3.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label6.Location = new Point(31, 174);
            label6.Name = "label6";
            label6.Size = new Size(119, 31);
            label6.TabIndex = 12;
            label6.Text = "Plain Text";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            textBox4.Location = new Point(156, 247);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(443, 82);
            textBox4.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label7.Location = new Point(31, 278);
            label7.Name = "label7";
            label7.Size = new Size(129, 31);
            label7.TabIndex = 14;
            label7.Text = "CipherText";
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Right;
            richTextBox1.Location = new Point(793, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(408, 591);
            richTextBox1.TabIndex = 15;
            richTextBox1.Text = "";
            // 
            // AffineCipher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 591);
            Controls.Add(richTextBox1);
            Controls.Add(label7);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtPlaintext);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AffineCipher";
            Text = "AffineCipher";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private TextBox txtPlaintext;
        private Button button1;
        private Button button2;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox4;
        private Label label7;
        private RichTextBox richTextBox1;
    }
}