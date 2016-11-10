using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Pet
    {
        public string name;
        public Specie species;
        public string petArt;

        public Pet(string name, Specie species)
            { this.name = name;
              this.species = species;
          
            }
    }
}
