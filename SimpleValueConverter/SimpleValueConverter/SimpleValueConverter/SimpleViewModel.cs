using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SimpleValueConverter
{
   public class SimpleViewModel : INotifyPropertyChanged
    {
        private double myValue = 1;
        public event PropertyChangedEventHandler PropertyChanged;

        public double MyValue
        {
            get
            {
                return myValue;
            }

            set
            {   if (myValue != value)
                { myValue = value;
                    onPropertyChanged();
                }
              
            }
        }

        public void onPropertyChanged([CallerMemberName] string propertyName= "")
        { var ev = PropertyChanged;
            if (ev != null)
            { ev(this, new PropertyChangedEventArgs(propertyName));
            }
        }


    }
}
