using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using LEASPAS.Model;

namespace LEASPAS
{
    class Eleve
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public char Sexe { get; set; }
        public List<Motif> Motifs { get; } = new List<Motif>();
        public Niveau Niveau { get; set; } 
        public Origine Origine { get; set; }
        public Etablissement Etablissement { get; set; }
        public Eleve(int id, string nom, string prenom, char sexe, Motif motif, Niveau niveau, Origine origine, Etablissement etablissement)
        {
            ID = id;
            Nom = nom;
            Prenom = prenom;
            Sexe = sexe;
            Motifs.Add(motif);
            Niveau = niveau;
            Origine = origine;
            Etablissement = etablissement;
        }

        public Eleve()
        {
        }
    }
}
