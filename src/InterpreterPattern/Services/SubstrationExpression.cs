using InterpreterPattern.Interfaces;

namespace InterpreterPattern.Services
{
    public class SubstrationExpression : IExpresion
    {
        private IExpresion _firstExpression, _secondExpression;

        public SubstrationExpression(IExpresion firstExpression, IExpresion secondExpression)
        {
            _firstExpression = firstExpression;
            _secondExpression = secondExpression;
        }

        public int Interpret()
        {
            return _firstExpression.Interpret() - _secondExpression.Interpret();
        }

        public override string ToString() => "-";
    }
}
