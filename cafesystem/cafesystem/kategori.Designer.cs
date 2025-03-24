namespace cafesystem
{
    partial class kategori
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
            this.kategoriBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.kategoriGrid = new System.Windows.Forms.DataGridView();
            this.silButton = new System.Windows.Forms.Button();
            this.silBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // kategoriBox
            // 
            this.kategoriBox.Location = new System.Drawing.Point(16, 51);
            this.kategoriBox.Name = "kategoriBox";
            this.kategoriBox.Size = new System.Drawing.Size(179, 22);
            this.kategoriBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kategori Adı:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kategoriGrid
            // 
            this.kategoriGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kategoriGrid.Location = new System.Drawing.Point(210, 28);
            this.kategoriGrid.Name = "kategoriGrid";
            this.kategoriGrid.RowHeadersWidth = 51;
            this.kategoriGrid.RowTemplate.Height = 24;
            this.kategoriGrid.Size = new System.Drawing.Size(503, 305);
            this.kategoriGrid.TabIndex = 3;
            // 
            // silButton
            // 
            this.silButton.Location = new System.Drawing.Point(16, 180);
            this.silButton.Name = "silButton";
            this.silButton.Size = new System.Drawing.Size(179, 29);
            this.silButton.TabIndex = 4;
            this.silButton.Text = "Sil";
            this.silButton.UseVisualStyleBackColor = true;
            this.silButton.Click += new System.EventHandler(this.silButton_Click);
            // 
            // silBox
            // 
            this.silBox.Location = new System.Drawing.Point(16, 152);
            this.silBox.Name = "silBox";
            this.silBox.Size = new System.Drawing.Size(179, 22);
            this.silBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kategori Id:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 291);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 42);
            this.button3.TabIndex = 7;
            this.button3.Text = "Geri";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // kategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 345);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.silBox);
            this.Controls.Add(this.silButton);
            this.Controls.Add(this.kategoriGrid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kategoriBox);
            this.Name = "kategori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kategori";
            this.Load += new System.EventHandler(this.kategori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kategoriGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kategoriBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView kategoriGrid;
        private System.Windows.Forms.Button silButton;
        private System.Windows.Forms.TextBox silBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
    }
}