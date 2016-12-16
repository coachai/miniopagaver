using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TabbedePageExample
{
    public partial class App : Application
    {
        private TabbedPage myTabbedPage = new TabbedPage();
        private NavigationPage oneNavigationPage = new NavigationPage();
        private NavigationPage twoNavigationPage = new NavigationPage();
        private Page1 page1 = new Page1();
        private PageD pageD = new PageD(); 

        public App()
        {
            InitializeComponent();

            MainPage = myTabbedPage;

        }

        protected override async void OnStart()
        {
            // Handle when your app starts
           // await oneNavigationPage.PushAsync(page1);
            await twoNavigationPage.PushAsync(pageD);

            //oneNavigationPage.Title="oneNavigationPage";
            //twoNavigationPage.Title = "twoNavigationPage";

            myTabbedPage.Children.Add(oneNavigationPage);
            myTabbedPage.Children.Add(twoNavigationPage);
         
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
