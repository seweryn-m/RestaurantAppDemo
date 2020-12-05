using System.Collections.Generic;
using System.Windows.Input;
using RestaurantApp.Model;
using Xamarin.Forms;

namespace RestaurantApp.ViewModels
{
    public class OrderViewModel : BasicViewModel
    {
        public OrderViewModel()
        {
            Picks = GetMenu();
        }

        public ICommand BackCommand => new Command(() =>
        {
            Application.Current.MainPage.Navigation.PopAsync();
        });

        public List<Pick> Picks { get; set; }

        private List<Pick> GetMenu()
        {
            return new List<Pick>
            {
                new Pick { Title = "The Ultimate Pack", Image = "IMG05.png", Description = "Prime beef burger topped with pepper jack cheese and crispy bacon.", Price = "$23.99" },
                new Pick { Title = "Lamb Bundle", Image = "IMG04.png", Description = "Lamb leg cooked in a Thai style yellow curry, with baby corn, string beans and chilies.", Price = "$19.99" },
                new Pick { Title = "Juicy Mushroom", Image = "IMG01.png", Description = "Wild mushroom and pea in a parmesan risotto served with crispy fried chicken.", Price = "$25.25" }
            };
        }
    }
}
