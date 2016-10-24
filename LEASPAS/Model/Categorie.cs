using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEASPAS.Model {
    class Categorie {
        public int ID { get; set; }
        public String Nom { get; set; }
        public Categorie Parent { get; set; }

        public Categorie(string nom, Categorie parent)
        {
            Nom = nom;
            Parent = parent;
        }

        public Categorie(string nom)
        {
            Nom = nom;
        }

        public Categorie()
        {
        }
    }
}
