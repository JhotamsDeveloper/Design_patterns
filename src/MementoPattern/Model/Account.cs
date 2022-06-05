namespace MementoPattern.Model
{
    public class Account
    {
        public Account(int balance)
        {
            Balance = balance;
            _operations.Add(new Memento(balance));
        }

        public int Balance { get; set; }
        private List<Memento> _operations = new();
        private int _current;

        public Memento Deposit(int amount)
        {
            Balance += amount;
            var memento = new Memento(Balance);
            _operations.Add(memento);
            ++_current;
            return memento;
        }

        public Memento Undo()
        {
            if (_current > 0)
            {
                var memento = _operations[--_current];
                Balance = memento.Balance;
                return memento;
            }
            return null;
        }

        public Memento Redo()
        {
            if (_current + 1 < _operations.Count)
            {
                var memento = _operations[++_current];
                Balance = memento.Balance;
                return memento;
            }
            return null;
        }

        public void Restore(Memento memento)
        {
            Balance = memento.Balance;
        }

        public override string ToString()
        {
            return $"Balance: {Balance}";
        }

    }
}
