﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App5MVVM
{
    public partial class ClockPage : ContentPage
    {
        public ClockPage()
        {
            ClockViewModel cm = new ClockViewModel();
            BindingContext = cm;
            //InitializeComponent();
        }
    }
}
