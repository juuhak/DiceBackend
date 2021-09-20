namespace DiceBackend
{
    public class DiceExpression : Expression
    {
        private int _constant;
        private int _rank;

        public DiceExpression(int constant, int rank) : base(ExpressionType.DiceExpression)
        {
            _constant = constant;
            _rank = rank;
        }

        public int GetConstant => _constant;
        public int GetRank => _rank;
    }
}
