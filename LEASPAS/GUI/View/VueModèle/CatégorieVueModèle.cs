using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using LEASPAS.Annotations;
using LEASPAS.Model;

namespace LEASPAS.GUI.View.VueModèle
{
    public class CatégorieVueModèle : INotifyPropertyChanged
    {
        #region Données

        private readonly ReadOnlyCollection<CatégorieVueModèle> _enfants;
        private readonly Catégorie _catégorie;


        // Nom standard...
        private bool _estSelectionné;
        private bool _estDéroulé;

        #endregion

        #region Constructeurs

        /// <summary>
        /// Construit le vue modèle associé à la catégorie passée en paramètre
        /// </summary>
        /// <param name="catégorie">Catégorie à représenter</param>
        public CatégorieVueModèle(Catégorie catégorie) : this(catégorie, null)
        {
        }

        private CatégorieVueModèle(Catégorie catégorie, CatégorieVueModèle parent)
        {
            _catégorie = catégorie;
            Parent = parent;

            _enfants = new ReadOnlyCollection<CatégorieVueModèle>(
                (from enfant in _catégorie.Enfants
                        select new CatégorieVueModèle(enfant, this))
                    .ToList());
        }

        #endregion

        #region Propriétées d'une catégorie
        public CatégorieVueModèle Parent { get; }
        public ReadOnlyCollection<CatégorieVueModèle> Enfants
        {
            get { return _enfants; }
        }

        public string Nom
        {
            get { return _catégorie.Nom; }
        }

        #endregion

        #region Propriétées de présentation

        /// <summary>
        /// Permet à l'item de catégorie que l'on représente de savoir
        /// gérée le déroulement des ses sous-catégories
        /// </summary>
        public bool IsExpanded
        {
            get { return _estDéroulé; }
            set
            {
                if (value != _estDéroulé)
                {
                    _estDéroulé = value;
                    OnPropertyChanged();
                }
                if (_estDéroulé && Parent != null)
                {
                    Parent.IsExpanded = true;
                }
            }
        }

        /// <summary>
        /// Permet à un Item de catégorie de gérer la séléction
        /// </summary>
        public bool IsSelected
        {
            get { return _estSelectionné; }
            set
            {
                if (value == _estSelectionné) return;
                _estSelectionné = value;
                OnPropertyChanged();
            }
        }

        public bool IsFocusable => Enfants.Count == 0;


        #endregion

        public override string ToString()
        {
            return _catégorie.Nom;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}