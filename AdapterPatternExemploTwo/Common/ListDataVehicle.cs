using AdapterPatternExemploTwo.Models;

namespace AdapterPatternExemploTwo.Common;

public static class ListDataVehicle
{
    public static List<Vehicles> GetVehicles()
    {
        return new List<Vehicles>(){
        new Vehicles {
            CityOfCirculation = "Medellín",
            Brand="Renault",
            Model= 2019
        },
        new Vehicles {
            CityOfCirculation = "Medellín",
            Brand="Zhidou",
            Model= 2019
        }
    };
    }
}
