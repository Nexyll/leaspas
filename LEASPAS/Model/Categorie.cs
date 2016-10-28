using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEASPAS.Model {

    [Serializable]
    public class Categorie {

        public String Nom { get; set; }
        /// <summary>
        /// Parent de la catégorie, = null si la catégorie n'as pas de parent
        /// </summary>
        public Categorie Parent { get; set; }

        public Categorie(string nom, Categorie parent)
        {
            Nom = nom;
            Parent = parent;
        }
        /// <summary>
        /// Création d'une catégroie sans parent.
        /// La valeur du parent sera donc mise à NULL
        /// </summary>
        /// <param name="nom"></param>
        public Categorie(string nom)
        {
            Nom = nom;
            Parent = null;
        }

        public Categorie()
        {
        }
    }
}
