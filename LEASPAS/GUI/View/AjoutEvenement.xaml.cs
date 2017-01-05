using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

            ListBoxMotifs.ItemsSource = _mainWindow.Collection.Motifs;
            ListBoxMotifsEleve.ItemsSource = _evenement.Eleve.Motifs;
            ComboBoxListeEleve.ItemsSource = mainWindow.Collection.Eleves;

            ArbreCatégoriesVueModèle Catégories = new ArbreCatégoriesVueModèle(_mainWindow.Collection.Categories.First());
            TreeViewCatégories.DataContext = Catégories;
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

        /// <summary>
        /// Supprime le motif séléctionné dans la liste des motifs de l'élève
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BouttonSupressionMotif_OnClick(object sender, RoutedEventArgs e)
        {
            if (ListBoxMotifsEleve.SelectedItem != null)
            {
                _evenement.Eleve.Motifs.Remove(ListBoxMotifsEleve.SelectedItem as Model.Motif);
            }
        }
    }
}
