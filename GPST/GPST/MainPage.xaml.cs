using Android.Locations;
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
           
            
        }
    }
}
