using DesignPatternBridge.Abstracts;
using DesignPatternBridge.Interfaces;

namespace DesignPatternBridge.Models;

public class Developer : Employee
{
    public Developer(INotification contactType) : base(contactType)
    {
        Name = "Developer";
    }
}
