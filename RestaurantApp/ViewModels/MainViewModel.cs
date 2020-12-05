using System.Collections.Generic;
using System.Windows.Input;
using RestaurantApp.Model;
using RestaurantApp.Views;
using Xamarin.Forms;

namespace RestaurantApp.ViewModels
{
    public class MainViewModel : BasicViewModel
    {
        public MainViewModel()
        {
            Picks = GetPicks();
        }

        public List<Pick> Picks { get; set; }

        public ICommand OrderCommand => new Command(() => Application.Current.MainPage.Navigation.PushAsync(new OrderView()));

        private List<Pick> GetPicks()
        {
            return new List<Pick>
            {
                new Pick { Title = "Breakfast", Image = "IMG01.png",
                    Description = "Order our healthy and warm breakfast menu for a great morning"},
                new Pick { Title = "Lunch", Image = "IMG03.png",
                    Description = "Delicious lunch to keep your day sweet and smouth"}
            };
        }
    }
}
