using System.Text;

namespace StrategyPattern.Interfaces
{
    public interface IListFormatStrategy
    {
        void Start(StringBuilder sb);
        void AddItem(StringBuilder sb, string item);
        void End(StringBuilder sb);
    }
}
