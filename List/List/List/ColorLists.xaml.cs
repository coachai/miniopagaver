using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace List
{
    public partial class ColorLists : ContentPage
    {
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        public ColorLists()
        {
            InitializeComponent();

            //listView.ItemsSource = new List<Color> { Color.Aqua, Color.Black, Color.Blue,
            //    Color.Fuchsia, Color.Gray, Color.Green, Color.Lime, Color.Maroon,
            //    Color.Navy, Color.Olive, Color.Pink, Color.Purple, Color.Red, Color.Silver,
            //    Color.Teal, Color.White, Color.Yellow };

            listView.ItemsSource = employees;
            employees.Add(new Employee { DisplayName = "Rob Finnerty" });
            employees.Add(new Employee { DisplayName = "Bill Wrestler" });
            employees.Add(new Employee { DisplayName = "Dr. Geri-Beth Hooper" });
            employees.Add(new Employee { DisplayName = "Dr. Keith Joyce-Purdy" });
            employees.Add(new Employee { DisplayName = "Sheri Spruce" });
            employees.Add(new Employee { DisplayName = "Burt Indybrick" });
        }
    }
}
