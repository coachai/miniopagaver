using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TappePageTest
{
    public partial class App : Application
    {
        private TabbedPage tabbedPage = new TabbedPage();
        private NavigationPage navigationPageNumbers = new NavigationPage();
        private NavigationPage navigationPageLetters = new NavigationPage();
        private Page1 page1 = new Page1();
        private PageD pageD = new PageD();

        public App()
        {
            InitializeComponent();

            MainPage = tabbedPage;
        

            //tabbedPage.Children.Add(navigationPageNumbers);
            //tabbedPage.Children.Add(navigationPageLetters);
        }

        protected override async void OnStart()
        {
            // Handle when your app starts
            //var page1 = new Page1();
            //var pageA = new PageA();

            await navigationPageNumbers.PushAsync(page1);
            await navigationPageLetters.PushAsync(pageD);
            tabbedPage.Children.Add(navigationPageNumbers);
            tabbedPage.Children.Add(navigationPageLetters);
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
