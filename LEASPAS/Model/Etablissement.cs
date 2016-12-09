using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using LEASPAS.Annotations;

namespace LEASPAS.Model {
    [Serializable]
    public class Etablissement : INotifyPropertyChanged {
        private string _type;
        private string _nom;
        private int _population;

        public string Nom
        {
            get { return _nom; }
            set
            {
                _nom = value;
                OnPropertyChanged();
            } 
        }

        public string Type
        {
            get { return _type; }
            set
            {
                _type = value;
                OnPropertyChanged();
            }
        }

        public int Population
        {
            get { return _population; }
            set
            {
                _population = value;
                OnPropertyChanged();
            }
        }

        public Etablissement(string nom, string type, int population)
        {
            Nom = nom;
            Type = type;
            Population = population;
        }
        public Etablissement()
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
