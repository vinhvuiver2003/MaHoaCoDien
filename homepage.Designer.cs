﻿namespace MaHoaCoDien
{
    partial class homepage
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
            btn_caesar = new Button();
            btn_donbang = new Button();
            btn_exit = new Button();
            button1 = new Button();
            btn_mahoavie = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(253, 9);
            label1.Name = "label1";
            label1.Size = new Size(311, 54);
            label1.TabIndex = 0;
            label1.Text = "Mã hóa cổ điển";
            // 
            // btn_caesar
            // 
            btn_caesar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn_caesar.Location = new Point(291, 85);
            btn_caesar.Name = "btn_caesar";
            btn_caesar.Size = new Size(251, 53);
            btn_caesar.TabIndex = 1;
            btn_caesar.Text = "Mã hóa caesar";
            btn_caesar.UseVisualStyleBackColor = true;
            btn_caesar.Click += btn_caesar_Click;
            // 
            // btn_donbang
            // 
            btn_donbang.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn_donbang.Location = new Point(291, 144);
            btn_donbang.Name = "btn_donbang";
            btn_donbang.Size = new Size(251, 53);
            btn_donbang.TabIndex = 2;
            btn_donbang.Text = "Mã hóa đơn bảng";
            btn_donbang.UseVisualStyleBackColor = true;
            btn_donbang.Click += btn_donbang_Click;
            // 
            // btn_exit
            // 
            btn_exit.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn_exit.Location = new Point(291, 372);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(251, 53);
            btn_exit.TabIndex = 3;
            btn_exit.Text = "Thoát";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button1.Location = new Point(291, 203);
            button1.Name = "button1";
            button1.Size = new Size(251, 53);
            button1.TabIndex = 4;
            button1.Text = "Mã hóa Playfair";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_mahoavie
            // 
            btn_mahoavie.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn_mahoavie.Location = new Point(291, 262);
            btn_mahoavie.Name = "btn_mahoavie";
            btn_mahoavie.Size = new Size(251, 53);
            btn_mahoavie.TabIndex = 5;
            btn_mahoavie.Text = "Mã hóa vigenere";
            btn_mahoavie.UseVisualStyleBackColor = true;
            btn_mahoavie.Click += btn_mahoavie_Click;
            // 
            // homepage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_mahoavie);
            Controls.Add(button1);
            Controls.Add(btn_exit);
            Controls.Add(btn_donbang);
            Controls.Add(btn_caesar);
            Controls.Add(label1);
            Name = "homepage";
            Text = "homepaga";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_caesar;
        private Button btn_donbang;
        private Button btn_exit;
        private Button button1;
        private Button btn_mahoavie;
    }
}