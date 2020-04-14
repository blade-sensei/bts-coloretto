namespace Coloretto
{
    partial class Score_manche
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
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btAudio = new System.Windows.Forms.Button();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointsDeux = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbJoker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointsMoin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointPlus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joueur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgScore = new System.Windows.Forms.DataGridView();
            this.lbGagnant = new System.Windows.Forms.Label();
            this.lbAnnonceGagnant = new System.Windows.Forms.Label();
            this.lbFinGame = new System.Windows.Forms.Button();
            this.lbContinuer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgScore)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitleScore
            // 
            this.lbTitleScore.AutoSize = true;
            this.lbTitleScore.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleScore.Location = new System.Drawing.Point(27, 27);
            this.lbTitleScore.Name = "lbTitleScore";
            this.lbTitleScore.Size = new System.Drawing.Size(72, 30);
            this.lbTitleScore.TabIndex = 2;
            this.lbTitleScore.Text = "Score";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(642, 473);
            this.shapeContainer1.TabIndex = 3;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 32;
            this.lineShape1.X2 = 607;
            this.lineShape1.Y1 = 67;
            this.lineShape1.Y2 = 67;
            // 
            // btAudio
            // 
            this.btAudio.Location = new System.Drawing.Point(555, 12);
            this.btAudio.Name = "btAudio";
            this.btAudio.Size = new System.Drawing.Size(75, 23);
            this.btAudio.TabIndex = 9;
            this.btAudio.Text = "Audio";
            this.btAudio.UseVisualStyleBackColor = true;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.Width = 70;
            // 
            // pointsDeux
            // 
            this.pointsDeux.HeaderText = "Points +2";
            this.pointsDeux.Name = "pointsDeux";
            this.pointsDeux.Width = 70;
            // 
            // nbJoker
            // 
            this.nbJoker.HeaderText = "Nombre Jokers";
            this.nbJoker.Name = "nbJoker";
            this.nbJoker.Width = 70;
            // 
            // pointsMoin
            // 
            this.pointsMoin.HeaderText = "Points -";
            this.pointsMoin.Name = "pointsMoin";
            this.pointsMoin.Width = 70;
            // 
            // pointPlus
            // 
            this.pointPlus.HeaderText = "Points +";
            this.pointPlus.Name = "pointPlus";
            this.pointPlus.Width = 70;
            // 
            // joueur
            // 
            this.joueur.HeaderText = "Joueur";
            this.joueur.Name = "joueur";
            // 
            // dgScore
            // 
            this.dgScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgScore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.joueur,
            this.pointPlus,
            this.pointsMoin,
            this.nbJoker,
            this.pointsDeux,
            this.total});
            this.dgScore.Location = new System.Drawing.Point(75, 110);
            this.dgScore.Name = "dgScore";
            this.dgScore.Size = new System.Drawing.Size(492, 169);
            this.dgScore.TabIndex = 4;
            // 
            // lbGagnant
            // 
            this.lbGagnant.AutoSize = true;
            this.lbGagnant.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGagnant.Location = new System.Drawing.Point(72, 337);
            this.lbGagnant.Name = "lbGagnant";
            this.lbGagnant.Size = new System.Drawing.Size(148, 18);
            this.lbGagnant.TabIndex = 5;
            this.lbGagnant.Text = "Gagnant de manche n° :";
            // 
            // lbAnnonceGagnant
            // 
            this.lbAnnonceGagnant.AutoSize = true;
            this.lbAnnonceGagnant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnnonceGagnant.Location = new System.Drawing.Point(239, 342);
            this.lbAnnonceGagnant.Name = "lbAnnonceGagnant";
            this.lbAnnonceGagnant.Size = new System.Drawing.Size(16, 16);
            this.lbAnnonceGagnant.TabIndex = 6;
            this.lbAnnonceGagnant.Text = "X";
            // 
            // lbFinGame
            // 
            this.lbFinGame.Location = new System.Drawing.Point(227, 393);
            this.lbFinGame.Name = "lbFinGame";
            this.lbFinGame.Size = new System.Drawing.Size(75, 46);
            this.lbFinGame.TabIndex = 7;
            this.lbFinGame.Text = "Fin du Jeu";
            this.lbFinGame.UseVisualStyleBackColor = true;
            // 
            // lbContinuer
            // 
            this.lbContinuer.Location = new System.Drawing.Point(340, 393);
            this.lbContinuer.Name = "lbContinuer";
            this.lbContinuer.Size = new System.Drawing.Size(75, 46);
            this.lbContinuer.TabIndex = 8;
            this.lbContinuer.Text = "Continuer";
            this.lbContinuer.UseVisualStyleBackColor = true;
            // 
            // Score_manche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 473);
            this.Controls.Add(this.btAudio);
            this.Controls.Add(this.lbContinuer);
            this.Controls.Add(this.lbFinGame);
            this.Controls.Add(this.lbAnnonceGagnant);
            this.Controls.Add(this.lbGagnant);
            this.Controls.Add(this.dgScore);
            this.Controls.Add(this.lbTitleScore);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Score_manche";
            this.Text = "Score_manche";
            ((System.ComponentModel.ISupportInitialize)(this.dgScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitleScore;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button btAudio;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointsDeux;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbJoker;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointsMoin;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointPlus;
        private System.Windows.Forms.DataGridViewTextBoxColumn joueur;
        private System.Windows.Forms.DataGridView dgScore;
        private System.Windows.Forms.Label lbGagnant;
        private System.Windows.Forms.Label lbAnnonceGagnant;
        private System.Windows.Forms.Button lbFinGame;
        private System.Windows.Forms.Button lbContinuer;
    }
}