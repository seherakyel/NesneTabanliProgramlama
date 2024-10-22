namespace FlappyBird
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
            this.components = new System.ComponentModel.Container();
            this.pipeTopPictureBox = new System.Windows.Forms.PictureBox();
            this.groundPictureBox = new System.Windows.Forms.PictureBox();
            this.pipeBottomPictureBox = new System.Windows.Forms.PictureBox();
            this.birdPictureBox = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.scoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTopPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottomPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birdPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pipeTopPictureBox
            // 
            this.pipeTopPictureBox.Image = global::FlappyBird.Properties.Resources.pipeDown;
            this.pipeTopPictureBox.Location = new System.Drawing.Point(462, -2);
            this.pipeTopPictureBox.Name = "pipeTopPictureBox";
            this.pipeTopPictureBox.Size = new System.Drawing.Size(100, 135);
            this.pipeTopPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTopPictureBox.TabIndex = 0;
            this.pipeTopPictureBox.TabStop = false;
            // 
            // groundPictureBox
            // 
            this.groundPictureBox.Image = global::FlappyBird.Properties.Resources.ground;
            this.groundPictureBox.Location = new System.Drawing.Point(-16, 438);
            this.groundPictureBox.Name = "groundPictureBox";
            this.groundPictureBox.Size = new System.Drawing.Size(695, 104);
            this.groundPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.groundPictureBox.TabIndex = 1;
            this.groundPictureBox.TabStop = false;
            // 
            // pipeBottomPictureBox
            // 
            this.pipeBottomPictureBox.Image = global::FlappyBird.Properties.Resources.pipeUp;
            this.pipeBottomPictureBox.Location = new System.Drawing.Point(462, 304);
            this.pipeBottomPictureBox.Name = "pipeBottomPictureBox";
            this.pipeBottomPictureBox.Size = new System.Drawing.Size(100, 138);
            this.pipeBottomPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottomPictureBox.TabIndex = 2;
            this.pipeBottomPictureBox.TabStop = false;
            // 
            // birdPictureBox
            // 
            this.birdPictureBox.BackColor = System.Drawing.Color.White;
            this.birdPictureBox.Image = global::FlappyBird.Properties.Resources.bird__2_;
            this.birdPictureBox.Location = new System.Drawing.Point(121, 175);
            this.birdPictureBox.Name = "birdPictureBox";
            this.birdPictureBox.Size = new System.Drawing.Size(100, 75);
            this.birdPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.birdPictureBox.TabIndex = 3;
            this.birdPictureBox.TabStop = false;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(97, 42);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(78, 17);
            this.scoreLabel.TabIndex = 4;
            this.scoreLabel.Text = "scoreLabel";
            this.scoreLabel.Click += new System.EventHandler(this.scoreLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(683, 519);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.birdPictureBox);
            this.Controls.Add(this.pipeBottomPictureBox);
            this.Controls.Add(this.groundPictureBox);
            this.Controls.Add(this.pipeTopPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pipeTopPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottomPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birdPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pipeTopPictureBox;
        private System.Windows.Forms.PictureBox groundPictureBox;
        private System.Windows.Forms.PictureBox pipeBottomPictureBox;
        private System.Windows.Forms.PictureBox birdPictureBox;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label scoreLabel;
    }
}

