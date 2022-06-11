using StrategyPattern.Interfaces;
using System.Text;
using System.Text.RegularExpressions;

namespace StrategyPattern.Services
{
    public class NumberList : IListFormatStrategy
    {
        public void AddItem(StringBuilder sb, string item)
        {
            var itemNumber = Regex.Matches(sb.ToString(), Environment.NewLine).Count + 1;
            sb.AppendLine($"{itemNumber} {item}");
        }

        public void End(StringBuilder sb)
        {
        }

        public void Start(StringBuilder sb)
        {
        }
    }
}
