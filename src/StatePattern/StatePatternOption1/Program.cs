
using StatePatternOption1.Model;

/*
 * Crear una APP que tenga las funciones de un télefono tradiccional
*/

Dictionary<State,List<(Trigger, State)>> Rules = new()
{
    [State.Colgado] = new List<(Trigger, State)>
    {
        (Trigger.Descolgar, State.Descolgado)
    },
    [State.Descolgado] = new List<(Trigger, State)>
    {
        (Trigger.MarcarLlamada, State.Llamando)
    },
    [State.Llamando] = new List<(Trigger, State)>
    {
        (Trigger.Colgar, State.Colgado),
        (Trigger.Conectado, State.Conectado)
    },
    [State.Conectado] = new List<(Trigger, State)>
    {
        (Trigger.Colgar, State.Colgado),
        (Trigger.DejarEnEspera, State.EnEspera),
        (Trigger.DejarMensaje, State.Colgado)
    },
    [State.EnEspera] = new List<(Trigger, State)>
    {
        (Trigger.QuitarModoEspera, State.Conectado),
        (Trigger.DejarEnEspera, State.EnEspera),
        (Trigger.DejarMensaje, State.Colgado),
    },
};

State state = State.Colgado;

while (true)
{
    Console.WriteLine($"El télefono esta actualmente en {state}");
    Console.WriteLine("Seleccione una opción");

    for (int i = 0; i < Rules[state].Count; i++)
    {
        var (t, _) = Rules[state][i];
        Console.WriteLine($"{i}.{t}");
    }

    int input = int.Parse(Console.ReadLine());
    var (_, s) = Rules[state][input];
    state = s;
}