using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
using MahApps.Metro.Controls.Dialogs;

namespace LEASPAS.GUI.View
{
    /// <summary>
    /// Logique d'interaction pour ListeMotifs.xaml
    /// </summary>
    public partial class ListeMotifs : UserControl
    {
        private MainWindow _mainWindow;
        public ListeMotifs(MainWindow mainWindow)
        {
            InitializeComponent();
            DataContext = this;
            _mainWindow = mainWindow;
            ListViewMotifs.ItemsSource = _mainWindow.Collection.Motifs;
        }

        private void ButtonAjouterMotif_OnClick(object sender, RoutedEventArgs e)
        {
            Motif motif = new Motif();
            AjoutMotif dialog = new AjoutMotif(motif);
            if (dialog.ShowDialog() == true)
            {
                _mainWindow.Collection.Motifs.Add(motif);
            }
        }

        private void ButtonModifierMotif_OnClick(object sender, RoutedEventArgs e)
        {
            Motif motif = ListViewMotifs.SelectedItem as Motif;
            Motif copieMotif = new Motif(motif.Nom);
            AjoutMotif dialog = new AjoutMotif(copieMotif);
            if (dialog.ShowDialog() == true)
            {
                motif.Nom = copieMotif.Nom;
            }
        }
    }
}
