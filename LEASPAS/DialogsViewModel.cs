using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MaterialDesignThemes.Wpf;

namespace LEASPAS
{
    class DialogsViewModel : INotifyPropertyChanged
    {
        public ICommand RunEleveDialogCommand => new CommandImplementation(ExecuteEleveDialogCommand);

        private async void ExecuteEleveDialogCommand(object o)
        {
            var view = new EleveDialog
            {
                DataContext = new EleveDialogViewModel()
            };

            var result = await DialogHost.Show(view, "RootDialog", ClosingEventHandler);

            Console.WriteLine("Closed EleveDialog, commandParameter was : " + (result ?? "NULL"));
        }

        private void ClosingEventHandler(object sender, DialogClosingEventArgs eventArgs)
        {
            Console.WriteLine("You can intercept the closing event, and cancel here.");
        }
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
