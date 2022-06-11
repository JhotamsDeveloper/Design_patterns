using StrategyPattern.Interfaces;
using StrategyPattern.Services;

var tp = new TextProcessor(OutputFormat.NumberList);
tp.AppendList(new[] { "c#", "Java", "Phyton" });
Console.WriteLine(tp);
tp.Clear();

tp = new TextProcessor(OutputFormat.Html);
tp.AppendList(new[] { "c#", "Java", "Phyton" });
Console.WriteLine(tp);
tp.Clear();
