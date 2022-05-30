namespace BuilderPattern.Builder
{
    public interface IDirector
    {
        double PrepareBandejaPaisa();
        double PrepareAjiaco();
        void SetTypicalDish(IFoodDishes foodDishes);
    }
}
