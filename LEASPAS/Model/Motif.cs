using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEASPAS
{
    /// <summary>
    /// Motifs pour lesquels l'élève s'est présenté, au minimum 1, au maximum tous (16). 
    /// Les motifs sont toujours rattachés à l'élève et non aux évènements. 
    /// Ainsi l'ajout d'un nouvel évènement est susceptible de rajouter un nouveau motif.
    /// </summary>
    [Serializable]
    public class Motif
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
