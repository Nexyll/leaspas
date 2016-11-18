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

namespace LEASPAS.GUI.View
{
    /// <summary>
    /// Logique d'interaction pour AjoutEvenement.xaml
    /// </summary>
    public partial class AjoutEvenement : UserControl
    {
        private MainWindow _mainWindow;
        public AjoutEvenement(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }
    }
}
