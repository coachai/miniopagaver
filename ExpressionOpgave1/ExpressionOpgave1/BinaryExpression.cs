using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionOpgave1
{
    abstract class BinaryExpression:Expression
    {
        protected readonly Expression left;
        protected readonly Expression right;

        protected abstract string OperatorSymbol { get; }

        protected BinaryExpression(Expression left, Expression right)
        { this.left = left;
          this.right = right;
        
        }

      //  public  string ToString { get; }
        public sealed override string ToString()
        {
            return string.Format("{0} {1} {2}", "("+left.ToString() + "", OperatorSymbol + "", right.ToString()+")" )   ;

        }
    }

    //public abstract class plusExpression():BinaryExpression
    //{  public sealed override string OperatorSymbol
    //    { get { return } }
    //}
}
