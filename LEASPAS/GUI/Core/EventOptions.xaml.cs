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
using LEASPAS.GUI.View;

namespace LEASPAS.GUI.Core
{
    /// <summary>
    /// Logique d'interaction pour EventOptions.xaml
    /// </summary>
    public partial class EventOptions : UserControl
    {
        private MainWindow _mainWindow;
        public EventOptions(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void TileAjoutEvenement_OnClick(object sender, RoutedEventArgs e)
        {
            _mainWindow.ContentControl.Content = new AjoutEvenement(_mainWindow);
        }

        private void TileEventsView_OnClick(object sender, RoutedEventArgs e)
        {
            _mainWindow.ContentControl.Content = new EventsView();
        }
    }
}
