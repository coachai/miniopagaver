using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Xaml;

namespace App4
{
    class MyMarkupExtension : IMarkupExtension

    {
        public int a { get; set; }
        public int b { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            var result = 0;
            result = a + b;
            return "Calculate result is  " + result;

        }

    }
}
