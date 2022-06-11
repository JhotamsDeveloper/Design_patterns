namespace TempletePattern.Abstraction
{
    public abstract class Bread
    {
        public abstract void MixIngredients();

        public abstract void Bake();

        public virtual void Slice()
        {
            Console.WriteLine($"Cortando el pan {GetType().Name}");
        }

        public void Make()
        {
            MixIngredients();
            Bake();
            Slice();
        }

    }
}