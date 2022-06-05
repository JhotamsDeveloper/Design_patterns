using InterpreterPattern.Interfaces;

namespace InterpreterPattern.Services
{
    public class NumericExpression : IExpresion
    {
        public int _number;

        public NumericExpression(int number)
        {
            _number = number;
        }

        public NumericExpression(string number)
        {
            _number = int.Parse(number);
        }

        public int Interpret()
        {
            return _number;
        }
    }
}
