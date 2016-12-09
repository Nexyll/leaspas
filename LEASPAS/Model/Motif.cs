using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using LEASPAS.Annotations;

namespace LEASPAS.Model
{
    /// <summary>
    /// Motifs pour lesquels l'élève s'est présenté, au minimum 1, au maximum tous (16). 
    /// Les motifs sont toujours rattachés à l'élève et non aux évènements. 
    /// Ainsi l'ajout d'un nouvel évènement est susceptible de rajouter un nouveau motif.
    /// </summary>
    [Serializable]
    public class Motif : INotifyPropertyChanged
    {
        private String _nom;
        public String Nom
        {
            get { return _nom; }
            set
            {
                _nom = value;
                OnPropertyChanged();
            }
        }

        public Motif(string nom)
        {
            Nom = nom;
        }
        public Motif()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public override string ToString()
        {
            return Nom;
        }
    }
}
