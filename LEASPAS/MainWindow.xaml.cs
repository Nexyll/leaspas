using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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
using System.Windows.Shapes;
using LEASPAS.Model;
using LEASPAS.Model.Persistance;
using Home = LEASPAS.GUI.Core.Home;
using Path = System.IO.Path;

namespace LEASPAS
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public Model.Collection Collection { get; set; }
        public ISauvegarde Sauvegarde { get; set; }
        
        public delegate void OnContentQuitEventHandler();
        /// <summary>
        /// Evenement appellé lors du changement de contenu dans la fenêter principale
        /// </summary>
        public event OnContentQuitEventHandler OnContentQuit;
        public MainWindow()
        {
            InitializeComponent();
            ChargerCollection();
            Application.Current.MainWindow.Closing += MainWindowOnClosing;
            ContentControl.Content = new Home(this);
        }

        /// <summary>
        /// Event handler pour la fermeture de l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="cancelEventArgs"></param>
        private void MainWindowOnClosing(object sender, CancelEventArgs cancelEventArgs)
        {
            string appPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string fullPath = appPath + "\\" + "data.bin";
            Sauvegarde.Sauvegarder(fullPath, Collection);
        }

        /// <summary>
        /// Permet de charger les données locales
        /// </summary>
        private void ChargerCollection()
        {
            Sauvegarde = new SauvegardeBinaire();
            string appPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string fullPath = appPath + "\\" + "data.bin";

            if (File.Exists(fullPath))
            {
                Collection = Sauvegarde.Charger(fullPath);
            }
            else
            {
                Collection = new Collection();
            }

        }

        /// <summary>
        /// Event handler pour le bouton accueil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Accueil_OnClick(object sender, RoutedEventArgs e)
        {
            OnContentQuit?.Invoke();
            ContentControl.Content = new Home(this);
        }
        
    }
}
