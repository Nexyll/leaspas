using System.Windows;
using System.Windows.Controls;

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
    }
}
