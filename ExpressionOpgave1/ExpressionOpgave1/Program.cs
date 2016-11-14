using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionOpgave1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Expression expr = new MultiplyExpression(
            //    left: new ConstantExpression(4),
            //    right: new PlusExpression(left: new ConstantExpression(1),
            //    right: new ConstantExpression(2)));

            //Console.Write(expr.ToString());
            //Console.Write("=");

            //// result
            //Console.WriteLine(expr.Evaluate());

            //int x = 32;
            //List<int> evenNumber = new List<int>();
            //ArrayList old = new ArrayList();
            //Dictionary<int, bool> isEvenNumberDict = new Dictionary<int, bool>();
            //for (int i = 0; i <= x; i++)
            //{ if (i % 2 == 0)
            //    {
            //        evenNumber.Add(i);
            //        old.Add(i);
            //        isEvenNumberDict.Add(i, true);
            //    }
            //    else {
                   
            //        isEvenNumberDict.Add(i,false);
            //    }
            // }

            //foreach (var number in evenNumber)
            //{ Console.Write(number + " "); }

            //foreach (var entry in isEvenNumberDict)
            //{
            //    Console.WriteLine(entry.Key + "=" + entry.Value);
            //}

            //Console.WriteLine("First item on list:" + evenNumber[0]);
            //Console.WriteLine("IS 3 an even number ? "+ isEvenNumberDict[3]);
            Mynumber xx = new Mynumber();
            xx.value = 3;
            AddTo(xx,1);
            Console.WriteLine("AddTo MyNumber(3), 1=" + xx);
            Console.ReadKey();
        }
        static void AddTo(Mynumber xx, int y)
        { xx.value += y; }
    }

    public class Mynumber
    { public int value;
        public override string ToString()
        {
            return value.ToString();
        }
    }
}
