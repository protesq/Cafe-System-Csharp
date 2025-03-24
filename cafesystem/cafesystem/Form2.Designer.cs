namespace cafesystem
{
    partial class adminPaneli
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
            this.kAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kayitOl = new System.Windows.Forms.Button();
            this.yetkiBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tedarikciGrid = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.urunGrid = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.kullaniciGrid = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tedarikciAdres = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tedarikciAd = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tedarikciTel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tedarikciGrid)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urunGrid)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciGrid)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kAdi
            // 
            this.kAdi.Location = new System.Drawing.Point(7, 57);
            this.kAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kAdi.Name = "kAdi";
            this.kAdi.Size = new System.Drawing.Size(227, 22);
            this.kAdi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre:";
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(7, 121);
            this.pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(227, 22);
            this.pass.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yetki:";
            // 
            // kayitOl
            // 
            this.kayitOl.Location = new System.Drawing.Point(47, 223);
            this.kayitOl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kayitOl.Name = "kayitOl";
            this.kayitOl.Size = new System.Drawing.Size(148, 25);
            this.kayitOl.TabIndex = 6;
            this.kayitOl.Text = "Kayıt Ol";
            this.kayitOl.UseVisualStyleBackColor = true;
            this.kayitOl.Click += new System.EventHandler(this.kayitOl_Click);
            // 
            // yetkiBox
            // 
            this.yetkiBox.FormattingEnabled = true;
            this.yetkiBox.Items.AddRange(new object[] {
            "Yönetici",
            "Garson",
            "Şef"});
            this.yetkiBox.Location = new System.Drawing.Point(7, 176);
            this.yetkiBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yetkiBox.Name = "yetkiBox";
            this.yetkiBox.Size = new System.Drawing.Size(227, 24);
            this.yetkiBox.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.yetkiBox);
            this.groupBox1.Controls.Add(this.kAdi);
            this.groupBox1.Controls.Add(this.kayitOl);
            this.groupBox1.Controls.Add(this.pass);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 73);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(247, 278);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Oluştur";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tedarikciGrid);
            this.groupBox6.Location = new System.Drawing.Point(1539, 14);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(500, 863);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tedarikçiler";
            // 
            // tedarikciGrid
            // 
            this.tedarikciGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tedarikciGrid.Location = new System.Drawing.Point(5, 30);
            this.tedarikciGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tedarikciGrid.Name = "tedarikciGrid";
            this.tedarikciGrid.RowHeadersWidth = 51;
            this.tedarikciGrid.RowTemplate.Height = 24;
            this.tedarikciGrid.Size = new System.Drawing.Size(489, 821);
            this.tedarikciGrid.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.urunGrid);
            this.groupBox5.Location = new System.Drawing.Point(860, 14);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(673, 863);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ürünler";
            // 
            // urunGrid
            // 
            this.urunGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.urunGrid.Location = new System.Drawing.Point(21, 21);
            this.urunGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.urunGrid.Name = "urunGrid";
            this.urunGrid.RowHeadersWidth = 51;
            this.urunGrid.RowTemplate.Height = 24;
            this.urunGrid.Size = new System.Drawing.Size(633, 830);
            this.urunGrid.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.kullaniciGrid);
            this.groupBox4.Location = new System.Drawing.Point(292, 14);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(563, 863);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Çalışanlar";
            // 
            // kullaniciGrid
            // 
            this.kullaniciGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kullaniciGrid.Location = new System.Drawing.Point(11, 21);
            this.kullaniciGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kullaniciGrid.Name = "kullaniciGrid";
            this.kullaniciGrid.RowHeadersWidth = 51;
            this.kullaniciGrid.RowTemplate.Height = 24;
            this.kullaniciGrid.Size = new System.Drawing.Size(547, 830);
            this.kullaniciGrid.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(16, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(219, 39);
            this.label9.TabIndex = 14;
            this.label9.Text = "Admin Paneli";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.tedarikciAdres);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tedarikciAd);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.tedarikciTel);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(16, 370);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(247, 303);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tedarikçi";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(47, 251);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 25);
            this.button3.TabIndex = 8;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // tedarikciAdres
            // 
            this.tedarikciAdres.Location = new System.Drawing.Point(7, 176);
            this.tedarikciAdres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tedarikciAdres.Name = "tedarikciAdres";
            this.tedarikciAdres.Size = new System.Drawing.Size(227, 22);
            this.tedarikciAdres.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tedarikçi Adı:";
            // 
            // tedarikciAd
            // 
            this.tedarikciAd.Location = new System.Drawing.Point(8, 47);
            this.tedarikciAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tedarikciAd.Name = "tedarikciAd";
            this.tedarikciAd.Size = new System.Drawing.Size(227, 22);
            this.tedarikciAd.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(47, 222);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 25);
            this.button2.TabIndex = 6;
            this.button2.Text = "Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tedarikciTel
            // 
            this.tedarikciTel.Location = new System.Drawing.Point(7, 110);
            this.tedarikciTel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tedarikciTel.Name = "tedarikciTel";
            this.tedarikciTel.Size = new System.Drawing.Size(227, 22);
            this.tedarikciTel.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Adres:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "Telefon:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 22);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 42);
            this.button1.TabIndex = 15;
            this.button1.Text = "Ürün Yönetimi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(7, 71);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(239, 42);
            this.button4.TabIndex = 16;
            this.button4.Text = "Kategori Yönetimi";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(7, 121);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(239, 42);
            this.button5.TabIndex = 17;
            this.button5.Text = "Masa Yönetimi";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(7, 170);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(239, 42);
            this.button6.TabIndex = 18;
            this.button6.Text = "Raporlama";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(12, 679);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(251, 223);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Diğer";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(19, 908);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(239, 42);
            this.button7.TabIndex = 19;
            this.button7.Text = "Çıkış Yap";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // adminPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 1040);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "adminPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Paneli";
            this.Load += new System.EventHandler(this.adminPaneli_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tedarikciGrid)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.urunGrid)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciGrid)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button kayitOl;
        private System.Windows.Forms.ComboBox yetkiBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView tedarikciGrid;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView urunGrid;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView kullaniciGrid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tedarikciAdres;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tedarikciAd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tedarikciTel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button7;
    }
}