using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEASPAS.Model {
    /// <summary>
    /// Représente un rendez-vous avec l'élève.
    /// </summary>
    [Serializable]
    public class Evenement {
        public DateTime Date { get; set; }
        public Catégorie Catégorie { get; set; }
        public Eleve Eleve { get; set; }

        public Evenement(DateTime date, Catégorie catégorie, Eleve eleve)
        {
            Date = date;
            Catégorie = catégorie;
            Eleve = eleve;
        }

        public Evenement()
        {
            Date = new DateTime();
            Catégorie = new Catégorie();
            Eleve = new Eleve();
        }
    }
}
