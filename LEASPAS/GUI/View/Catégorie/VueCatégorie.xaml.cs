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

            ComboBoxParent.ItemsSource = _collection.Categories;
        }
    }
}
