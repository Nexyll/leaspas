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
    /// Indique le tiers qui est à l'origine de la prise de contact de l'élève avec l'assistante sociale
    /// </summary>
    public class Origine : INotifyPropertyChanged
    {
        private string _nom;

        public string Nom
        {
            get { return _nom; }
            set
            {
                _nom = value; 
                OnPropertyChanged();
            }
        }
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="nom">Nom de l'origine</param>
        public Origine(string nom)
        {
            Nom = nom;
        }

        public Origine()
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
