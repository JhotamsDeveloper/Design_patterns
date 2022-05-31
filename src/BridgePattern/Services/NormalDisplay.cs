using BridgePattern.Interfaces;

namespace BridgePattern.Services
{
    public class NormalDisplay : IDisplayFormatter
    {
        public void Display(string text)
        {
            Console.WriteLine(text);
        }
    }
}
