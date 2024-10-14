namespace AdamAsmaca
{
    partial class Form1
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
            this.lblWord = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.lblAttempts = new System.Windows.Forms.Label();
            this.pictureBoxHangman = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHangman)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Location = new System.Drawing.Point(410, 134);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(48, 17);
            this.lblWord.TabIndex = 0;
            this.lblWord.Text = "kelime";
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(497, 200);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(100, 22);
            this.txtGuess.TabIndex = 1;
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(536, 90);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(75, 23);
            this.btnGuess.TabIndex = 2;
            this.btnGuess.Text = "Tahmin Et";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click); // Olay bağlama
                                                                                 // 
                                                                                 // lblAttempts
                                                                                 // 
            this.lblAttempts.AutoSize = true;
            this.lblAttempts.Location = new System.Drawing.Point(533, 320);
            this.lblAttempts.Name = "lblAttempts";
            this.lblAttempts.Size = new System.Drawing.Size(46, 17);
            this.lblAttempts.TabIndex = 3;
            this.lblAttempts.Text = "label1";
            // 
            // pictureBoxHangman
            // 
            this.pictureBoxHangman.Location = new System.Drawing.Point(76, 38);
            this.pictureBoxHangman.Name = "pictureBoxHangman";
            this.pictureBoxHangman.Size = new System.Drawing.Size(196, 332);
            this.pictureBoxHangman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHangman.TabIndex = 4;
            this.pictureBoxHangman.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxHangman);
            this.Controls.Add(this.lblAttempts);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.lblWord);
            this.Name = "Form1";
            this.Text = "Adam Asmaca";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHangman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        #endregion

        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label lblAttempts;
        private System.Windows.Forms.PictureBox pictureBoxHangman;
    }
}

