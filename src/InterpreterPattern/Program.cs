using InterpreterPattern.Services;

/*
 * Crear una APP que pueda
 * A través de la expresión identificar cuales son los signo matematicos y
 * realizar las operaciones corresponcientes
*/

string input = "2 1 5 + *";
ExpressionParser expressionParser = new ExpressionParser();
int result = expressionParser.Parse(input);
Console.WriteLine($"Resultado final {result}");
Console.WriteLine();