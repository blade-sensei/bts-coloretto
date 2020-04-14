using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Coloretto
{
    class Carte
    {
        string id;
        string nom;
        int largeur;

        public int Largeur
        {
            get { return largeur; }
            set { largeur = value; }
        }
        int hauteur;

        public int Hauteur
        {
            get { return hauteur; }
            set { hauteur = value; }
        }
        Image monImage;

        public Carte(string unId, string unNom, int uneLargeur, int uneHauteur, Image uneImage)
        {
            id = unId;
            nom = unNom;
            largeur = uneLargeur;
            hauteur = uneHauteur;
            monImage = uneImage;
        }

        public string GetId()
        {
            return this.id;
        }
        public string GetNom()
        {
            return this.nom;
        }

        public Image GetImage()
        {
            return this.monImage;
        }


    }
}
