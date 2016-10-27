﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEASPAS.Model
{
    [Serializable]
    class Database
    {
        public List<Categorie> Categories { get; set; }
        public List<Eleve> Eleves { get; set; }
        public List<Etablissement> Etablissements { get; set; }
        public List<Evenement> Evenements { get; set; }
        public List<Motif> Motifs { get; set; }
        public List<Niveau> Niveaux { get; set; }
        public List<Origine> Origines { get; set; }
        /// <summary>
        /// Constructeur pour créer la base de donnée à partir des listes
        /// </summary>
        /// <param name="categories"></param>
        /// <param name="eleves"></param>
        /// <param name="etablissements"></param>
        /// <param name="evenements"></param>
        /// <param name="motifs"></param>
        /// <param name="niveaux"></param>
        /// <param name="origines"></param>
        public Database(List<Categorie> categories, List<Eleve> eleves, List<Etablissement> etablissements, List<Evenement> evenements, List<Motif> motifs, List<Niveau> niveaux, List<Origine> origines)
        {
            Categories = categories;
            Eleves = eleves;
            Etablissements = etablissements;
            Evenements = evenements;
            Motifs = motifs;
            Niveaux = niveaux;
            Origines = origines;
        }
        /// <summary>
        /// Constructeur par copie
        /// </summary>
        /// <param name="db">Database à copiée</param>
        public Database(Database db)
        {
            Categories = db.Categories.ToList();
            Eleves = db.Eleves.ToList();
            Etablissements = db.Etablissements.ToList();
            Evenements = db.Evenements.ToList();
            Motifs = db.Motifs.ToList();
            Niveaux = db.Niveaux.ToList();
            Origines = db.Origines.ToList();
        }

        public Database()
        {
            Categories = new List<Categorie>();
            Eleves = new List<Eleve>();
            Etablissements = new List<Etablissement>();
            Evenements = new List<Evenement>();
            Motifs = new List<Motif>();
            Niveaux = new List<Niveau>();
            Origines = new List<Origine>();
        }
    }
}
