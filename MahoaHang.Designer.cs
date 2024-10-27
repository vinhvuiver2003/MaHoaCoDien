namespace MaHoaCoDien
{
    partial class MahoaHang
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
            lblMatrix = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPlaintext = new TextBox();
            txtKey = new TextBox();
            txtCipherText = new TextBox();
            btnEncrypt = new Button();
            btnDecrypt = new Button();
            txtoutput = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // lblMatrix
            // 
            lblMatrix.AutoSize = true;
            lblMatrix.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMatrix.Location = new Point(464, 125);
            lblMatrix.Name = "lblMatrix";
            lblMatrix.Size = new Size(85, 31);
            lblMatrix.TabIndex = 0;
            lblMatrix.Text = "Matrix:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 56);
            label1.Name = "label1";
            label1.Size = new Size(105, 31);
            label1.TabIndex = 2;
            label1.Text = "PlainText";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(53, 180);
            label2.Name = "label2";
            label2.Size = new Size(50, 31);
            label2.TabIndex = 3;
            label2.Text = "Key";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(53, 125);
            label3.Name = "label3";
            label3.Size = new Size(122, 31);
            label3.TabIndex = 4;
            label3.Text = "CipherText";
            // 
            // txtPlaintext
            // 
            txtPlaintext.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPlaintext.Location = new Point(199, 62);
            txtPlaintext.Name = "txtPlaintext";
            txtPlaintext.Size = new Size(213, 34);
            txtPlaintext.TabIndex = 5;
            // 
            // txtKey
            // 
            txtKey.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtKey.Location = new Point(199, 177);
            txtKey.Name = "txtKey";
            txtKey.Size = new Size(213, 34);
            txtKey.TabIndex = 6;
            // 
            // txtCipherText
            // 
            txtCipherText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCipherText.Location = new Point(199, 122);
            txtCipherText.Name = "txtCipherText";
            txtCipherText.Size = new Size(213, 34);
            txtCipherText.TabIndex = 7;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEncrypt.Location = new Point(128, 303);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(121, 40);
            btnEncrypt.TabIndex = 8;
            btnEncrypt.Text = "Mã hóa";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDecrypt.Location = new Point(313, 303);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(122, 40);
            btnDecrypt.TabIndex = 9;
            btnDecrypt.Text = "Giải mã";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // txtoutput
            // 
            txtoutput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtoutput.Location = new Point(560, 65);
            txtoutput.Name = "txtoutput";
            txtoutput.ReadOnly = true;
            txtoutput.Size = new Size(125, 34);
            txtoutput.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(462, 65);
            label4.Name = "label4";
            label4.Size = new Size(87, 31);
            label4.TabIndex = 11;
            label4.Text = "Output";
            // 
            // MahoaHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 471);
            Controls.Add(label4);
            Controls.Add(txtoutput);
            Controls.Add(btnDecrypt);
            Controls.Add(btnEncrypt);
            Controls.Add(txtCipherText);
            Controls.Add(txtKey);
            Controls.Add(txtPlaintext);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblMatrix);
            Name = "MahoaHang";
            Text = "MahoaHang";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMatrix;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPlaintext;
        private TextBox txtKey;
        private TextBox txtCipherText;
        private Button btnEncrypt;
        private Button btnDecrypt;
        private TextBox txtoutput;
        private Label label4;
    }
}