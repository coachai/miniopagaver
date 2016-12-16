using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListGenerics
{
    public class Person
    {
        private string name;
        private int eyeNumber;

        public Person(string name, int eyeNumber)
        { this.name = name;
            this.eyeNumber = eyeNumber;
        }

        public string getName { get { return name; } }
        public int getEyeNumber { get { return eyeNumber; } }

        //public override string ToString()
        //{ return name => name.ToString(); }

        //public string ToString(Filter<Person> onePerson)
        //{

        //}

     


    }
}
