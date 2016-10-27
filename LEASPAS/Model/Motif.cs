using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEASPAS
{
    [Serializable]
    class Motif
    {
        public String Nom { get; set; }
        public Motif(string nom)
        {
            Nom = nom;
        }
        public Motif()
        {
        }
    }
}
