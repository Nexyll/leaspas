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
        public int ID { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public char Sexe { get; set; }
        public List<Motif> Motifs { get; } = new List<Motif>();
        public Niveau Niveau { get; set; } 
        public Origine Origine { get; set; }
        public Etablissement Etablissement { get; set; }

        public Eleve(string nom, string prenom, char sexe, Motif motif)
        {
            Nom = nom;
            Prenom = prenom;
            Sexe = sexe;
            Motifs.Add(motif);
        }
    }
}
