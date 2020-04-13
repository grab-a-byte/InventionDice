using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace InventionDice.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private bool _isBusy = true;
        public virtual void Initialise()
        {
        }

        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public bool IsBusy
        {
            get => _isBusy;
            set { _isBusy = value; NotifyPropertyChanged(); }
        }
    }
}
