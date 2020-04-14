namespace Coloretto
{
    partial class Score_game
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
            this.lbTitleScore = new System.Windows.Forms.Label();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lbRejouer = new System.Windows.Forms.Button();
            this.lbAccueil = new System.Windows.Forms.Button();
            this.lbAnnonceGagnant = new System.Windows.Forms.Label();
            this.lbGagnant = new System.Windows.Forms.Label();
            this.dgScore = new System.Windows.Forms.DataGridView();
            this.logoWin = new System.Windows.Forms.PictureBox();
            this.joueur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointPlus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointsMoin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbJoker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoWin)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitleScore
            // 
            this.lbTitleScore.AutoSize = true;
            this.lbTitleScore.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleScore.Location = new System.Drawing.Point(29, 31);
            this.lbTitleScore.Name = "lbTitleScore";
            this.lbTitleScore.Size = new System.Drawing.Size(72, 30);
            this.lbTitleScore.TabIndex = 3;
            this.lbTitleScore.Text = "Score";
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 29;
            this.lineShape1.X2 = 604;
            this.lineShape1.Y1 = 72;
            this.lineShape1.Y2 = 72;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(642, 473);
            this.shapeContainer1.TabIndex = 4;
            this.shapeContainer1.TabStop = false;
            // 
            // lbRejouer
            // 
            this.lbRejouer.Location = new System.Drawing.Point(356, 415);
            this.lbRejouer.Name = "lbRejouer";
            this.lbRejouer.Size = new System.Drawing.Size(75, 46);
            this.lbRejouer.TabIndex = 13;
            this.lbRejouer.Text = "Rejouer";
            this.lbRejouer.UseVisualStyleBackColor = true;
            // 
            // lbAccueil
            // 
            this.lbAccueil.Location = new System.Drawing.Point(227, 415);
            this.lbAccueil.Name = "lbAccueil";
            this.lbAccueil.Size = new System.Drawing.Size(75, 46);
            this.lbAccueil.TabIndex = 12;
            this.lbAccueil.Text = "Accueil";
            this.lbAccueil.UseVisualStyleBackColor = true;
            // 
            // lbAnnonceGagnant
            // 
            this.lbAnnonceGagnant.AutoSize = true;
            this.lbAnnonceGagnant.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnnonceGagnant.Location = new System.Drawing.Point(374, 280);
            this.lbAnnonceGagnant.Name = "lbAnnonceGagnant";
            this.lbAnnonceGagnant.Size = new System.Drawing.Size(26, 27);
            this.lbAnnonceGagnant.TabIndex = 11;
            this.lbAnnonceGagnant.Text = "X";
            // 
            // lbGagnant
            // 
            this.lbGagnant.AutoSize = true;
            this.lbGagnant.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGagnant.Location = new System.Drawing.Point(243, 280);
            this.lbGagnant.Name = "lbGagnant";
            this.lbGagnant.Size = new System.Drawing.Size(125, 27);
            this.lbGagnant.TabIndex = 10;
            this.lbGagnant.Text = "GAGNANT :";
            // 
            // dgScore
            // 
            this.dgScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgScore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.joueur,
            this.pointPlus,
            this.pointsMoin,
            this.nbJoker,
            this.total});
            this.dgScore.Location = new System.Drawing.Point(110, 98);
            this.dgScore.Name = "dgScore";
            this.dgScore.Size = new System.Drawing.Size(422, 158);
            this.dgScore.TabIndex = 9;
            // 
            // logoWin
            // 
            this.logoWin.Location = new System.Drawing.Point(292, 326);
            this.logoWin.Name = "logoWin";
            this.logoWin.Size = new System.Drawing.Size(76, 68);
            this.logoWin.TabIndex = 14;
            this.logoWin.TabStop = false;
            // 
            // joueur
            // 
            this.joueur.HeaderText = "Joueur";
            this.joueur.Name = "joueur";
            // 
            // pointPlus
            // 
            this.pointPlus.HeaderText = "Manche n°1";
            this.pointPlus.Name = "pointPlus";
            this.pointPlus.Width = 70;
            // 
            // pointsMoin
            // 
            this.pointsMoin.HeaderText = "Manche n°2";
            this.pointsMoin.Name = "pointsMoin";
            this.pointsMoin.Width = 70;
            // 
            // nbJoker
            // 
            this.nbJoker.HeaderText = "Manche n°3";
            this.nbJoker.Name = "nbJoker";
            this.nbJoker.Width = 70;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.Width = 70;
            // 
            // Score_game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 473);
            this.Controls.Add(this.logoWin);
            this.Controls.Add(this.lbRejouer);
            this.Controls.Add(this.lbAccueil);
            this.Controls.Add(this.lbAnnonceGagnant);
            this.Controls.Add(this.lbGagnant);
            this.Controls.Add(this.dgScore);
            this.Controls.Add(this.lbTitleScore);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Score_game";
            this.Text = "Score_game";
            ((System.ComponentModel.ISupportInitialize)(this.dgScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoWin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitleScore;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Button lbRejouer;
        private System.Windows.Forms.Button lbAccueil;
        private System.Windows.Forms.Label lbAnnonceGagnant;
        private System.Windows.Forms.Label lbGagnant;
        private System.Windows.Forms.DataGridView dgScore;
        private System.Windows.Forms.PictureBox logoWin;
        private System.Windows.Forms.DataGridViewTextBoxColumn joueur;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointPlus;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointsMoin;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbJoker;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}