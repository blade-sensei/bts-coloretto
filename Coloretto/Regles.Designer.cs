namespace Coloretto
{
    partial class Regles
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
            this.lbTitleRegles = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.rchtBodyRegles = new System.Windows.Forms.RichTextBox();
            this.btRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitleRegles
            // 
            this.lbTitleRegles.AutoSize = true;
            this.lbTitleRegles.Font = new System.Drawing.Font("Comic Sans MS", 16.25F, System.Drawing.FontStyle.Bold);
            this.lbTitleRegles.Location = new System.Drawing.Point(29, 25);
            this.lbTitleRegles.Name = "lbTitleRegles";
            this.lbTitleRegles.Size = new System.Drawing.Size(81, 31);
            this.lbTitleRegles.TabIndex = 0;
            this.lbTitleRegles.Text = "Règles";
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
            this.lineShape1.X1 = 34;
            this.lineShape1.X2 = 594;
            this.lineShape1.Y1 = 63;
            this.lineShape1.Y2 = 64;
            // 
            // rchtBodyRegles
            // 
            this.rchtBodyRegles.Location = new System.Drawing.Point(35, 84);
            this.rchtBodyRegles.Name = "rchtBodyRegles";
            this.rchtBodyRegles.Size = new System.Drawing.Size(560, 348);
            this.rchtBodyRegles.TabIndex = 2;
            this.rchtBodyRegles.Text = "";
            // 
            // btRetour
            // 
            this.btRetour.Location = new System.Drawing.Point(35, 438);
            this.btRetour.Name = "btRetour";
            this.btRetour.Size = new System.Drawing.Size(75, 23);
            this.btRetour.TabIndex = 3;
            this.btRetour.Text = "<  Retour";
            this.btRetour.UseVisualStyleBackColor = true;
            // 
            // Regles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 473);
            this.Controls.Add(this.btRetour);
            this.Controls.Add(this.rchtBodyRegles);
            this.Controls.Add(this.lbTitleRegles);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Regles";
            this.Text = "Regles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitleRegles;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.RichTextBox rchtBodyRegles;
        private System.Windows.Forms.Button btRetour;
    }
}