namespace cafesystem
{
    partial class urun
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
            this.label1 = new System.Windows.Forms.Label();
            this.urunAdi = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.kategoriBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fiyat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Kdv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Stok = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ekle = new System.Windows.Forms.Button();
            this.urunDataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.urunId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.silButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.urunDataGrid)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı:";
            // 
            // urunAdi
            // 
            this.urunAdi.Location = new System.Drawing.Point(28, 57);
            this.urunAdi.Name = "urunAdi";
            this.urunAdi.Size = new System.Drawing.Size(196, 22);
            this.urunAdi.TabIndex = 1;
            // 
            // kategoriBox1
            // 
            this.kategoriBox1.FormattingEnabled = true;
            this.kategoriBox1.Items.AddRange(new object[] {
            "Test",
            "test2",
            "test1",
            "test3"});
            this.kategoriBox1.Location = new System.Drawing.Point(28, 109);
            this.kategoriBox1.Name = "kategoriBox1";
            this.kategoriBox1.Size = new System.Drawing.Size(196, 24);
            this.kategoriBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(24, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kategori:";
            // 
            // fiyat
            // 
            this.fiyat.Location = new System.Drawing.Point(28, 159);
            this.fiyat.Name = "fiyat";
            this.fiyat.Size = new System.Drawing.Size(196, 22);
            this.fiyat.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(24, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fiyat:";
            // 
            // Kdv
            // 
            this.Kdv.Location = new System.Drawing.Point(28, 217);
            this.Kdv.Name = "Kdv";
            this.Kdv.Size = new System.Drawing.Size(196, 22);
            this.Kdv.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(24, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "KDV(%):";
            // 
            // Stok
            // 
            this.Stok.Location = new System.Drawing.Point(28, 276);
            this.Stok.Name = "Stok";
            this.Stok.Size = new System.Drawing.Size(196, 22);
            this.Stok.TabIndex = 9;
            this.Stok.TextChanged += new System.EventHandler(this.Stok_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(24, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Stok:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(40, 304);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(159, 41);
            this.ekle.TabIndex = 10;
            this.ekle.Text = "Ekle";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // urunDataGrid
            // 
            this.urunDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.urunDataGrid.Location = new System.Drawing.Point(6, 23);
            this.urunDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.urunDataGrid.Name = "urunDataGrid";
            this.urunDataGrid.RowHeadersWidth = 51;
            this.urunDataGrid.RowTemplate.Height = 24;
            this.urunDataGrid.Size = new System.Drawing.Size(794, 479);
            this.urunDataGrid.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.urunDataGrid);
            this.groupBox4.Location = new System.Drawing.Point(255, 11);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(806, 506);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mevcut Ürünler";
            // 
            // urunId
            // 
            this.urunId.Location = new System.Drawing.Point(28, 384);
            this.urunId.Name = "urunId";
            this.urunId.Size = new System.Drawing.Size(196, 22);
            this.urunId.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(24, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ürün Id:";
            // 
            // silButton
            // 
            this.silButton.Location = new System.Drawing.Point(40, 412);
            this.silButton.Name = "silButton";
            this.silButton.Size = new System.Drawing.Size(159, 41);
            this.silButton.TabIndex = 14;
            this.silButton.Text = "Sil";
            this.silButton.UseVisualStyleBackColor = true;
            this.silButton.Click += new System.EventHandler(this.silButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 41);
            this.button1.TabIndex = 15;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // urun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 544);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.silButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.urunId);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.Stok);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Kdv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fiyat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kategoriBox1);
            this.Controls.Add(this.urunAdi);
            this.Controls.Add(this.label1);
            this.Name = "urun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "urun";
            this.Load += new System.EventHandler(this.urun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.urunDataGrid)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox urunAdi;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox kategoriBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Kdv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Stok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.DataGridView urunDataGrid;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox urunId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button silButton;
        private System.Windows.Forms.Button button1;
    }
}