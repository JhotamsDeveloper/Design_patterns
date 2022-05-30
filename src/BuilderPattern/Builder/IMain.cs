namespace BuilderPattern.Builder
{
    public interface IMain
    {
        public void Reset();
        public void AddIngredients(string ingredient);
        public void Mix();
        public void Rest(int time);
    }
}
