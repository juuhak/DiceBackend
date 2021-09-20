namespace DiceBackend
{
    public class ConstantExpression : Expression
    {
        private readonly int _constantValue;

        public ConstantExpression(int constantValue) : base(ExpressionType.Constant)
        {
            _constantValue = constantValue;
        }

        public int GetValue => _constantValue;
    }
}
