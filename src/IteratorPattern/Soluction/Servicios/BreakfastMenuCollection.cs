using Soluction.Interfaces;
using Soluction.Model;

namespace Soluction.Servicios
{
    public class BreakfastMenuCollection: IIterator<Menu>
    {
        private List<Menu> _menuItems;
        int position = 0;

        public BreakfastMenuCollection(List<Menu> items) => _menuItems = items;
        public BreakfastMenuCollection()
        {
            _menuItems = new List<Menu>();
            AddItem("Desayuno simple dulce", "Panqueques con manjar + cafe o te", 200, false);
            AddItem("Desayuno Sandwich", "Sandwich Jamon queso + cafe o te", 120, false);
            AddItem("Desayuno vegetariano", "Sandwich Lechuga y atun + jugo", 200, true);

        }

        public void AddItem(string name, string description, double price, bool isVegatarian)
        {
            Menu menuItem = new Menu(name, description, price, isVegatarian);
            _menuItems.Add(menuItem);
        }

        public IIterator<Menu> CreateIterator() => new BreakfastMenuCollection(_menuItems);

        public bool HasNext()
        {
            if (position >= _menuItems.Count || _menuItems[position] == null)
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
