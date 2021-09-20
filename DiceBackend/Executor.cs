using System;

namespace DiceBackend
{
    public class Executor : IExecutor
    {
        public int Execute(Expression? exp)
        {
            if (exp == null) return 0;

            var retVal = 0;

            switch (exp.ExpressionType)
            {
                case ExpressionType.Operator:
                    var oe  = exp as OperatorExpression;
                    if (oe == null) throw new InvalidOperationException();

                    var l = Execute(oe.Left);
                    var r = Execute(oe.Right);

                    switch (oe.GetOperator)
                    {
                        case Operator.Addition:
                            retVal = l + r;
                            break;
                        case Operator.Multiplication:
                            retVal = l * r;
                            break;
                        case Operator.Substraction:
                            retVal = l - r;
                            break;
                        default:
                            throw new ArgumentException();                            
                    }
                    break;

                case ExpressionType.Constant:
                    var ce = exp as ConstantExpression;
                    if (ce == null) throw new InvalidOperationException();

                    retVal = ce.GetValue;
                    break;

                case ExpressionType.DiceExpression:
                    throw new NotImplementedException();                    
            }

            return retVal;
        }
    }
}
