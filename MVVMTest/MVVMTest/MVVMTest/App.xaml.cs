using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using MVVMTest;
using MVVMTest.ViewModels;
using MVVMTest.Page;

namespace MVVMTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var viewModelTest = new ViewModelTest();
            MainPage = new TestPage(viewModelTest);
            

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
