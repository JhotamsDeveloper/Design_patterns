using DesignPatternBridge.Abstracts;
using DesignPatternBridge.Interfaces;

namespace DesignPatternBridge.Models;

public class ScrumMaster : Employee
{
    public ScrumMaster(INotification contactType) : base(contactType)
    {
        Name = "ScrumMaster";
    }
}
