using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Person:INotifyPropertyChanged
    {
        double adgagn;
        private string name;
        private int birthYear;
        private string petName;
        Pet pet;
        public string Name
        {
            get
            { return name; }
            set
            {
                if (this.name != value)
                {
                    this.name = value;
                    onNameChanged();
                    OnPropertyChanged("Name");
                }
            }
        }
        public event EventHandler<string>NameChanged;
        public void onNameChanged()
        {
            EventHandler<string> handler = NameChanged;
            if (handler != null)
            {
                handler(this, this.Name);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        { PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            { handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public Person (string name,int birthYear,Pet pet)
        { this.name = name;
            this.birthYear = birthYear;
            this.pet = pet;
        }
        public Person(string name)
        {
            this.name = name;
        }

        public Person(string name, Pet pet)
        {
            this.name = name;
            this.pet = pet;
        }

        public Person(string name, string petName, Specie specie)
        {
            this.name = name;
            var newPet = new Pet("ho",specie);
            this.pet = newPet;
            

        }

        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        public Pet Pet
        { get{ return pet; } }

        public int BirthYear
        { get { return birthYear; }
            set
            {
                this.birthYear = BirthYear;
            }
        }

        public Specie oneSpecie
        { get { return oneSpecie; } }

        public string GetName()
        { return this.Name; }

        public int GetAlder()
        {
            DateTime d = DateTime.Now;
            var alder = d.Year - this.BirthYear;
            return alder;
        }

        public int GetEyes()
        { return this.pet.species.numberOfEyes; }

        
        //public double getAdgang()
        //{ get { return adgagng ; }
        //  set { adgang = Value / 3; }
        //}
    }
}
