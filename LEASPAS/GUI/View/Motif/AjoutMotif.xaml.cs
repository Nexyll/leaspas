using System.Windows;

namespace LEASPAS.GUI.View.Motif
{
    /// <summary>
    /// Logique d'interaction pour AjoutEditionMotif.xaml
    /// </summary>
    public partial class AjoutMotif : Window
    {
        public Model.Motif Motif { get; set; }
        public AjoutMotif(Model.Motif motif)
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
