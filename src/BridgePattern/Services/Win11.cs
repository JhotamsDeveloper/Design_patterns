using BridgePattern.Interfaces;

namespace BridgePattern.Services
{
    public class Win11 : ReaderApp
    {
        public Win11(IDisplayFormatter displayFormatter) : base(displayFormatter)
        {
        }

        public override void Display()
        {
            _displayFormatter.Display($"Aplicación utilizada en sistemas Win11. {Environment.NewLine}{Text}");
        }
    }
}
