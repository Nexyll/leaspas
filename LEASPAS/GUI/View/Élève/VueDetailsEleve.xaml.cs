using System.Windows.Controls;
using LEASPAS.Model;

namespace LEASPAS.GUI.View.Élève
{
    /// <summary>
    /// Logique d'interaction pour VueDetailsEleve.xaml
    /// </summary>
    public partial class VueDetailsEleve : UserControl
    {
        private MainWindow _mainWindow;
        public Eleve Eleve { get; set; }
        public VueDetailsEleve(Eleve eleve, MainWindow mainWindow)
        {
            _mainWindow = mainWindow;
            Eleve = eleve;
            InitializeComponent();
            DataContext = this;
        }
    }
}
