using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace LEASPAS.GUI.View.Motif
{
    using Motif = LEASPAS.Model.Motif;
    /// <summary>
    /// Logique d'interaction pour MotifsVue.xaml
    /// </summary>
    public partial class ListeMotifs : UserControl
    {
        private MainWindow _mainWindow;
        public ListeMotifs(MainWindow mainWindow)
        {
            InitializeComponent();
            DataContext = this;
            _mainWindow = mainWindow;
            _mainWindow.OnContentQuit += MainWindowOnOnContentQuit;
            DataGridMotifs.ItemsSource = _mainWindow.Collection.Motifs;
            DataGridMotifs.CanUserAddRows = true;
        }

        private void MainWindowOnOnContentQuit()
        {
            DataGridMotifs.CanUserAddRows = false;
        }
    }
}
