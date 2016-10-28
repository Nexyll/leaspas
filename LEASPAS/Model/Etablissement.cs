﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEASPAS.Model {
    [Serializable]
    public class Etablissement {
        public String Nom { get; set; }
        public String Type { get; set; }
        public int Population { get; set; }

        public Etablissement(string nom, string type, int population)
        {
            Nom = nom;
            Type = type;
            Population = population;
        }
        public Etablissement()
        {
        }
    }
}
