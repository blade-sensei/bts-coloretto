namespace Coloretto
{
    partial class Parametres_nom
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
            this.lbTitleParametres = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lbPseudo = new System.Windows.Forms.Label();
            this.lbNbJouers = new System.Windows.Forms.Label();
            this.lbPseudoAdversaires = new System.Windows.Forms.Label();
            this.tbPseudo = new System.Windows.Forms.TextBox();
            this.numUpNbJouers = new System.Windows.Forms.NumericUpDown();
            this.tbIA1 = new System.Windows.Forms.TextBox();
            this.tbIA2 = new System.Windows.Forms.TextBox();
            this.tbIA3 = new System.Windows.Forms.TextBox();
            this.tbIA4 = new System.Windows.Forms.TextBox();
            this.tbIA5 = new System.Windows.Forms.TextBox();
            this.btRetour = new System.Windows.Forms.Button();
            this.btValider = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpNbJouers)).BeginInit();
            this.SuspendLayout();
            // 
            // logoGame
            // 
            this.logoGame.Location = new System.Drawing.Point(203, 29);
            this.logoGame.Name = "logoGame";
            this.logoGame.Size = new System.Drawing.Size(227, 125);
            this.logoGame.TabIndex = 0;
            this.logoGame.TabStop = false;
            // 
            // lbTitleParametres
            // 
            this.lbTitleParametres.AutoSize = true;
            this.lbTitleParametres.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleParametres.Location = new System.Drawing.Point(53, 195);
            this.lbTitleParametres.Name = "lbTitleParametres";
            this.lbTitleParametres.Size = new System.Drawing.Size(128, 30);
            this.lbTitleParametres.TabIndex = 1;
            this.lbTitleParametres.Text = "Paramètres";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(632, 473);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 55;
            this.lineShape1.X2 = 575;
            this.lineShape1.Y1 = 234;
            this.lineShape1.Y2 = 234;
            // 
            // lbPseudo
            // 
            this.lbPseudo.AutoSize = true;
            this.lbPseudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPseudo.Location = new System.Drawing.Point(55, 259);
            this.lbPseudo.Name = "lbPseudo";
            this.lbPseudo.Size = new System.Drawing.Size(159, 20);
            this.lbPseudo.TabIndex = 3;
            this.lbPseudo.Text = "Entrez votre pseudo";
            // 
            // lbNbJouers
            // 
            this.lbNbJouers.AutoSize = true;
            this.lbNbJouers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNbJouers.Location = new System.Drawing.Point(55, 296);
            this.lbNbJouers.Name = "lbNbJouers";
            this.lbNbJouers.Size = new System.Drawing.Size(151, 20);
            this.lbNbJouers.TabIndex = 4;
            this.lbNbJouers.Text = "Nombre de joueurs";
            // 
            // lbPseudoAdversaires
            // 
            this.lbPseudoAdversaires.AutoSize = true;
            this.lbPseudoAdversaires.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPseudoAdversaires.Location = new System.Drawing.Point(55, 339);
            this.lbPseudoAdversaires.Name = "lbPseudoAdversaires";
            this.lbPseudoAdversaires.Size = new System.Drawing.Size(182, 20);
            this.lbPseudoAdversaires.TabIndex = 5;
            this.lbPseudoAdversaires.Text = "Nom(s) d\'adversaire(s)";
            // 
            // tbPseudo
            // 
            this.tbPseudo.Location = new System.Drawing.Point(248, 259);
            this.tbPseudo.Name = "tbPseudo";
            this.tbPseudo.Size = new System.Drawing.Size(100, 20);
            this.tbPseudo.TabIndex = 6;
            // 
            // numUpNbJouers
            // 
            this.numUpNbJouers.Location = new System.Drawing.Point(248, 295);
            this.numUpNbJouers.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUpNbJouers.Name = "numUpNbJouers";
            this.numUpNbJouers.Size = new System.Drawing.Size(100, 20);
            this.numUpNbJouers.TabIndex = 7;
            this.numUpNbJouers.ValueChanged += new System.EventHandler(this.numUpNbJouers_ValueChanged);
            // 
            // tbIA1
            // 
            this.tbIA1.Location = new System.Drawing.Point(56, 377);
            this.tbIA1.Name = "tbIA1";
            this.tbIA1.Size = new System.Drawing.Size(85, 20);
            this.tbIA1.TabIndex = 8;
            this.tbIA1.Visible = false;
            // 
            // tbIA2
            // 
            this.tbIA2.Location = new System.Drawing.Point(164, 377);
            this.tbIA2.Name = "tbIA2";
            this.tbIA2.Size = new System.Drawing.Size(85, 20);
            this.tbIA2.TabIndex = 9;
            this.tbIA2.Visible = false;
            // 
            // tbIA3
            // 
            this.tbIA3.Location = new System.Drawing.Point(277, 377);
            this.tbIA3.Name = "tbIA3";
            this.tbIA3.Size = new System.Drawing.Size(86, 20);
            this.tbIA3.TabIndex = 10;
            this.tbIA3.Visible = false;
            // 
            // tbIA4
            // 
            this.tbIA4.Location = new System.Drawing.Point(392, 377);
            this.tbIA4.Name = "tbIA4";
            this.tbIA4.Size = new System.Drawing.Size(80, 20);
            this.tbIA4.TabIndex = 11;
            this.tbIA4.Visible = false;
            // 
            // tbIA5
            // 
            this.tbIA5.Location = new System.Drawing.Point(501, 377);
            this.tbIA5.Name = "tbIA5";
            this.tbIA5.Size = new System.Drawing.Size(85, 20);
            this.tbIA5.TabIndex = 12;
            this.tbIA5.Visible = false;
            // 
            // btRetour
            // 
            this.btRetour.Location = new System.Drawing.Point(30, 438);
            this.btRetour.Name = "btRetour";
            this.btRetour.Size = new System.Drawing.Size(75, 23);
            this.btRetour.TabIndex = 13;
            this.btRetour.Text = "< Retour";
            this.btRetour.UseVisualStyleBackColor = true;
            // 
            // btValider
            // 
            this.btValider.Location = new System.Drawing.Point(279, 438);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(75, 23);
            this.btValider.TabIndex = 14;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // Parametres_nom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 473);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.btRetour);
            this.Controls.Add(this.tbIA5);
            this.Controls.Add(this.tbIA4);
            this.Controls.Add(this.tbIA3);
            this.Controls.Add(this.tbIA2);
            this.Controls.Add(this.tbIA1);
            this.Controls.Add(this.numUpNbJouers);
            this.Controls.Add(this.tbPseudo);
            this.Controls.Add(this.lbPseudoAdversaires);
            this.Controls.Add(this.lbNbJouers);
            this.Controls.Add(this.lbPseudo);
            this.Controls.Add(this.lbTitleParametres);
            this.Controls.Add(this.logoGame);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Parametres_nom";
            this.Text = "Parametres_nom";
            this.Load += new System.EventHandler(this.Parametres_nom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpNbJouers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoGame;
        private System.Windows.Forms.Label lbTitleParametres;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label lbPseudo;
        private System.Windows.Forms.Label lbNbJouers;
        private System.Windows.Forms.Label lbPseudoAdversaires;
        private System.Windows.Forms.TextBox tbPseudo;
        private System.Windows.Forms.NumericUpDown numUpNbJouers;
        private System.Windows.Forms.TextBox tbIA1;
        private System.Windows.Forms.TextBox tbIA2;
        private System.Windows.Forms.TextBox tbIA3;
        private System.Windows.Forms.TextBox tbIA4;
        private System.Windows.Forms.TextBox tbIA5;
        private System.Windows.Forms.Button btRetour;
        private System.Windows.Forms.Button btValider;
    }
}