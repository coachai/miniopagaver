using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionOpgave1
{
     class ConstantExpression:Expression
    {
        private readonly double value;
        public override double Evaluate()
        { return value; }

        public sealed override string ToString()
        {
            return this.value.ToString();

        }

        public ConstantExpression(double value)
        { this.value = value; }


    }
}
