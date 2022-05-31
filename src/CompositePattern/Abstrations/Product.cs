using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Abstrations
{
    public abstract class Product
    {
        protected Product(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; private set; }
        public int Price { get; private set; }

        public abstract void Add(Product product);
        public abstract void Remove(Product product);
        public abstract string GetPrice();

    }
}
