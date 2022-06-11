using StrategyPattern.Interfaces;
using System.Text;

namespace StrategyPattern.Services
{
    public class TextProcessor
    {
        private readonly StringBuilder sb = new();
        private readonly IListFormatStrategy _listStrategy;


        public TextProcessor(OutputFormat format)
        {
            _listStrategy = (IListFormatStrategy)
                Activator.CreateInstance(Type.GetType($"StrategyPattern.Services.{Enum.GetName(typeof(OutputFormat), format)}"));
        }
        public void AppendList(IEnumerable<string> items)
        {
            _listStrategy.Start(sb);
            foreach (var item in items)
                _listStrategy.AddItem(sb, item);
            _listStrategy.End(sb);
        }

        public StringBuilder Clear() => sb.Clear();
        public override string ToString()
        {
            return sb.ToString();
        }

    }
}
