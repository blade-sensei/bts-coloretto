using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Coloretto
{
    public partial class Parametres_nom : Form
    {
        List<Joueur> lesJoueurs = new List<Joueur>();
        public Parametres_nom()
        {
            InitializeComponent();
                    
            
        }

        private void Parametres_nom_Load(object sender, EventArgs e)
        {

        }

        private void numUpNbJouers_ValueChanged(object sender, EventArgs e)
        {
            if (numUpNbJouers.Value >= 1)
            {
                tbIA1.Visible = true;
            }
            else
                tbIA1.Visible = false;

            if (numUpNbJouers.Value >= 2)
            {
                tbIA2.Visible = true;
            }
            else
                tbIA2.Visible = false;

            if (numUpNbJouers.Value >= 3)
            {
                tbIA3.Visible = true;
            }
            else
                tbIA3.Visible = false;
            if (numUpNbJouers.Value >= 4)
            {
                tbIA4.Visible = true;
            }
            else
                tbIA4.Visible = false;
            if (numUpNbJouers.Value == 5)
            {
                tbIA5.Visible = true;
            }
            else
                tbIA5.Visible = false;

            
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            foreach (Control t in this.Controls)
            {
                int compteur = 0;
                if (t.Visible == true && t is TextBox)
                {
                    


                    string nom_joueur = t.Text;
                    Joueur player = new Joueur(compteur, nom_joueur);
                    lesJoueurs.Add(player);
                }
                compteur = compteur + 1;
            }
            foreach(Joueur j in lesJoueurs)
            {
                MessageBox.Show(j.GetNom());
            }

            Parametres_score form = new Parametres_score();
           
            this.Hide();
            form.Show();
            
        }
    }
}
