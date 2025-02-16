namespace personeltakipsistemi2
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
            buttonGiris = new Button();
            label2 = new Label();
            txtboxKullaniciAd = new TextBox();
            txtboxSifre = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonGiris
            // 
            buttonGiris.Location = new Point(119, 235);
            buttonGiris.Name = "buttonGiris";
            buttonGiris.Size = new Size(152, 62);
            buttonGiris.TabIndex = 0;
            buttonGiris.Text = "Giriş Yap";
            buttonGiris.UseVisualStyleBackColor = true;
            buttonGiris.Click += buttonGiris_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 120);
            label2.Name = "label2";
            label2.Size = new Size(47, 25);
            label2.TabIndex = 2;
            label2.Text = "Şifre";
            // 
            // txtboxKullaniciAd
            // 
            txtboxKullaniciAd.Location = new Point(30, 64);
            txtboxKullaniciAd.Name = "txtboxKullaniciAd";
            txtboxKullaniciAd.Size = new Size(329, 31);
            txtboxKullaniciAd.TabIndex = 3;
            // 
            // txtboxSifre
            // 
            txtboxSifre.Location = new Point(30, 160);
            txtboxSifre.Name = "txtboxSifre";
            txtboxSifre.Size = new Size(329, 31);
            txtboxSifre.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 36);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 5;
            label1.Text = "Kullanıcı Adı";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 350);
            Controls.Add(label1);
            Controls.Add(txtboxSifre);
            Controls.Add(txtboxKullaniciAd);
            Controls.Add(label2);
            Controls.Add(buttonGiris);
            Name = "Form1";
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
    }
}
