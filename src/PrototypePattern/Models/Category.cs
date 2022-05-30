namespace PrototypePattern.Models
{
    [Serializable]
    public class Category
    {
        public string Name { get; set; }
        public Category(string name)
        {
            Name = name;
        }

    }
}
