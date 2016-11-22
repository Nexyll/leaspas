using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using LEASPAS.Annotations;

namespace LEASPAS
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
    }
}
