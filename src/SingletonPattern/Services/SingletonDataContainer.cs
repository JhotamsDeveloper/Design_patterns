using SingletonPattern.Interfaces;

namespace SingletonPattern.Services
{
    public class SingletonDataContainer : ISingletonContainer
    {
        private Dictionary<string, int> _capitals = new();
        private SingletonDataContainer()
        {
            Console.WriteLine("Nueva instancia SingletonDataContainer");
            var elements = File.ReadAllLines(@"capitals.txt");
            for (int i = 0; i < elements.Length; i += 2)
            {
                _capitals.Add(elements[i], int.Parse(elements[i + 1]));
            }

        }
        private static readonly Lazy<SingletonDataContainer> instance = new(() => new SingletonDataContainer());
        public static SingletonDataContainer Instance => instance.Value;

        public int GetPopulation(string name)
        {
            return _capitals[name];
        }

    }
}
