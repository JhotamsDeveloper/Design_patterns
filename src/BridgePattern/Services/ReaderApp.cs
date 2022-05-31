using BridgePattern.Interfaces;

namespace BridgePattern.Services
{
    public abstract class ReaderApp
    {
        public string Text { get; set; }
        protected IDisplayFormatter _displayFormatter;
        public ReaderApp(IDisplayFormatter displayFormatter) => _displayFormatter = displayFormatter;
        public abstract void Display();
    }
}
