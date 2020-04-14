namespace Coloretto
{
    partial class Parametres_score
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
            this.lbTitleParametresScore = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lbExplications = new System.Windows.Forms.Label();
            this.lbOu = new System.Windows.Forms.Label();
            this.btRetour = new System.Windows.Forms.Button();
            this.btValider = new System.Windows.Forms.Button();
            this.cardScoreB = new System.Windows.Forms.PictureBox();
            this.cardScoreA = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cardScoreB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardScoreA)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitleParametresScore
            // 
            this.lbTitleParametresScore.AutoSize = true;
            this.lbTitleParametresScore.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleParametresScore.Location = new System.Drawing.Point(24, 21);
            this.lbTitleParametresScore.Name = "lbTitleParametresScore";
            this.lbTitleParametresScore.Size = new System.Drawing.Size(345, 30);
            this.lbTitleParametresScore.TabIndex = 0;
            this.lbTitleParametresScore.Text = "Choix pour le comptage de score";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(632, 473);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 28;
            this.lineShape1.X2 = 591;
            this.lineShape1.Y1 = 60;
            this.lineShape1.Y2 = 60;
            // 
            // lbExplications
            // 
            this.lbExplications.AutoSize = true;
            this.lbExplications.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExplications.Location = new System.Drawing.Point(24, 70);
            this.lbExplications.Name = "lbExplications";
            this.lbExplications.Size = new System.Drawing.Size(345, 57);
            this.lbExplications.TabIndex = 2;
            this.lbExplications.Text = "Click sur une image pour choisir le type de comptage\r\npour le score. Pour plus d\'" +
                "information click ici\r\n\r\n";
            // 
            // lbOu
            // 
            this.lbOu.AutoSize = true;
            this.lbOu.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOu.Location = new System.Drawing.Point(298, 230);
            this.lbOu.Name = "lbOu";
            this.lbOu.Size = new System.Drawing.Size(41, 27);
            this.lbOu.TabIndex = 5;
            this.lbOu.Text = "OU";
            // 
            // btRetour
            // 
            this.btRetour.Location = new System.Drawing.Point(12, 447);
            this.btRetour.Name = "btRetour";
            this.btRetour.Size = new System.Drawing.Size(75, 23);
            this.btRetour.TabIndex = 6;
            this.btRetour.Text = "Retour";
            this.btRetour.UseVisualStyleBackColor = true;
            // 
            // btValider
            // 
            this.btValider.Location = new System.Drawing.Point(279, 423);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(75, 38);
            this.btValider.TabIndex = 7;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // cardScoreB
            // 
            this.cardScoreB.BackgroundImage = global::Coloretto.Properties.Resources.ScoreB;
            this.cardScoreB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cardScoreB.Location = new System.Drawing.Point(355, 144);
            this.cardScoreB.Name = "cardScoreB";
            this.cardScoreB.Size = new System.Drawing.Size(156, 220);
            this.cardScoreB.TabIndex = 4;
            this.cardScoreB.TabStop = false;
            // 
            // cardScoreA
            // 
            this.cardScoreA.BackgroundImage = global::Coloretto.Properties.Resources.ScoreA;
            this.cardScoreA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cardScoreA.Location = new System.Drawing.Point(122, 144);
            this.cardScoreA.Name = "cardScoreA";
            this.cardScoreA.Size = new System.Drawing.Size(156, 220);
            this.cardScoreA.TabIndex = 3;
            this.cardScoreA.TabStop = false;
            this.cardScoreA.Click += new System.EventHandler(this.cardScoreA_Click);
            // 
            // Parametres_score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 473);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.btRetour);
            this.Controls.Add(this.lbOu);
            this.Controls.Add(this.cardScoreB);
            this.Controls.Add(this.cardScoreA);
            this.Controls.Add(this.lbExplications);
            this.Controls.Add(this.lbTitleParametresScore);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Parametres_score";
            this.Text = "Parametres_score";
            this.Load += new System.EventHandler(this.Parametres_score_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardScoreB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardScoreA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitleParametresScore;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label lbExplications;
        private System.Windows.Forms.PictureBox cardScoreA;
        private System.Windows.Forms.PictureBox cardScoreB;
        private System.Windows.Forms.Label lbOu;
        private System.Windows.Forms.Button btRetour;
        private System.Windows.Forms.Button btValider;
    }
}