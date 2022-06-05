using Problem.Model;

namespace Problem.Services
{
    public class BreakfastMenuCollection
    {
        private List<Menu> _menuItems;

        public BreakfastMenuCollection()
        {
            _menuItems = new List<Menu>();
            AddItem("Desayuno simple dulce", "Panqueques con manjar + cafe o te", 200, false);
            AddItem("Desayuno Sandwich", "Sandwich Jamon queso + cafe o te", 120, false);
            AddItem("Desayuno vegetariano", "Sandwich Lechuga y atun + jugo", 200, true);

        }

        public void AddItem(string name, string description, double price, bool isVegatarian)
        {
            Menu menuItem = new(name, description, price, isVegatarian);
            _menuItems.Add(menuItem);
        }

        public List<Menu> GetMenuItems() => _menuItems;
    }
}
