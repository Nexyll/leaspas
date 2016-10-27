using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEASPAS.Model
{
    [Serializable]
    class Origine
    {
        public string Type { get; set; }
        public Origine(string type)
        {
            Type = type;
        }
    }
}
