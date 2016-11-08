using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug.WriteLine("--------------------------------");

            Opgave11();
            Opgave14();


            Debug.WriteLine("--------------------------------");

        }

        public static void Opgave11()
        {
            Debug.WriteLine("Hue1");
        }

        public static void Opgave13()
        {
            long result = 26 / 5;
            Debug.WriteLine(result);
        }
        public static void Opgave14()
        {
            long result = -1+3 *5;
            Debug.WriteLine(result);
            float resulta = (float)15/(float)4;
            Debug.WriteLine(resulta);
            double resultb = 15+(float)-4*6/11;
            Debug.WriteLine(resultb);
            float resultc = 2 + 10/6 * 1 -7%2;
            Debug.WriteLine(resultc);
        }
        public static void Opgave15()
        {
            int a;
            int b;

            a = System.Convert.ToInt32(System.Console.ReadLine());
            b = System.Convert.ToInt32(System.Console.ReadLine());
            int c= a* b;
            Debug.WriteLine(c);
        }

        public static void Opgave16()
        {
            int d;
            int e;
            int f;
            int g;
            Debug.WriteLine("ENTER THE FIRST NUMBER TO MULTIPLY");
            d = System.Convert.ToInt32(System.Console.ReadLine());
            Debug.WriteLine("ENTER THE SECOND NUMBER TO MULTIPLY");
            e = System.Convert.ToInt32(System.Console.ReadLine());
            Debug.WriteLine("ENTER THE THIRD NUMBER TO MULTIPLY");
            f = System.Convert.ToInt32(System.Console.ReadLine());
            g = e * f * d;
            Debug.WriteLine("multiplication result");
            Debug.WriteLine(g);
        }

    }
}
