using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    public class Vector3D
    { public float x, y, z;
        public Vector3D(float x, float y, float z)
        { this.x = x;
            this.y = y;
            this.z = z;
        }

        public float Sqresult(float x,float y,float z)
        { return (float) Math.Sqrt(x * x + y * y + z * z); }

        public class Usage
        { public void Main()
            { Vector3D v1 = new Vector3D(1, 0, 1);

           System.Console.WriteLine("result is +" + v1.Sqresult(v1.x,v1.y,v1.z));
            }
        }

    }
}
