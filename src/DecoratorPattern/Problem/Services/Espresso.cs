namespace Problem.Services
{
    public class Espresso
    {
        bool _hasMilk;
        bool _hasChocolate;

        public Espresso(bool hasMilk, bool hasChocolate)
        {
            _hasMilk = hasMilk;
            _hasChocolate = hasChocolate;
        }

        public string GetDescription() 
        {
            string description = string.Empty;
            if (_hasMilk)
            {
                description += "más leche";
            }
            if (_hasChocolate)
            {
                description += "más chocolate";
            }

            return $"Espresso simple {description}";
        }

        public double GetCost() 
        {
            double cost = 2.99;
            if (_hasMilk)
            {
                cost += 0.20;
            }
            if (_hasChocolate)
            {
                cost += 0.30;
            }

            return cost;
        }
    }
}
