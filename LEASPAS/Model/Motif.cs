using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEASPAS
{
    class Motif
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Motif(string name)
        {
            this.Name = name;
        }
    }
}
