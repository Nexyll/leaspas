using System.Windows;
using System.Windows.Controls;

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
            
            DataGridMotifs.ItemsSource = _mainWindow.Collection.Motifs;
            
        }
    }
}
