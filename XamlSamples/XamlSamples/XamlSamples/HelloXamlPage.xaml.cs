using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamlSamples
{
    public partial class HelloXamlPage : ContentPage
    {
        public HelloXamlPage()
        {
            InitializeComponent();
        }

        public void OnSlideValueChanged(object sender,
                          ValueChangedEventArgs args)
        { valueLabel.Text = args.NewValue.ToString("F3"); }

        async void OnButtonClicked(object sende, EventArgs args)
        { Button button = (Button)sende;
            await DisplayAlert("Clicked!",
        "The button labeled '" + button.Text + "' has been clicked",
        "OK");
        }
    }
    }

