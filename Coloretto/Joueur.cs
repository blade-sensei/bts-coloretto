using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coloretto
{
    class Joueur
    {
        private int id;
        private string nom;
        private int scoreManche;
        private List<Carte> cartesCouleur;
        private bool typeScore;
        private string couleurDepart;
        private List<Carte> jokers;
        private List<Carte> plusDeux;


        public Joueur(int unId, string unNom)
        {
            id = unId;
            nom = unNom;
        }

        public Joueur()
        {
            // TODO: Complete member initialization
        }

        public int GetId()
        {
            return this.id;
        }
        public string GetNom()
        {
            return this.nom;
        }
        public int GetScoreManche()
        {
            return this.scoreManche;
        }
        public List<Carte> GetLesCartes()
        {
            return this.cartesCouleur;
        }
        public void PrendreRangee(TableDeJeu uneTable, string uneRangee)
        {
            //Ajoute les cartes de la rangée choisie et la mes dans les propriétés mesCartes du joueur
            switch (uneRangee) { 
                case "A":
                    
                    foreach (Carte c in uneTable.GetRangeeA())
                    {
                        this.cartesCouleur.Add(c);
                    }
                    break;
                case "B":
                    foreach(Carte c in uneTable.GetRangeeB())
                    {
                        this.cartesCouleur.Add(c);
                    }
                    break;
                case "C":
                    foreach (Carte c in uneTable.GetRangeeC())
                    {
                        this.cartesCouleur.Add(c);
                    }
                    break;                        
            }
        }

        public void PiocheCarte(TableDeJeu uneTable)
        {
            Carte carteAjouter = uneTable.GetPioche()[0];
            uneTable.AjouterCarteDansPioche(carteAjouter);
        }
    }
}
