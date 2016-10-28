using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using LEASPAS.Annotations;

namespace LEASPAS
{
    //The ViewModel for the eleve dialog
    internal class EleveDialogViewModel : INotifyPropertyChanged
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { this.MutateVerbose(ref _name, value, RaisePropertyChanged()); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private Action<PropertyChangedEventArgs> RaisePropertyChanged()
        {
            //TODO Understand once more what the fuck is this ?
            return args => PropertyChanged?.Invoke(this, args);
        } 
    }
}