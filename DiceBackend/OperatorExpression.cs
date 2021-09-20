namespace DiceBackend
{
    public class OperatorExpression : Expression
    {
        private readonly Expression? _left;
        private readonly Expression? _right;

        private Operator _op;

        public OperatorExpression(Operator op, Expression? left, Expression? right) : base(ExpressionType.Operator)
        {
            _op = op;
            _left = left;
            _right = right;
        }

        public Operator GetOperator => _op;
        public Expression? Left => _left;
        public Expression? Right => _right;
    }
}
