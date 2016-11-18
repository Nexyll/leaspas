using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEASPAS.Model
{
    /// <summary>
    /// Représente la classe de l'élève (ex : 6, 5, 4, 3, 2nd, ...)
    /// Pour information. Le niveau n'est pas traité lorsque les statistiques sont générées. 
    /// </summary>
    public class Niveau
    {
        public string Nom { get; set; }
        public Niveau(string nom)
        {
            Nom = nom;
        }
    }
}
