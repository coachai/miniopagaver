using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    public class Specie
	{
        public string name;
        public int numberOfEyes;
        public int numberOfLegs;
     
     public Specie(string name, int numberOfEyes, int numberOfLegs)
    {   this.name = name;
        this.numberOfLegs = numberOfLegs;
        this.numberOfEyes = numberOfEyes;
    }
	}
}
