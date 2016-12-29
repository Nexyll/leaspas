﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using LEASPAS.Annotations;

namespace LEASPAS.Model {
    /// <summary>
    /// Représente les catégories d'évènements. 
    /// Un évènement a forcément une seule et unique catégorie, nécéssairement une catégorie enfant, sauf si la catégorie parente n'a pas d'enfant (cas de "visite à domicile").
    /// </summary>
    public class Catégorie {
        private readonly List<Catégorie> _enfants = new List<Catégorie>();

        public List<Catégorie> Enfants
        {
            get { return _enfants; }
        }

        public string Nom { get; set; }

        public Catégorie(string nom)
        {
            Nom = nom;
        }

        public Catégorie()
        {
        }
    }
}
