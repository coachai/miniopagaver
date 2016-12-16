using System;
using Xamarin.Forms;

namespace WeatherApp
{
    public partial class WeatherPage : ContentPage
    {
        private ViewModel myViewModel;

        public WeatherPage(ViewModel viewModel)
        {
            InitializeComponent();
            this.Title = "Sample Weather App";

            this.myViewModel = viewModel;
            //Set the default binding to a default object for now
            this.BindingContext = myViewModel.CurrentWeather;
        }

        private async void OnTapped(object sender, EventArgs e)
         { 
             await myViewModel.UpdateAllWeather(); 
             BindingContext = myViewModel.CurrentWeather; 
         }

}
}