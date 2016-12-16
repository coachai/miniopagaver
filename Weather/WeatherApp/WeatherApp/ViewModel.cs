using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    
   public class ViewModel : INotifyPropertyChanged
    {
        DataService DataService { get; } = new DataService();

      
        private Model model;
        public event PropertyChangedEventHandler PropertyChanged;

        public ViewModel(Model model)
        {
            this.model = model;

        }

        public Weather CurrentWeather
        {
            get { return CurrentWeather; }

            private set
            {
                CurrentWeather = value;
                OnPropertyChanged("CurrentWeather");
            }
        }


        public async Task UpdateAllWeather()
        { CurrentWeather = await Model.GetWeather(); }

        
        protected virtual void OnPropertyChanged([CallerMemberName] string properName = "")
        {
            var evn = PropertyChanged;
            if (evn != null)
            {
                evn(this, new PropertyChangedEventArgs(properName));
            }


        }
    }
}
