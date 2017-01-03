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
using System.Windows.Navigation;
using System.Windows.Shapes;
using LEASPAS.GUI.View.VueModèle;

namespace LEASPAS.GUI.View.Catégorie
{
    /// <summary>
    /// Logique d'interaction pour VueCatégories.xaml
    /// </summary>
    public partial class VueCatégories : UserControl
    {
        private MainWindow _mainWindow;
        private ArbreCatégoriesVueModèle _catégories;
        public VueCatégories(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;

            _catégories = new ArbreCatégoriesVueModèle(_mainWindow.Collection.Categories.First());
            TreeViewCatégories.DataContext = _catégories;
        }

        private void ButtonAjout_OnClick(object sender, RoutedEventArgs e)
        {
            Model.Catégorie catégorie = new Model.Catégorie();
            VueCatégorie vueCatégorie = new VueCatégorie(catégorie, _mainWindow.Collection);
            if (vueCatégorie.ShowDialog() == true)
            {
                Model.Catégorie catégorieParente = vueCatégorie.ComboBoxParent.SelectedItem as Model.Catégorie;
                catégorieParente?.Enfants.Add(catégorie);
                _catégories = new ArbreCatégoriesVueModèle(_mainWindow.Collection.Categories.First());
                TreeViewCatégories.DataContext = _catégories;
            }
        }

        private void TreeViewCatégories_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (TreeViewCatégories.SelectedItem == null) return;
            
            CatégorieVueModèle vueModèleSelectionné = TreeViewCatégories.SelectedItem as CatégorieVueModèle;
            Model.Catégorie parent = CatégorieParente(_catégories.Catégories.First().Catégorie, vueModèleSelectionné?.Catégorie);
            VueCatégorie vueCatégorie = new VueCatégorie(vueModèleSelectionné?.Catégorie, parent, _mainWindow.Collection);
            if (vueCatégorie.ShowDialog() == true)
            {
                parent.Enfants.Remove(vueCatégorie.Catégorie);
                Model.Catégorie catégorie = vueCatégorie.ComboBoxParent.SelectedItem as Model.Catégorie;
                catégorie?.Enfants.Add(vueCatégorie.Catégorie);
                _catégories = new ArbreCatégoriesVueModèle(_mainWindow.Collection.Categories.First());
                TreeViewCatégories.DataContext = _catégories;
            }
        }
        

        //TODO déplacer dans le vue modèle
        private Model.Catégorie CatégorieParente(Model.Catégorie racine, Model.Catégorie catégorie)
        {
            Model.Catégorie res = null;
                foreach (Model.Catégorie catégorieFille in racine.Enfants)
                {
                    if (catégorieFille == catégorie)
                    {
                        res = racine;
                    }
                    else if(catégorieFille.Enfants.Count != 0)
                    {
                        res = CatégorieParente(catégorieFille, catégorie);
                    }
                }
            
            return res;
        }
    }
}
