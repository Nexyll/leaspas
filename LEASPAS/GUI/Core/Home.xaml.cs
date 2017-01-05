using System.Windows;
using System.Windows.Controls;
using LEASPAS.GUI.View.Élève;

namespace LEASPAS.GUI.Core {
    /// <summary>
    /// Logique d'interaction pour Home.xaml
    /// </summary>
    public partial class Home : UserControl
    {
        private MainWindow _mainWindow;
        public Home(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void TileManageEvents_OnClick(object sender, RoutedEventArgs e)
        {
            _mainWindow.ContentControl.Content = new EventOptions(_mainWindow);
        }

        private void TileEditionDonnéesEnvironnements_OnClick(object sender, RoutedEventArgs e)
        {
            _mainWindow.ContentControl.Content = new ChoixDonneeEnvironnement(_mainWindow);
        }

        private void TileGestionEleves_OnClick(object sender, RoutedEventArgs e)
        {
            _mainWindow.ContentControl.Content = new VueEleves(_mainWindow);
        }
    }
}
