using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DVector
{
    class _3DClass1
    {
            public float x, y, z;
            public float X { get { return x; } }
             public float Y { get { return y; } }
             public float Z { get { return z; } }

        public _3DClass1(float x, float y, float z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }

            public float Sqresult()
            { return (float)Math.Sqrt(x * x + y * y + z * z); }

        public _3DClass1 addVector(_3DClass1 otherVector)
        {
            var resultingVector = new _3DClass1(this.X+otherVector.X ,this.Y+otherVector.Y , this.Z+otherVector.Z);
            return resultingVector;
        }
    }
}
