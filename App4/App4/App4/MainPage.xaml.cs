using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace App4
{
    public partial class MainPage : ContentPage
    {
        public class User {
         public string Name { get; set; }
         public string PhoneNumber { get; set; }
    }

    private static readonly System.Collections.ObjectModel.ObservableCollection<User> TestUsers = new System.Collections.ObjectModel.ObservableCollection<User>
        {   new User{Name ="Hua CHai",PhoneNumber = "243434342"},
            new User{Name ="Benny Bananhus",PhoneNumber = "1234567"},
            new User{Name ="Tonny Tupe",PhoneNumber = "2020202020"},
        };
    
        public MainPage()
        {
            InitializeComponent();
        }
    }
}
