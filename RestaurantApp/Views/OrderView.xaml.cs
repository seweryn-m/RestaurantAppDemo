using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RestaurantApp.Views
{
    public partial class OrderView : ContentPage
    {
        public OrderView()
        {
            InitializeComponent();
        }

        void CarouselView_PositionChanged(System.Object sender, Xamarin.Forms.PositionChangedEventArgs e)
        {
            var carousel = sender as CarouselView;
            var views = carousel.VisibleViews;

            if(views.Count > 0)
            {
                foreach(var view in views)
                {
                    var img = view.FindByName<Image>("MenuImage");
                    ViewExtensions.CancelAnimations(img);

                    Task.Run(async () =>
                    {
                        await img.RelRotateTo(360, 5000, Easing.BounceOut);
                    });
                }
            }
        }
    }
}
