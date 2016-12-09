using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using LEASPAS.Model;

namespace LEASPAS
{
    [Serializable]
    public class Eleve
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public char Sexe { get; set; }
        public Niveau Niveau { get; set; } 
        public Origine Origine { get; set; }
        public Etablissement Etablissement { get; set; }
        public ObservableCollection<Motif> Motifs { get; set; } = new ObservableCollection<Motif>();
        public ObservableCollection<Evenement> Evenements { get; set; } = new ObservableCollection<Evenement>();

        public Eleve(string nom, string prenom, char sexe, Niveau niveau, Origine origine, Etablissement etablissement)
        {
            Nom = nom;
            Prenom = prenom;
            Sexe = sexe;
            Niveau = niveau;
            Origine = origine;
            Etablissement = etablissement;
        }


        public Eleve()
        {
            Niveau = new Niveau();
            Origine = new Origine();
            Etablissement = new Etablissement();
        }

        public Eleve(Eleve eleve)
            :this(eleve.Nom, eleve.Prenom, eleve.Sexe, eleve.Niveau, eleve.Origine, eleve.Etablissement)
        {
        }
    }
}
