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
using LEASPAS.Model;

namespace LEASPAS.GUI.View
{
    /// <summary>
    /// Logique d'interaction pour AjoutEvenement.xaml
    /// </summary>
    public partial class AjoutEvenement : UserControl
    {
        private Evenement _evenement;
        private MainWindow _mainWindow;
        public AjoutEvenement(MainWindow mainWindow, Evenement evenement)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
            DataContext = this;
            _evenement = evenement;

            
            CollectionView collectionVueMotifsGlobaux = new CollectionView(_mainWindow.Collection.Motifs);
            ListBoxMotifs.ItemsSource = collectionVueMotifsGlobaux;
            ListBoxMotifsEvenement.ItemsSource = _evenement.Eleve.Motifs;
       
        }
        /// <summary>
        /// Méthode appelée quand l'événement click du bouton >> levé.
        /// Cette méthode sert à ajouter un motif à l'élève si il ne le possède pas déjà.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BouttonAjoutMotif_OnClick(object sender, RoutedEventArgs e)
        {
            if (ListBoxMotifs.SelectedItem != null && !_evenement.Eleve.Motifs.Contains(ListBoxMotifs.SelectedItem))
            {
                _evenement.Eleve.Motifs.Add(ListBoxMotifs.SelectedItem as Model.Motif);
            }
        }
    }
}
