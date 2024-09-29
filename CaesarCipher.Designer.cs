namespace CaesarCipher
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEnscrypt = new Button();
            label1 = new Label();
            textScypt = new TextBox();
            label2 = new Label();
            enscriptTxt = new TextBox();
            label3 = new Label();
            txtK = new TextBox();
            descryptBtn = new Button();
            label4 = new Label();
            btn_exit = new Button();
            SuspendLayout();
            // 
            // btnEnscrypt
            // 
            btnEnscrypt.Font = new Font("Segoe UI", 12F);
            btnEnscrypt.Location = new Point(681, 177);
            btnEnscrypt.Name = "btnEnscrypt";
            btnEnscrypt.Size = new Size(103, 58);
            btnEnscrypt.TabIndex = 0;
            btnEnscrypt.Text = "Enscrypt";
            btnEnscrypt.UseVisualStyleBackColor = true;
            btnEnscrypt.Click += btnEnscrypt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(66, 192);
            label1.Name = "label1";
            label1.Size = new Size(134, 28);
            label1.TabIndex = 1;
            label1.Text = "Nhập văn bản";
            // 
            // textScypt
            // 
            textScypt.Font = new Font("Segoe UI", 12F);
            textScypt.Location = new Point(289, 186);
            textScypt.Name = "textScypt";
            textScypt.Size = new Size(256, 34);
            textScypt.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(66, 256);
            label2.Name = "label2";
            label2.Size = new Size(217, 28);
            label2.TabIndex = 3;
            label2.Text = "Văn bản sau khi mã hóa";
            // 
            // enscriptTxt
            // 
            enscriptTxt.Font = new Font("Segoe UI", 12F);
            enscriptTxt.Location = new Point(289, 256);
            enscriptTxt.Name = "enscriptTxt";
            enscriptTxt.Size = new Size(256, 34);
            enscriptTxt.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(551, 192);
            label3.Name = "label3";
            label3.Size = new Size(31, 28);
            label3.TabIndex = 5;
            label3.Text = "k :";
            // 
            // txtK
            // 
            txtK.Font = new Font("Segoe UI", 12F);
            txtK.Location = new Point(600, 186);
            txtK.Name = "txtK";
            txtK.Size = new Size(44, 34);
            txtK.TabIndex = 6;
            // 
            // descryptBtn
            // 
            descryptBtn.Font = new Font("Segoe UI", 12F);
            descryptBtn.Location = new Point(681, 245);
            descryptBtn.Name = "descryptBtn";
            descryptBtn.Size = new Size(103, 58);
            descryptBtn.TabIndex = 7;
            descryptBtn.Text = "Descrypt";
            descryptBtn.UseVisualStyleBackColor = true;
            descryptBtn.Click += descryptBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(299, 64);
            label4.Name = "label4";
            label4.Size = new Size(246, 41);
            label4.TabIndex = 8;
            label4.Text = "CAESAR CIPHER";
            // 
            // btn_exit
            // 
            btn_exit.Font = new Font("Segoe UI", 12F);
            btn_exit.Location = new Point(681, 319);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(103, 58);
            btn_exit.TabIndex = 9;
            btn_exit.Text = "Thoát";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 493);
            Controls.Add(btn_exit);
            Controls.Add(label4);
            Controls.Add(descryptBtn);
            Controls.Add(txtK);
            Controls.Add(label3);
            Controls.Add(enscriptTxt);
            Controls.Add(label2);
            Controls.Add(textScypt);
            Controls.Add(label1);
            Controls.Add(btnEnscrypt);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnscrypt;
        private Label label1;
        private TextBox textScypt;
        private Label label2;
        private TextBox enscriptTxt;
        private Label label3;
        private TextBox txtK;
        private Button descryptBtn;
        private Label label4;
        private Button btn_exit;
    }
}
