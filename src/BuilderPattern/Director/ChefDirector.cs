using BuilderPattern.Builder;

namespace BuilderPattern.Director
{
    public class ChefDirector : IDirector
    {
        private IFoodDishes _foodDishes;

        public ChefDirector(IFoodDishes foodDishes)
        {
            _foodDishes = foodDishes;
        }

        public double PrepareBandejaPaisa()
        {
            _foodDishes.Reset();

            _foodDishes.AddIngredients("2 litros de agua");
            _foodDishes.AddIngredients("1 1/2 cucharadas de aceite (21 g)");
            _foodDishes.AddIngredients("2 tallos de cebolla larga finamente picada (30 g)");
            _foodDishes.AddIngredients("2 tomates maduros sin piel y finamente picados (240 g)");
            _foodDishes.AddIngredients("1 sobre de CALDO CON COSTILLA MAGGI® DESMENUZADO (9 g)");
            _foodDishes.AddIngredients("1/2 libra de fríjoles bola roja remojados desde la noche anterior (250 g)");
            _foodDishes.AddIngredients("1/4 libra de carne molida magra (125 g)");
            _foodDishes.AddIngredients("1/2 libra de arroz blanco cocinado (250 g)");
            _foodDishes.AddIngredients("1/4 de libra de tocino crocante cortado en 4 porciones (125 g)");
            _foodDishes.AddIngredients("4 chorizos tipo coctel previamente cocinados y dorados (120 g)");
            _foodDishes.AddIngredients("4 huevos fritos (200 g)");
            _foodDishes.AddIngredients("1 aguacate partido en 4 porciones (110 g)");
            _foodDishes.AddIngredients("4 arepas pequeñas redondas (80 g)");
            _foodDishes.AddIngredients("4 tajadas de plátano maduro fritas (80 g)");

            _foodDishes.SetName("Bandeja Paisa");
            _foodDishes.SetInformation("Bandeja Paisa ranchera");
            _foodDishes.SetCulture("Medellín - Colombia");
            _foodDishes.Mix();
            _foodDishes.Rest(5000);

            return _foodDishes.GetPrice(25000);
        }

        public double PrepareAjiaco()
        {
            _foodDishes.Reset();

            _foodDishes.AddIngredients("4 tazas de agua (1000 ml)");
            _foodDishes.AddIngredients("1 sobre CALDO DE GALLINA MAGGI® DESMENUZADO (9 g)");
            _foodDishes.AddIngredients("1 pechuga de pollo pequeña sin piel pero con el hueso (400 g)");
            _foodDishes.AddIngredients("1/4 de libra de papa criolla pelada y cortada en rodajas (125 g)");
            _foodDishes.AddIngredients("1/4 de libra de papa pastusa pelada y cortada en rodajas (125 g)");
            _foodDishes.AddIngredients("3 mazorcas partidas a la mitad (380 g)");
            _foodDishes.AddIngredients("1/2 atado de guascas (13 g)");
            _foodDishes.AddIngredients("4 cucharadas de CREMA DE LECHE NESTLÉ® (60 g)");
            _foodDishes.AddIngredients("1 cucharada de alcaparras (20 g)");
            _foodDishes.AddIngredients("1 aguacate mediano partido en 4 porciones (300 g)");

            _foodDishes.SetName("Ajiaco");
            _foodDishes.Mix();
            _foodDishes.Rest(5000);
            return _foodDishes.GetPrice(18000);
        }


        public void SetTypicalDish(IFoodDishes foodDishes) => _foodDishes = foodDishes;

    }
}
