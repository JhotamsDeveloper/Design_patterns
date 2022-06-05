using System.Collections;
using WithIEnumerator.Model;

namespace WithIEnumerator.Servicios
{
    public class BreakfastMenuCollection : IEnumerator<Menu>
    {
        private int _position = 0;
        private List<Menu> _menuItems;
        Menu menuItem;

        public BreakfastMenuCollection(List<Menu> items) => _menuItems = items;

        public BreakfastMenuCollection()
        {
            _menuItems = new List<Menu>();
            _position = -1;
            AddItem("Desayuno simple dulce", "Panqueques con manjar + cafe o te", 200, false);
            AddItem("Desayuno Sandwich", "Sandwich Jamon queso + cafe o te", 120, false);
            AddItem("Desayuno vegetariano", "Sandwich Lechuga y atun + jugo", 200, true);
        }

        public void AddItem(string name, string description, double price, bool isVegatarian)
        {
            menuItem = new Menu(name, description, price, isVegatarian);
            _menuItems.Add(menuItem);
        }

        public Menu Current { get { return _menuItems[_position]; } }

        object IEnumerator.Current => new BreakfastMenuCollection(_menuItems);

        public bool MoveNext()
        {
            ++_position;

            if (_position < _menuItems.Count)
                return true;
            
            return false;
        }

        public void Reset()
        {
            _position = -1;
        }

        public void Dispose() => throw new NotImplementedException();
    }
}
