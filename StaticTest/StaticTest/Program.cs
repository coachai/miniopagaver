using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Diagnostics;

namespace StaticTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int aa = 1234;
            List<string> dinosaurs = new List<string>();
            List<int> listInt = new List<int>();
            listInt.Add(9);
            listInt.Add(4);
            listInt.Add(5);

            dinosaurs.Add("Pachycephalosaurus");
            dinosaurs.Add("Parasauralophus");
            dinosaurs.Add("Mamenchisaurus");
            dinosaurs.Add("Amargasaurus");
            dinosaurs.Add("Coelophysis");
            dinosaurs.Add("Oviraptor");
            Reverse<string>(dinosaurs);
           // dinosaurs.Reverse();
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }
            foreach (int oneInt in listInt)
            {
                Console.WriteLine(oneInt);
            }

            Console.WriteLine( aa.Times1000());
            Console.ReadKey();
        }

        private static void Reverse<T>(List<T> data)
        {
            var newList = new List<T>();
            foreach (T oneData in data)
            {
                Console.WriteLine(oneData);
                
                newList.Add(oneData);
                
                Console.WriteLine("--");
            }

            data.Reverse();



        }
    }

    static class MyExtensions
    {
        public static int Times1000(this Int32 almindelig)
        { return almindelig * 1000; }


        static void Reverse<T>(List<T> data)
        { foreach (T oneData in data)
            { Console.WriteLine(oneData); }
            data.Reverse();
            foreach (T oneData in data)
            { Console.WriteLine(oneData); }

            data.Reverse(1, 4);

        }

    
       


    }

}
