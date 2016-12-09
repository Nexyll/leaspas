using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using LEASPAS.Annotations;

namespace LEASPAS.Model
{
    /// <summary>
    /// Représente la classe de l'élève (ex : 6, 5, 4, 3, 2nd, ...)
    /// Pour information. Le niveau n'est pas traité lorsque les statistiques sont générées. 
    /// </summary>
    public class Niveau : INotifyPropertyChanged
    {
        private string _nom;

        public string Nom
        {
            get
            {
                return _nom;
            }
            set
            {
                _nom = value;
                OnPropertyChanged();
            }
        }

        public Niveau(string nom)
        {
            Nom = nom;
        }

        public Niveau()
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
