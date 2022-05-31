using BridgePattern.Interfaces;

namespace BridgePattern.Services
{
    public class IOS : ReaderApp
    {
        public IOS(IDisplayFormatter displayFormatter) : base(displayFormatter)
        {
        }

        public override void Display()
        {
            _displayFormatter.Display($"Aplicación utilizada en sistemas IOS. {Environment.NewLine}{Text}");
        }
    }
}
