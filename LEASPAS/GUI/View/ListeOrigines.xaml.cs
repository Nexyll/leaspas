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
    /// Logique d'interaction pour ListeOrigines.xaml
    /// </summary>
    public partial class ListeOrigines : UserControl
    {
        private MainWindow _mainWindow;
        public ListeOrigines(MainWindow mainWindow)
        {
            InitializeComponent();
            DataContext = this;
            _mainWindow = mainWindow;
            ListViewOrigines.ItemsSource = _mainWindow.Collection.Origines;
        }

        private void ButtonAjouterOrigine_OnClick(object sender, RoutedEventArgs e)
        {
            Origine origine = new Origine();
            AjoutEditionOrigine dialog = new AjoutEditionOrigine(origine);
            if (dialog.ShowDialog() == true)
            {
                _mainWindow.Collection.Origines.Add(origine);
            }
        }

        private void ButtonModifierOrigine_OnClick(object sender, RoutedEventArgs e)
        {
            Origine origine = ListViewOrigines.SelectedItem as Origine;
            Origine copieOrigine = new Origine(origine.Nom);
            AjoutEditionOrigine dialog = new AjoutEditionOrigine(copieOrigine);
            if (dialog.ShowDialog() == true)
            {
                origine.Nom = copieOrigine.Nom;
            }
        }
    }
}
