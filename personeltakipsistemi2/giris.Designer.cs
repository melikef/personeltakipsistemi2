namespace personeltakipsistemi2
{
    partial class giris
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
            buttonGiris = new Button();
            label2 = new Label();
            txtboxKullaniciAd = new TextBox();
            txtboxSifre = new TextBox();
            label1 = new Label();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // buttonGiris
            // 
            buttonGiris.Location = new Point(120, 266);
            buttonGiris.Name = "buttonGiris";
            buttonGiris.Size = new Size(152, 62);
            buttonGiris.TabIndex = 0;
            buttonGiris.Text = "Giriş Yap";
            buttonGiris.UseVisualStyleBackColor = true;
            buttonGiris.Click += buttonGiris_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 184);
            label2.Name = "label2";
            label2.Size = new Size(47, 25);
            label2.TabIndex = 2;
            label2.Text = "Şifre";
            // 
            // txtboxKullaniciAd
            // 
            txtboxKullaniciAd.Location = new Point(30, 140);
            txtboxKullaniciAd.Name = "txtboxKullaniciAd";
            txtboxKullaniciAd.Size = new Size(329, 31);
            txtboxKullaniciAd.TabIndex = 3;
            // 
            // txtboxSifre
            // 
            txtboxSifre.Location = new Point(30, 212);
            txtboxSifre.Name = "txtboxSifre";
            txtboxSifre.Size = new Size(329, 31);
            txtboxSifre.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 103);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 5;
            label1.Text = "Kullanıcı Adı";
            label1.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 40);
            label4.Name = "label4";
            label4.Size = new Size(302, 25);
            label4.TabIndex = 8;
            label4.Text = "Personel Takip Sistemine Hoşgeldiniz";
            // 
            // button1
            // 
            button1.Location = new Point(235, 334);
            button1.Name = "button1";
            button1.Size = new Size(162, 34);
            button1.TabIndex = 9;
            button1.Text = "Şifremi Unuttum";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // giris
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 377);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(txtboxSifre);
            Controls.Add(txtboxKullaniciAd);
            Controls.Add(label2);
            Controls.Add(buttonGiris);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "giris";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }




        #endregion

        private Button buttonGiris;
        private Label label2;
        private TextBox txtboxKullaniciAd;
        private TextBox txtboxSifre;
        private Label label1;
        private Label label4;
        private Button button1;
    }
}
