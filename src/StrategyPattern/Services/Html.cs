using StrategyPattern.Interfaces;
using System.Text;

namespace StrategyPattern.Services
{
    public class Html : IListFormatStrategy
    {
        public void Start(StringBuilder sb)
        {
            sb.AppendLine("<ul>");
        }

        public void AddItem(StringBuilder sb, string item)
        {
            sb.AppendLine($" <li>{item}</li>");
        }

        public void End(StringBuilder sb)
        {
            sb.AppendLine("</ul>");
        }
    }
}
