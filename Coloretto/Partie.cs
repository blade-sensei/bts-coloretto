using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coloretto
{
    class Partie
    {
        string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        List<Manche> mesManches;

        public List<Manche> MesManches
        {
            get { return mesManches; }
            set { mesManches = value; }
        }
        string nomGagnant;

        public string NomGagnant
        {
            
            set { nomGagnant = value; }
        }

        public Partie(string unId)
        {
            id = unId;
        }

        public string GetId()
        {
            return this.id;
        }

        public List<Manche> GetManches()
        {
            return this.mesManches;
        }

        public string GetGagnant()
        {
            return this.nomGagnant;
        }
    }
}
