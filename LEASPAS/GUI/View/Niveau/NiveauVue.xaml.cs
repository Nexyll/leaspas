using System;
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
            _mainWindow.OnContentQuit += MainWindowOnOnContentQuit;
            DataGridNiveaux.ItemsSource = _mainWindow.Collection.Niveaux;
            DataGridNiveaux.CanUserAddRows = true;
        }

        /// <summary>
        /// Event handler pour l'évenement de changement de contenu dans la fenêtre principale
        /// </summary>
        private void MainWindowOnOnContentQuit()
        {
            DataGridNiveaux.CanUserAddRows = false;
        }


        /// <summary>
        /// Event handler appelé quand l'utilisateur ajoute un niveau
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
