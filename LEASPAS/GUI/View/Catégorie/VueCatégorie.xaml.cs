using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using LEASPAS.Model;

namespace LEASPAS.GUI.View.Catégorie
{
    /// <summary>
    /// Logique d'interaction pour VueCatégorie.xaml
    /// </summary>
    public partial class VueCatégorie
    {
        public Model.Catégorie Catégorie { get; set; }
        private Collection _collection;
        public VueCatégorie(Model.Catégorie catégorie, Collection collection)
        {
            InitializeComponent();
            Catégorie = catégorie;
            _collection = collection;
            DataContext = this;
            ComboBoxParent.ItemsSource = EnsembleCatégories();
        }

        public VueCatégorie(Model.Catégorie catégorie, Model.Catégorie parent, Collection collection)
        {
            InitializeComponent();
            Catégorie = catégorie;
            _collection = collection;
            DataContext = this;
            ComboBoxParent.ItemsSource = EnsembleCatégories();
            ComboBoxParent.SelectedItem = parent;
        }

        private List<Model.Catégorie> EnsembleCatégories()
        {
            return CatégoriesEnfants(_collection.Categories.First());
        }

        private List<Model.Catégorie> CatégoriesEnfants(Model.Catégorie catégorie)
        {
            List<Model.Catégorie> catégories = new List<Model.Catégorie>();
            catégories.Add(catégorie);
            foreach (Model.Catégorie catégorieEnfant in catégorie.Enfants)
            {
                if (catégorieEnfant.Enfants.Count != 0)
                {
                    catégories = catégories.Concat(CatégoriesEnfants(catégorieEnfant)).ToList();
                }
                else
                {
                    catégories.Add(catégorieEnfant);
                }
            }
            return catégories;
        }

        private void ButtonValider_OnClick(object sender, RoutedEventArgs e)
        {
            if (TextBoxNom.Text != "" && ComboBoxParent.SelectedItem != null)
            {
                Catégorie.Nom = TextBoxNom.Text;
                DialogResult = true;
            }
            else
            {
                MessageBox.Show(this, "Vous devez remplir tout les champs", "Erreur de saisie", MessageBoxButton.OK);
            }
        }
    }
}
