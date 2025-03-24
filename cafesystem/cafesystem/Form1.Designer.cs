namespace cafesystem
{
    partial class GirişYap
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.girisYap = new System.Windows.Forms.Button();
            this.kayitOl = new System.Windows.Forms.Button();
            this.kullaniciAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // girisYap
            // 
            this.girisYap.Location = new System.Drawing.Point(58, 189);
            this.girisYap.Name = "girisYap";
            this.girisYap.Size = new System.Drawing.Size(130, 30);
            this.girisYap.TabIndex = 0;
            this.girisYap.Text = "Giriş Yap";
            this.girisYap.UseVisualStyleBackColor = true;
            this.girisYap.Click += new System.EventHandler(this.button1_Click);
            // 
            // kayitOl
            // 
            this.kayitOl.Location = new System.Drawing.Point(224, 189);
            this.kayitOl.Name = "kayitOl";
            this.kayitOl.Size = new System.Drawing.Size(130, 30);
            this.kayitOl.TabIndex = 1;
            this.kayitOl.Text = "Kayıt Ol";
            this.kayitOl.UseVisualStyleBackColor = true;
            this.kayitOl.Click += new System.EventHandler(this.kayitOl_Click);
            // 
            // kullaniciAdi
            // 
            this.kullaniciAdi.Location = new System.Drawing.Point(58, 76);
            this.kullaniciAdi.Name = "kullaniciAdi";
            this.kullaniciAdi.Size = new System.Drawing.Size(293, 22);
            this.kullaniciAdi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre";
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(61, 133);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(293, 22);
            this.sifre.TabIndex = 4;
            // 
            // GirişYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 283);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kullaniciAdi);
            this.Controls.Add(this.kayitOl);
            this.Controls.Add(this.girisYap);
            this.Name = "GirişYap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button girisYap;
        private System.Windows.Forms.Button kayitOl;
        private System.Windows.Forms.TextBox kullaniciAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sifre;
    }
}

