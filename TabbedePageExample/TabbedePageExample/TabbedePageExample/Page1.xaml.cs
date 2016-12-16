using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TabbedePageExample
{
    public partial class Page1 : TabbedPage
    {
       // private NavigationPage oneNavigationPage = new NavigationPage();
       // private Page2 page2 = new Page2();
        public Page1()
        {
            InitializeComponent();
         
        }

        private async void Button1Clicked(Object o, EventArgs e)
        {
           // var tabbedPage = new TabbedPage();
            var page2 = new Page2();
           // tabbedPage.Children.Add(page2);

            await Navigation.PushAsync(page2);
        }
    }
}
