namespace Problem.Services
{
    public class Filtered
    {
        bool _hasMilk;
        bool _hasChocolate;

        public Filtered(bool hasMilk, bool hasChocolate)
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

            return $"Filtrado simple {description}";
        }

        public double GetCost()
        {
            double cost = 5.99;
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
