using DesignPatternBridge.Interfaces;

namespace DesignPatternBridge.Services;

public class Email : INotification
{
    //Logic
    public string Type => "email";
}
