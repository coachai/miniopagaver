using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionOpgave1
{
    abstract class BinaryExpression:Expression
    {
        protected Expression left;
        protected Expression right;

        protected abstract string OperatorSymbol { get; }



      //  public  string ToString { get; }
        public sealed override string ToString()
        {
            return string.Format("{0} {1} {2}",left, OperatorSymbol, right )   ;

        }
    }

    //public abstract class plusExpression():BinaryExpression
    //{  public sealed override string OperatorSymbol
    //    { get { return } }
    //}
}
