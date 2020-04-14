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
    public partial class Parametres_score : Form
    {
        
        public Parametres_score()
        {
            
            InitializeComponent();

            
            
        }

        private void cardScoreA_Click(object sender, EventArgs e)
        {
            
        }

        private void Parametres_score_Load(object sender, EventArgs e)
        {

        }

        private void btValider_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lesJoueurs[0].GetNom());
        }

   
    }
}
