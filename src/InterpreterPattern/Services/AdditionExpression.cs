using InterpreterPattern.Interfaces;

namespace InterpreterPattern.Services
{
    public class AdditionExpression : IExpresion
    {
        private IExpresion _firstExpression, _secondExpression;

        public AdditionExpression(IExpresion firstExpression, IExpresion secondExpression)
        {
            _firstExpression = firstExpression;
            _secondExpression = secondExpression;
        }

        public int Interpret()
        {
            return _firstExpression.Interpret() + _secondExpression.Interpret();
        }

        public override string ToString() => "+";

    }
}
