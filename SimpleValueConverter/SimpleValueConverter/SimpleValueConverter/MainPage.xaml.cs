using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SimpleValueConverter.Converters;

namespace SimpleValueConverter
{  
    public partial class MainPage : ContentPage
    {
        private SimpleViewModel svm;
        private intScaleValueConverter intScaleConverter = new intScaleValueConverter();

        public MainPage(SimpleViewModel svm)
        {
            InitializeComponent();
            this.svm = svm;
            BindingContext = this.svm;
            //slider3.SetBinding<SimpleViewModel>(Slider.ValueProperty, vm => vm.MyValue, BindingMode.TwoWay, intScaleConverter);
            //slider4.SetBinding<SimpleViewModel>(Slider.ValueProperty, vm=>vm.MyValue,BindingMode.OneWay);
            oneLabel.SetBinding<SimpleViewModel>(Label.TextProperty, vm => vm.MyValue, BindingMode.OneWay, intScaleConverter);
        }
    }
}
