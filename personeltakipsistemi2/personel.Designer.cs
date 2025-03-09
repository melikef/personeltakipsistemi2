namespace personeltakipsistemi2
{
    partial class personel
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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox3 = new GroupBox();
            buttonListele = new Button();
            buttonKaydet = new Button();
            buttonSil = new Button();
            buttonTemizle = new Button();
            buttonGüncelle = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(111, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(265, 31);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(122, 237);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "Kişi Ekle";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(12, 334);
            button2.Name = "button2";
            button2.Size = new Size(219, 34);
            button2.TabIndex = 6;
            button2.Text = "KullancıAd/Şifre değiştir";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(376, 301);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personel Ekleme";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(111, 67);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(265, 31);
            textBox4.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(111, 119);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(265, 31);
            textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(111, 169);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(265, 31);
            textBox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 169);
            label4.Name = "label4";
            label4.Size = new Size(119, 25);
            label4.TabIndex = 3;
            label4.Text = "DEPARTMAN:";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 27);
            label3.Name = "label3";
            label3.Size = new Size(34, 25);
            label3.TabIndex = 2;
            label3.Text = "İD:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 119);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 1;
            label2.Text = "SOYAD:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 73);
            label1.Name = "label1";
            label1.Size = new Size(41, 25);
            label1.TabIndex = 0;
            label1.Text = "AD:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(12, 395);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(896, 517);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Personel";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(890, 487);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonGüncelle);
            groupBox3.Controls.Add(buttonTemizle);
            groupBox3.Controls.Add(buttonSil);
            groupBox3.Controls.Add(buttonKaydet);
            groupBox3.Controls.Add(buttonListele);
            groupBox3.Location = new Point(450, 19);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(280, 298);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Buton";
            // 
            // buttonListele
            // 
            buttonListele.Location = new Point(49, 30);
            buttonListele.Name = "buttonListele";
            buttonListele.Size = new Size(194, 39);
            buttonListele.TabIndex = 0;
            buttonListele.Text = "Listele";
            buttonListele.UseVisualStyleBackColor = true;
            // 
            // buttonKaydet
            // 
            buttonKaydet.Location = new Point(49, 85);
            buttonKaydet.Name = "buttonKaydet";
            buttonKaydet.Size = new Size(194, 34);
            buttonKaydet.TabIndex = 1;
            buttonKaydet.Text = "Kaydet";
            buttonKaydet.UseVisualStyleBackColor = true;
            // 
            // buttonSil
            // 
            buttonSil.Location = new Point(49, 135);
            buttonSil.Name = "buttonSil";
            buttonSil.Size = new Size(194, 34);
            buttonSil.TabIndex = 2;
            buttonSil.Text = "Sil";
            buttonSil.UseVisualStyleBackColor = true;
            // 
            // buttonTemizle
            // 
            buttonTemizle.Location = new Point(49, 190);
            buttonTemizle.Name = "buttonTemizle";
            buttonTemizle.Size = new Size(194, 34);
            buttonTemizle.TabIndex = 3;
            buttonTemizle.Text = "Temizle";
            buttonTemizle.UseVisualStyleBackColor = true;
            // 
            // buttonGüncelle
            // 
            buttonGüncelle.Location = new Point(49, 242);
            buttonGüncelle.Name = "buttonGüncelle";
            buttonGüncelle.Size = new Size(194, 34);
            buttonGüncelle.TabIndex = 4;
            buttonGüncelle.Text = "Güncelle";
            buttonGüncelle.UseVisualStyleBackColor = true;
            // 
            // personel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 912);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Name = "personel";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private GroupBox groupBox3;
        private Button buttonGüncelle;
        private Button buttonTemizle;
        private Button buttonSil;
        private Button buttonKaydet;
        private Button buttonListele;
    }
}