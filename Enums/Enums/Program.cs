using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        public string WhichAnimal()
        {
            var oneAnimal = new MyAnimal(AnimalTypeEnum.Bird);
            switch (oneAnimal.getAnimalKind)
            {
                case AnimalTypeEnum.Bird:
                    return "VOvOVOV";
                case AnimalTypeEnum.Fish:
                    return "munum";
                default: return "Not at all";
            }
        }

        static void Main(string[] args)
        {
            
                

            Console.ReadKey();
        }
    }

    public enum AnimalTypeEnum  { Bird, Fish}

    public class MyAnimal
    { 
        private AnimalTypeEnum kind;
        public AnimalTypeEnum getAnimalKind { get; } // get method for animal kind

        public MyAnimal(AnimalTypeEnum kind)
        {
            this.kind = kind;
        }

     

    }
}
