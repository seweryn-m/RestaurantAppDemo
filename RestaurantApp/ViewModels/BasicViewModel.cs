using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RestaurantApp.ViewModels
{
    public class BasicViewModel : INotifyPropertyChanged
    {
        public BasicViewModel()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
