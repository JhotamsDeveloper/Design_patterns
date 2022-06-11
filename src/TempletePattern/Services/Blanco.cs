using TempletePattern.Abstraction;

namespace TempletePattern.Services
{
    public class Blanco : Bread
    {
        public override void Bake()
        {
            Console.WriteLine("Colocando ingredientes para el pan blanco");
        }

        public override void MixIngredients()
        {
            Console.WriteLine("horneando pan blanc (24 min)");
        }
    }
}
