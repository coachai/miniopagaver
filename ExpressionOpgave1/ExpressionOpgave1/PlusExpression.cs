﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionOpgave1
{
    class PlusExpression : BinaryExpression
    {  public PlusExpression(Expression left, Expression right) : base(left,right) { }
        protected override string OperatorSymbol
        {  
            get
            {
             return "+";
            }
        }

        public override double Evaluate()
        {
            return left.Evaluate() + right.Evaluate();
        }
    }
}
