using InterpreterPattern.Interfaces;

namespace InterpreterPattern.Services
{
    internal class MultiplicationExpression : IExpresion
    {
        private IExpresion _firstExpression, _secondExpression;

        public MultiplicationExpression(IExpresion firstExpression, IExpresion secondExpression)
        {
            _firstExpression = firstExpression;
            _secondExpression = secondExpression;
        }

        public int Interpret()
        {
            return _firstExpression.Interpret() * _secondExpression.Interpret();
        }

        public override string ToString() => "*";
    }
}
