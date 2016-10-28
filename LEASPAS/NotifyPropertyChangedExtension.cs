using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LEASPAS
{
    public static class NotifyPropertyChangedExtension
    {
        //TODO Understand again this thing
        public static void MutateVerbose<TField>(this INotifyPropertyChanged instance, ref TField field, TField newValue,
            Action<PropertyChangedEventArgs> raise, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<TField>.Default.Equals(field, newValue)) return;
            field = newValue;
            raise?.Invoke(new PropertyChangedEventArgs(propertyName));
        }
    }
}
