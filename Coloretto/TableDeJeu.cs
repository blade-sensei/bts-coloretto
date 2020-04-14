using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coloretto
{
    class TableDeJeu
    {
        //Champs privées //
        private string id;
        private List<Carte> rangeeA;
        private List<Carte> rangeeB;
        private List<Carte> rangeeC;
        private List<Carte> tatDeCartes;
        private List<Carte> pioche;


        //Fonctions//
        public TableDeJeu(string unId)
        {
            id = unId;
        }

        public string GetId()
        {
            return this.id;
        }
        public List<Carte> GetRangeeA()
        {
            return this.rangeeA;
        }
        public List<Carte> GetRangeeB()
        {
            return this.rangeeB;
        }
        public List<Carte> GetRangeeC()
        {
            return this.rangeeC;
        }

        public List<Carte> GetTatDeCarte()
        {
            return this.tatDeCartes;
        }
        public List<Carte> GetPioche()
        {
            return this.pioche;
        }

        public void AjouterCarteDansRangee(Carte uneCarte,string uneRangee)
        {   Carte lacarte = uneCarte;
            string larangee = uneRangee;
            switch (larangee) //On pose la carte selon la rangée indiqué
            {
                case "A":
                    rangeeA.Add(lacarte); //Ajout d'une carte dans la propriété rangeeA
                    break;
                case "B":
                    rangeeB.Add(lacarte);
                    break;
                case "C":
                    rangeeC.Add(lacarte);
                    break;

            }            
 
        }
        public void AjouterCarteDansPioche(Carte uneCarte)
        {
            this.pioche.Add(uneCarte);
        
        }
        //Fin fonctions//
    }
}
