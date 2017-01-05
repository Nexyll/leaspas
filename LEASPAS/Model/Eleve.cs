using System;
using System.Collections.ObjectModel;

namespace LEASPAS.Model
{
    [Serializable]
    public class Eleve
    {
        /// <summary>
        /// Nom de l'élève
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Prénom de l'élève
        /// </summary>
        public string Prenom { get; set; }

        /// <summary>
        /// Sexe de l'élève
        /// </summary>
        public Sexe Sexe { get; set; }

        /// <summary>
        /// Niveau (exemple : Première, ...) de l'élève
        /// </summary>
        public Niveau Niveau { get; set; } 

        /// <summary>
        /// Origine de l'élève
        /// </summary>
        public Origine Origine { get; set; }

        /// <summary>
        /// Établissement dans lequel l'élève effectue ses études
        /// </summary>
        public Etablissement Etablissement { get; set; }

        /// <summary>
        /// Motifs pour lesquels l'élève est suivit
        /// </summary>
        public ObservableCollection<Motif> Motifs { get; set; } = new ObservableCollection<Motif>();

        /// <summary>
        /// Liste des évènements de l'élève
        /// </summary>
        public ObservableCollection<Evenement> Evenements { get; set; } = new ObservableCollection<Evenement>();

        public Eleve(string nom, string prenom, Sexe sexe, Niveau niveau, Origine origine, Etablissement etablissement)
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

        public override string ToString()
        {
            return Prenom + " " + Nom;
        }
    }

    public enum Sexe
    {
        Masculin,
        Féminin,
        Autre
    }
}
