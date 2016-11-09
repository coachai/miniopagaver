using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DVector
{
    class Program
    {
        static void Main(string[] args)
        {
            _3DClass1 v1 = new _3DClass1(4, 2, 3);
            _3DClass1 v2 = new _3DClass1(5, 6, 7);
            _3DClass1 v3 =v1.addVector(v2) ;
            Debug.WriteLine("Square result is +" + v1.Sqresult());
            Debug.WriteLine("Vector plus result is +" + v3);
        }
    }
}
