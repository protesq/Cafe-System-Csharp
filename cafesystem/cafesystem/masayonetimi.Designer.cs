namespace cafesystem
{
    partial class masayonetimi
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
            this.masaGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.masaIdBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guncelleButton = new System.Windows.Forms.Button();
            this.masaAdiBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EkleButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.masaGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // masaGrid
            // 
            this.masaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.masaGrid.Location = new System.Drawing.Point(306, 25);
            this.masaGrid.Name = "masaGrid";
            this.masaGrid.RowHeadersWidth = 51;
            this.masaGrid.RowTemplate.Height = 24;
            this.masaGrid.Size = new System.Drawing.Size(608, 489);
            this.masaGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(36, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Masa ID";
            // 
            // masaIdBox
            // 
            this.masaIdBox.Location = new System.Drawing.Point(40, 74);
            this.masaIdBox.Name = "masaIdBox";
            this.masaIdBox.Size = new System.Drawing.Size(204, 22);
            this.masaIdBox.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "REZERVE",
            "DOLU",
            "BOŞ"});
            this.comboBox1.Location = new System.Drawing.Point(40, 132);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(36, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Durum";
            // 
            // guncelleButton
            // 
            this.guncelleButton.Location = new System.Drawing.Point(70, 171);
            this.guncelleButton.Name = "guncelleButton";
            this.guncelleButton.Size = new System.Drawing.Size(140, 37);
            this.guncelleButton.TabIndex = 5;
            this.guncelleButton.Text = "Güncelle";
            this.guncelleButton.UseVisualStyleBackColor = true;
            this.guncelleButton.Click += new System.EventHandler(this.guncelleButton_Click);
            // 
            // masaAdiBox
            // 
            this.masaAdiBox.Location = new System.Drawing.Point(40, 266);
            this.masaAdiBox.Name = "masaAdiBox";
            this.masaAdiBox.Size = new System.Drawing.Size(204, 22);
            this.masaAdiBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(36, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Masa Adı";
            // 
            // EkleButton
            // 
            this.EkleButton.Location = new System.Drawing.Point(70, 294);
            this.EkleButton.Name = "EkleButton";
            this.EkleButton.Size = new System.Drawing.Size(140, 37);
            this.EkleButton.TabIndex = 8;
            this.EkleButton.Text = "Ekle";
            this.EkleButton.UseVisualStyleBackColor = true;
            this.EkleButton.Click += new System.EventHandler(this.EkleButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(70, 477);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 37);
            this.button2.TabIndex = 13;
            this.button2.Text = "Geri";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // masayonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 526);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.EkleButton);
            this.Controls.Add(this.masaAdiBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guncelleButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.masaIdBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.masaGrid);
            this.Name = "masayonetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "masayonetimi";
            this.Load += new System.EventHandler(this.masayonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masaGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView masaGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox masaIdBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button guncelleButton;
        private System.Windows.Forms.TextBox masaAdiBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button EkleButton;
        private System.Windows.Forms.Button button2;
    }
}