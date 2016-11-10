using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            Specie elefantSpecie = new Specie("Elefant", 4, 2);
            Pet karlsPet = new Pet("Rufus", elefantSpecie);
            Person karl = new Person("hua CHai", 1920, karlsPet);

            //Debug.WriteLine(karl.name);
            //Debug.WriteLine(karl.pet.name);

            Debug.WriteLine("Person Name is:" + karl.Name);
            Debug.WriteLine("NUmber of eyes are:" + karl.Pet.species.numberOfEyes);
            Debug.WriteLine("Persons Birthday is:" + karl.BirthYear);
            Debug.WriteLine("Pet is:" + karl.Pet.name);

            karl.NameChanged += Karl_NameChanged;
            karl.Name = "Mit nye navn";
            karl.Name = "Mit xamarin";
        }

                private static void Karl_NameChanged(object sender, string e)
                  { Debug.WriteLine("nye navn:"+e);
                }
        }
    }

