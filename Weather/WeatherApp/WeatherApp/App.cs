using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace WeatherApp
{
    public class App : Application
    {
        public App()
        {
            var oneDataService = new DataService();
            var oneModle = new Model(oneDataService);
            var oneViewModel = new ViewModel(oneModle);
            MainPage = new WeatherPage(oneViewModel);
           
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
