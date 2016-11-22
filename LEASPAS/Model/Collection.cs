using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEASPAS.Model
{
    [Serializable]
    public class Collection
    {
        public ObservableCollection<Categorie> Categories { get; set; }
        public ObservableCollection<Eleve> Eleves { get; set; }
        public ObservableCollection<Etablissement> Etablissements { get; set; }
        public ObservableCollection<Evenement> Evenements { get; set; }
        public ObservableCollection<Motif> Motifs { get; set; }
        public ObservableCollection<Niveau> Niveaux { get; set; }
        public ObservableCollection<Origine> Origines { get; set; }
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
        public Collection(ObservableCollection<Categorie> categories, ObservableCollection<Eleve> eleves, ObservableCollection<Etablissement> etablissements, ObservableCollection<Evenement> evenements, ObservableCollection<Motif> motifs, ObservableCollection<Niveau> niveaux, ObservableCollection<Origine> origines)
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
        /// <param name="source">Database à copiée</param>
        public Collection(Collection source)
        {
            Categories = source.Categories;
            Eleves = source.Eleves;
            Etablissements = source.Etablissements;
            Evenements = source.Evenements;
            Motifs = source.Motifs;
            Niveaux = source.Niveaux;
            Origines = source.Origines;
        }

        public Collection()
        {
            Categories = new ObservableCollection<Categorie>();
            Eleves = new ObservableCollection<Eleve>();
            Etablissements = new ObservableCollection<Etablissement>();
            Evenements = new ObservableCollection<Evenement>();
            Motifs = new ObservableCollection<Motif>();
            Niveaux = new ObservableCollection<Niveau>();
            Origines = new ObservableCollection<Origine>();
        }
    }
}
