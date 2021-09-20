namespace DiceBackend
{
    public abstract class Expression
    {
        public ExpressionType ExpressionType { get; }

        public Expression(ExpressionType type)
        {
            ExpressionType = type;
        }

        public static ConstantExpression ConstantExpression(int value)
        {
            return new ConstantExpression(value);
        }

        public static OperatorExpression OperatorExpression(Operator op, Expression left, Expression right)
        {
            return new OperatorExpression(op, left, right);
        }

        public static DiceExpression DiceExpression(int multiplier, int rank)
        {
            return new DiceExpression(multiplier, rank);
        }
    }
}
