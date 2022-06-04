using CommandPattern.Interfaces;

namespace CommandPattern.Services
{
    public class ModifyPrice
    {
        private IList<IProductCommand> _commandProducts;
        private IProductCommand _command;

        public ModifyPrice()
        {
            _commandProducts = new List<IProductCommand>();
        }

        public void SetCommand(IProductCommand command) => _command = command;

        public void Invoke()
        {
            _commandProducts.Add(_command);
            _command.Execute();
        }

        public void Undo()
        {
            foreach (var item in Enumerable.Reverse(_commandProducts))
            {
                item.Undo();
            }
        }
    }
}
