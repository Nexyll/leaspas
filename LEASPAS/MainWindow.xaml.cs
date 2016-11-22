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
using System.Windows.Shapes;
using LEASPAS.Model;
using Home = LEASPAS.GUI.Core.Home;

namespace LEASPAS
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public Model.Collection Collection { get; set; } 
        public MainWindow()
        {
            InitializeComponent();
            Collection = new Collection();
            Collection.Motifs.Add(new Motif("Bonjour"));
            Collection.Motifs.Add(new Motif("Bonjour"));
            Collection.Motifs.Add(new Motif("Bonjour"));
            Collection.Motifs.Add(new Motif("Bonjour"));
            Collection.Motifs.Add(new Motif("Bonjour"));
            Collection.Origines.Add(new Origine("Test origine"));
            ContentControl.Content = new Home(this);
        }
    }
}
