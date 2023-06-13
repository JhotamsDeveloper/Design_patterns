using DesignPatternBridge.Models;
using DesignPatternBridge.Services;

Developer develop = new(new Email());
Console.WriteLine(develop.Notification());
