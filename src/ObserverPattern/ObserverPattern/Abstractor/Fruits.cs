using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Abstractor
{
    public abstract class Fruits
    {
        private double _pricePerKg;
        private List<IRestaurant> _restaurants = new List<IRestaurant>();

        protected Fruits(double pricePerKg)
        {
            _pricePerKg = pricePerKg;
        }

        public void Attach(IRestaurant restaurant)
        {
            _restaurants.Add(restaurant);
        }

        public void Detach(IRestaurant restaurant)
        {
            _restaurants.Remove(restaurant);
        }

        public void Notify()
        {
            foreach (IRestaurant restaurant in _restaurants)
            {
                restaurant.Update(this);
                Console.WriteLine("");
            }
        }

        public double PricePerKg
        {
            get { return _pricePerKg; }
            set
            {
                if (_pricePerKg != value)
                {
                    _pricePerKg = value;
                    Notify();
                }
            }
        }

    }
}
