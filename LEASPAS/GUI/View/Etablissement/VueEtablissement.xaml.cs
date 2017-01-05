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

namespace LEASPAS.GUI.View.Etablissement
{
    using Etablissement = LEASPAS.Model.Etablissement;
    /// <summary>
    /// Logique d'interaction pour VueEtablissement.xaml
    /// </summary>
    public partial class VueEtablissement
    {
        public Etablissement Etablissement { get; set; }
        public VueEtablissement(Etablissement etablissement)
        {
            InitializeComponent();
            DataContext = this;
            Etablissement = etablissement;
        }

        private void BouttonValider_OnClick(object sender, RoutedEventArgs e)
        {

                DialogResult = true;
        }
    }
}
