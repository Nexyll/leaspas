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

            _catégories = new ArbreCatégoriesVueModèle(mainWindow.Collection.Categories.First());
            TreeViewCatégories.DataContext = _catégories;
            TreeViewCatégories.SelectedItemChanged += TreeViewCatégories_SelectedItemChanged;
        }

        private void TreeViewCatégories_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            ;
        }

        private void ButtonAjout_OnClick(object sender, RoutedEventArgs e)
        {
            Model.Catégorie catégorie = new Model.Catégorie();
            VueCatégorie vueCatégorie = new VueCatégorie(catégorie, _mainWindow.Collection);
            vueCatégorie.Show();
        }
    }
}
