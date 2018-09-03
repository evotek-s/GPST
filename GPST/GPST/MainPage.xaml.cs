using Android.Locations;
using Plugin.Geolocator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace GPST
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            
            MyMap.WidthRequest = App.ScreenWidth;
            MyMap.HeightRequest = App.ScreenHeight;

            MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(-6.1840798, 106.6994179), Distance.FromMiles(1)));
            
            

        }

        
    }
}
