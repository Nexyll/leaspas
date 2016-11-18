using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEASPAS.Model
{
    /// <summary>
    /// Indique le tiers qui est à l'origine de la prise de contact de l'élève avec l'assistante sociale
    /// </summary>
    public class Origine
    {
        public string Type { get; set; }
        public Origine(string type)
        {
            Type = type;
        }
    }
}
