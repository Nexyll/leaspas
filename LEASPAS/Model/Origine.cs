﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEASPAS.Model
{
    class Origine
    {
        public int ID { get; set; }
        public string Type { get; set; }

        public Origine(string type)
        {
            Type = type;
        }
    }
}
