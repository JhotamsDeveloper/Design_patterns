namespace CommandPattern.Interfaces
{
    public interface IProductCommand
    {
        void Execute();
        void Undo();
    }
}
