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

namespace LEASPAS.GUI.View
{
    /// <summary>
    /// Logique d'interaction pour AjoutMotif.xaml
    /// </summary>
    public partial class AjoutMotif : Window
    {
        public Motif Motif { get; set; }
        public AjoutMotif(Motif motif)
        {
            InitializeComponent();
            DataContext = this;
            Motif = motif;
        }

        private void ButtonValidation_OnClick(object sender, RoutedEventArgs e)
        {
            if (TextBoxNomMotif.Text != "")
            {
                DialogResult = true;
            }
            else
            {
                MessageBox.Show("Erreur", "Un motif ne doit pas être vide");
            }
        }
    }
}
