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


namespace LEASPAS.GUI.View.Niveau
{
    using Niveau = LEASPAS.Model.Niveau;
    /// <summary>
    /// Logique d'interaction pour AjoutEditionNiveau.xaml
    /// </summary>
    public partial class AjoutModificationNiveau : Window
    {
        public Niveau Niveau { get; set; }
        public AjoutModificationNiveau(Niveau niveau)
        {
            InitializeComponent();
            DataContext = this;
            Niveau = niveau;
        }

        private void ButtonValidation_OnClick(object sender, RoutedEventArgs e)
        {
            if (TextBoxNomNiveau.Text != "")
            {
                DialogResult = true;
            }
            else
            {
                MessageBox.Show("Un niveau doit avoir un nom", "Erreur");
            }
        }
    }
}
