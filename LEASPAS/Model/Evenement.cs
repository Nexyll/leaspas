using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEASPAS.Model {
    [Serializable]
    class Evenement {
        public DateTime Date { get; set; }
        public Categorie Categorie { get; set; }
        public Eleve Eleve { get; set; }

        public Evenement(DateTime date, Categorie categorie, Eleve eleve)
        {
            Date = date;
            Categorie = categorie;
            Eleve = eleve;
        }

        public Evenement()
        {
        }
    }
}
