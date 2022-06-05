using InterpreterPattern.Interfaces;

namespace InterpreterPattern.Services
{
    public class ExpressionParser
    {
        Stack<IExpresion> _stack = new Stack<IExpresion>();

        private static bool IsOperator(string input) =>
            (input.Equals("+") || input.Equals("*") || input.Equals(""));

        private static IExpresion GetExpressionObject(IExpresion firstExpression, IExpresion secondExpression, string symbol)
        {
            if (symbol.Equals("+"))
            {
                return new AdditionExpression(firstExpression, secondExpression);
            }
            else if (symbol.Equals("*"))
            {
                return new MultiplicationExpression(firstExpression, secondExpression);
            }
            else
            {
                return new SubstrationExpression(firstExpression, secondExpression);
            }
        }

        public int Parse(string input)
        {
            string[] tokenList = input.Split(' ');
            foreach (var symbol in tokenList)
            {
                if (!IsOperator(symbol))
                {
                    IExpresion numberExpression = new NumericExpression(symbol);
                    _stack.Push(numberExpression);
                    Console.WriteLine($"Agregando al stack: {numberExpression.Interpret()}");
                }
                else if(IsOperator(symbol))
                {
                    IExpresion firstExpression = _stack.Pop();
                    IExpresion secondExpression = _stack.Pop();
                    Console.WriteLine($"Operadores para: {firstExpression.Interpret()},{secondExpression.Interpret()}");

                    IExpresion expressionObject = GetExpressionObject(firstExpression, secondExpression, symbol);
                    Console.WriteLine($"Aplicando operador: {expressionObject}");

                    NumericExpression resultExpression = new NumericExpression(expressionObject.Interpret());
                    _stack.Push(resultExpression);

                    Console.WriteLine($"Agregando resultado al stack {resultExpression.Interpret()}");
                }
            }
            return _stack.Pop().Interpret();
        }
    }
}
