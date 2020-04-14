namespace Coloretto
{
    partial class Home
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
            this.logoGame = new System.Windows.Forms.PictureBox();
            this.btJouer = new System.Windows.Forms.Button();
            this.btRegles = new System.Windows.Forms.Button();
            this.lbAudio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoGame)).BeginInit();
            this.SuspendLayout();
            // 
            // logoGame
            // 
            this.logoGame.Location = new System.Drawing.Point(151, 50);
            this.logoGame.Name = "logoGame";
            this.logoGame.Size = new System.Drawing.Size(331, 192);
            this.logoGame.TabIndex = 0;
            this.logoGame.TabStop = false;
            // 
            // btJouer
            // 
            this.btJouer.Location = new System.Drawing.Point(257, 286);
            this.btJouer.Name = "btJouer";
            this.btJouer.Size = new System.Drawing.Size(97, 43);
            this.btJouer.TabIndex = 1;
            this.btJouer.Text = "Jouer";
            this.btJouer.UseVisualStyleBackColor = true;
            this.btJouer.Click += new System.EventHandler(this.btJouer_Click);
            // 
            // btRegles
            // 
            this.btRegles.Location = new System.Drawing.Point(257, 350);
            this.btRegles.Name = "btRegles";
            this.btRegles.Size = new System.Drawing.Size(97, 43);
            this.btRegles.TabIndex = 2;
            this.btRegles.Text = "Règles";
            this.btRegles.UseVisualStyleBackColor = true;
            this.btRegles.Click += new System.EventHandler(this.btRegles_Click);
            // 
            // lbAudio
            // 
            this.lbAudio.Location = new System.Drawing.Point(576, 2);
            this.lbAudio.Name = "lbAudio";
            this.lbAudio.Size = new System.Drawing.Size(55, 28);
            this.lbAudio.TabIndex = 3;
            this.lbAudio.Text = "Audio";
            this.lbAudio.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 473);
            this.Controls.Add(this.lbAudio);
            this.Controls.Add(this.btRegles);
            this.Controls.Add(this.btJouer);
            this.Controls.Add(this.logoGame);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoGame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logoGame;
        private System.Windows.Forms.Button btJouer;
        private System.Windows.Forms.Button btRegles;
        private System.Windows.Forms.Button lbAudio;
    }
}

