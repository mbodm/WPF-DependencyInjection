using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfDependencyInjection
{
    public abstract class ObservableModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (string.IsNullOrEmpty(propertyName)) return;

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T oldValue, T newValue, [CallerMemberName] string propertyName = "")
        {
            if (Equals(oldValue, newValue))
            {
                return false;
            }

            oldValue = newValue;

            OnPropertyChanged(propertyName);

            return true;
        }
    }
}
