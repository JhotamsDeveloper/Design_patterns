using System.Collections;
using WithIEnumerator.Model;

namespace WithIEnumerator.Servicios
{
    public class DinnerMenuCollection : IEnumerator<Menu>
    {
        private Menu[] _menuItems;
        private int _maxItems = 4;
        private int _numberOfItems;
        private int _position = 0;

        public DinnerMenuCollection()
        {
            _position = -1;
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
            Menu menuItem = new(name, description, price, isVegatarian);

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

        public Menu Current { get { return _menuItems[_position]; } }

        object IEnumerator.Current => new DinnerMenuCollection(_menuItems);

        public bool MoveNext()
        {
            ++_position;

            if (_menuItems[_position] == null)
            {
                return false;
            }
            else if (_position < _menuItems.Length)
            {
                return true;
            }

            return false;
        }

        public Menu Next()
        {
            Menu menu = _menuItems[_position];
            ++_position;

            return menu;
        }

        public void Reset()
        {
            _position = -1;
        }
        public void Dispose() => throw new NotImplementedException();
    }
}
