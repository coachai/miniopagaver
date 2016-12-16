using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListGenerics
{
    public delegate bool Filter(Person p);

    public static class PersonExtensions
    {
        public static List<Person> FilterOut(this List<Person> personList, Filter filter)
        {
            var nagativeList = new List<Person>();
            foreach (Person person in personList)
            {
                if (filter.Invoke(person))
                {
                    nagativeList.Add(person);

                }


            }
            return nagativeList;
        }






      //  LinkedList<Person> a = new LinkedList<Person>();
    }
}
