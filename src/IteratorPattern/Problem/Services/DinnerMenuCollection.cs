using Problem.Model;

namespace Problem.Services
{
    public class DinnerMenuCollection
    {
        private Menu[] _menuItems;
        private int _maxItems = 4;
        private int _numberOfItems;

        public DinnerMenuCollection()
        {
            _menuItems = new Menu[_maxItems];

            AddItem("Vegatiariano simple", "Hipocalorico + Jugo", 500, true);
            AddItem("Caribean Sushi", "10 hot rolls, 15 kanikama", 800, false);
            AddItem("Pizza familiar", "Pizza 3 ingredientes a elección", 800, false);

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

        public Menu[] GetMenuItems() => _menuItems;
    }
}
