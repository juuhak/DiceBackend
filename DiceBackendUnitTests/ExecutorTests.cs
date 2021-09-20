using NUnit.Framework;
using DiceBackend;

namespace DiceBackendUnitTests
{
    public class ExecutorTests
    {
        private IExecutor _executor;

        [SetUp]
        public void Setup()
        {
            _executor = new Executor();
        }

        [Category("SingleRankTests")]
        [Test]
        public void ConstantAdditionPositiveValuesSingleRank()
        {
            var exp = Expression.OperatorExpression(Operator.Addition, 
                Expression.ConstantExpression(5), 
                Expression.ConstantExpression(3));

            var f = _executor.Execute(exp);

            Assert.That(f, Is.EqualTo(8));            
        }

        [Category("SingleRankTests")]
        [Test]
        public void ConstantMultiplicationPositiveValuesSingleRank()
        {
            var exp = Expression.OperatorExpression(Operator.Multiplication, 
                Expression.ConstantExpression(5), 
                Expression.ConstantExpression(3));

            var f = _executor.Execute(exp);

            Assert.That(f, Is.EqualTo(15));
        }

        [Category("SingleRankTests")]
        [Test]
        public void ConstantSubtractionPositiveValuesSingleRank()
        {
            var exp = Expression.OperatorExpression(Operator.Substraction, 
                Expression.ConstantExpression(5), 
                Expression.ConstantExpression(3));

            var f = _executor.Execute(exp);

            Assert.That(f, Is.EqualTo(2));
        }

        [Category("MultiRankTests")]
        [Test]
        public void ConstantAdditionPositiveValuesMultiRank()
        {
            var exp = Expression.OperatorExpression(Operator.Addition, 
                Expression.OperatorExpression(Operator.Addition, 
                    Expression.ConstantExpression(4), 
                    Expression.ConstantExpression(1)), 
                Expression.ConstantExpression(3));

            var f = _executor.Execute(exp);

            Assert.That(f, Is.EqualTo(8));
        }

        [Category("MultiRankTests")]
        [Test]
        public void ConstantMultiOperatorPositiveValuesMultiRank()
        {
            var exp = Expression.OperatorExpression(Operator.Addition,
                Expression.OperatorExpression(Operator.Addition,
                    Expression.ConstantExpression(4),
                    Expression.OperatorExpression(Operator.Multiplication,
                        Expression.ConstantExpression(6),
                        Expression.ConstantExpression(2))),
                Expression.ConstantExpression(3));

            var f = _executor.Execute(exp);

            Assert.That(f, Is.EqualTo(19));
        }
    }
}