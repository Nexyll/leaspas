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

namespace LEASPAS.GUI.View
{
    /// <summary>
    /// Logique d'interaction pour AjoutEditionOrigine.xaml
    /// </summary>
    public partial class AjoutEditionOrigine : Window
    {
        public Origine Origine { get; set; }
        public AjoutEditionOrigine(Origine origine)
        {
            InitializeComponent();
            DataContext = this;
            Origine = origine;
        }


        /// <summary>
        /// Event handler appelé quand l'utilisateur valide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonValidation_OnClick(object sender, RoutedEventArgs e)
        {
            if (TextBoxNomOrigine.Text != "")
            {
                DialogResult = true;
            }
            else
            {
                MessageBox.Show("Une origine ne doit pas être vide", "Erreur");
            }
        }
    }
}
