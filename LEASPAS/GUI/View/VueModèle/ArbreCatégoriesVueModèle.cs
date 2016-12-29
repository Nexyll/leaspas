using System.Collections;
using System.Collections.ObjectModel;
using LEASPAS.Model;

namespace LEASPAS.GUI.View.VueModèle
{
    public class ArbreCatégoriesVueModèle
    {
        #region Données

        private readonly CatégorieVueModèle _catégorieParente;

        #endregion

        #region Constructeurs

        public ArbreCatégoriesVueModèle(Model.Catégorie catégorieParente)
        {
            _catégorieParente = new CatégorieVueModèle(catégorieParente);
            Catégories = new ReadOnlyCollection<CatégorieVueModèle>(
                new CatégorieVueModèle[]
                {
                    _catégorieParente
                });
        }
        #endregion

        #region Propriétées

        public ReadOnlyCollection<CatégorieVueModèle> Catégories { get; }

        #endregion
    }
}