using MediatorPattern.Interfaces;
using MediatorPattern.Model;
using MediatorPattern.Services;

/*
 * Crear una APP en donde
 * un piloto de aeronave pueda pedir permiso a la torre de control para aterrizar
 * aterrizar la aeronave si la pista esta disponible
*/

IMediator mediator = new Mediator();
Flight flight1 = new Flight(mediator);
Runway runway = new Runway(mediator);
mediator.RegisterFlight(flight1);
mediator.RegisterRunway(runway);
flight1.Land();
runway.Land();
flight1.Land();
Console.ReadLine();
