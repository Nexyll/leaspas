using System.Windows;
using System.Windows.Controls;

namespace LEASPAS.GUI.View.Niveau
{
    using Niveau = LEASPAS.Model.Niveau;
    /// <summary>
    /// Logique d'interaction pour NiveauVue.xaml
    /// </summary>
    public partial class NiveauVue : UserControl
    {
        private MainWindow _mainWindow;
        public NiveauVue(MainWindow mainWindow)
        {
            InitializeComponent();
            DataContext = this;
            _mainWindow = mainWindow;
            DataGridNiveaux.ItemsSource = _mainWindow.Collection.Niveaux;
        }

        private void ButtonAjoutNiveau_OnClick(object sender, RoutedEventArgs e)
        {
            Niveau niveau = new Niveau();
            AjoutModificationNiveau dialog = new AjoutModificationNiveau(niveau);
            if (dialog.ShowDialog() == true)
            {
                _mainWindow.Collection.Niveaux.Add(niveau);
            }
        }

        private void ButtonModifierNiveau_OnClick(object sender, RoutedEventArgs e)
        {
            Niveau niveau = DataGridNiveaux.SelectedItem as Niveau;
            Niveau copieNiveau = new Niveau(niveau.Nom);
            AjoutModificationNiveau dialog = new AjoutModificationNiveau(copieNiveau);
            if (dialog.ShowDialog() == true)
            {
                niveau.Nom = copieNiveau.Nom;
            }
        }
    }
}
