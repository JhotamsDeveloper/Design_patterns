using DesignPatternBridge.Interfaces;

namespace DesignPatternBridge.Abstracts;

public abstract class Employee
{
    public string? Name { get; set; }
    private readonly INotification _contactType;

    public Employee(INotification contactType)
    {
        _contactType = contactType;
    }
    public string Notification()
    {
        return $"{Name} ha sido contactado por {_contactType.Type}";
    }
}
