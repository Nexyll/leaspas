using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEASPAS.Model {
    class Evenement {
        public DateTime Date { get; set; }
        public List<Categorie> Categories { get; set; }

        public Evenement(DateTime date, List<Categorie> categories)
        {
            Date = date;
            Categories = categories;
        }

        public Evenement()
        {
        }
    }
}
