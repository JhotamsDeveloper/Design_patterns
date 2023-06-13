using DesignPatternBridge.Interfaces;

namespace DesignPatternBridge.Services;

public class PhoneCall : INotification
{
    //Logic
    public string Type => "telefono";
}
