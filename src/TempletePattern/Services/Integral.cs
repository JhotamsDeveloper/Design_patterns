using TempletePattern.Abstraction;

namespace TempletePattern.Services
{
    public class Integral : Bread
    {
        public override void MixIngredients()
        {
            Console.WriteLine("Colocando ingredientes pan integral");
        }

        public override void Bake()
        {
            Console.WriteLine("Horneando pan integral (10 min)");
        }
    }
}
