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

namespace LEASPAS.GUI.View.Élève
{
    /// <summary>
    /// Logique d'interaction pour VueEleve.xaml
    /// </summary>
    public partial class VueEleve : UserControl
    {
        public Eleve Eleve { get; set; }
        private MainWindow _mainWindow;
        public VueEleve(Eleve eleve, MainWindow mainWindow)
        {
            InitializeComponent();
            DataContext = this;
            Eleve = eleve;
            _mainWindow = mainWindow;
            ComboBoxSexe.ItemsSource = Enum.GetValues(typeof(Sexe));
            ComboBoxEtablissement.ItemsSource = _mainWindow.Collection.Etablissements;
            ComboBoxNiveau.ItemsSource = _mainWindow.Collection.Niveaux;
            ComboBoxOrigine.ItemsSource = _mainWindow.Collection.Origines;
        }

        private void buttonValidation_Click(object sender, RoutedEventArgs e)
        {
            
            _mainWindow.Collection.Eleves.Add(Eleve);
            _mainWindow.ContentControl.Content = new VueEleves(_mainWindow);
        }
    }
}
