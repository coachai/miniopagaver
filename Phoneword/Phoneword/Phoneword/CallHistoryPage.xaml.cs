using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Phoneword
{
    public partial class CallHistoryPage : ContentPage
    {
        public CallHistoryPage()
        {
            InitializeComponent();
           
        }


        async void OnCallHistory(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
