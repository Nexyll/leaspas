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
using LEASPAS.Annotations;

namespace LEASPAS.GUI.View.Etablissement
{
    using Etablissement = LEASPAS.Model.Etablissement;
    /// <summary>
    /// Logique d'interaction pour VueEtablissements.xaml
    /// </summary>
    public partial class VueEtablissements : UserControl
    {
        private MainWindow _mainWindow;
        public VueEtablissements(MainWindow mainWindow)
        {
            InitializeComponent();
            DataContext = this;
            _mainWindow = mainWindow;
            DataGridEtablissement.ItemsSource = _mainWindow.Collection.Etablissements;
                        
        }
        /// <summary>
        /// Ajout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BoutonAjouter_OnClick(object sender, RoutedEventArgs e)
        {
            Etablissement etablissement = new Etablissement();
            VueEtablissement dialog = new VueEtablissement(etablissement);
            if (dialog.ShowDialog() == true)
            {
                _mainWindow.Collection.Etablissements.Add(etablissement);
            }
        }
        
        
    }
}
