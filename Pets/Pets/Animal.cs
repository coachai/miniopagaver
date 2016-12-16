using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Animal: INotifyPropertyChanged
    {
        private int heads;
        private int feet;
        private int ageInYears;

        

        public Animal(int heads, int feet)
        {
            this.heads = heads;
            this.feet = feet;
            this.ageInYears = 0;

        }

        public Animal(int feet):this(heads:1,feet:feet)
        {
        }

        public static List<Animal> CreateFarm()
        {
            var animals = new List<Animal>();
            animals.Add(new Animal(4));

            return animals;
        }

        public int Feet
        { get { return feet; } }

        public int AgeInYears
        {
            get { return ageInYears; }
            set{
                    this.ageInYears = value;
                    OnPropertyChanged(nameof(AgeInYears));
                }


        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
            { handler.Invoke(this, new PropertyChangedEventArgs(propertyName)); }
        }

       
    
    }

    class Usage
    {  public void DoStuff()
        { List<Animal> farm = Animal.CreateFarm();
            Animal dyr = new Animal(2);

            int fødder = dyr.Feet;

        }
    }
}
