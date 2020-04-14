using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coloretto
{
    class Manche
    {
        private string id;
        private List<Joueur> mesJoueurs;
        private TableDeJeu maTable;

        public Manche(string unId, List<Joueur> uneListe, TableDeJeu uneTable)
        { }

        public string GetId()
        {
            return this.id;
        }

        public List<Joueur> GetJoueurs()
        {
            return this.mesJoueurs;
        }

        public TableDeJeu GetTable()
        {
            return this.maTable;
        }

    }
}
