﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEASPAS.Model
{
    class Niveau
    {
        public int ID { get; set; }
        public string Nom { get; set; }

        public Niveau(string nom)
        {
            Nom = nom;
        }
    }
}
