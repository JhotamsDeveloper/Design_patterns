using Soluction.Interfaces;
using Soluction.Model;

namespace Soluction.Servicios
{
    public class DinnerMenuCollection : IIterator<Menu>
    {
        private Menu[] _menuItems;
        private int _maxItems = 4;
        private int _numberOfItems;
        int position = 0;

        public DinnerMenuCollection()
        {
            _menuItems = new Menu[_maxItems];

            AddItem("Vegatiariano simple", "Hipocalorico + Jugo", 500, true);
            AddItem("Caribean Sushi", "10 hot rolls, 15 kanikama", 800, false);
            AddItem("Pizza familiar", "Pizza 3 ingredientes a elección", 800, false);
        }

        public DinnerMenuCollection(Menu[] items)
        {
            _menuItems = items;
        }

        public void AddItem(string name, string description, double price, bool isVegatarian)
        {
            Menu menuItem = new Menu(name, description, price, isVegatarian);

            if (_numberOfItems > _maxItems)
            {
                Console.WriteLine("El menu está full");
            }
            else
            {
                _menuItems[_numberOfItems] = menuItem;
                _numberOfItems++;
            }
        }

        public IIterator<Menu> CreateIterator() => new DinnerMenuCollection(_menuItems);

        public bool HasNext()
        {
            if (position >= _menuItems.Length || _menuItems[position] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public Menu Next()
        {
            Menu menu = _menuItems[position];
            position = position + 1;
            return menu;
        }
    }
}
