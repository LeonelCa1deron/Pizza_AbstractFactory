public class ChicagoPizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(string item)
    {
        Pizza pizza = null;
        PizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();

        if (item.Equals("cheese", StringComparison.OrdinalIgnoreCase))
        {
            pizza = new CheesePizza(ingredientFactory);
            pizza.Name = "Chicago Style Cheese Pizza";
        }
        else if (item.Equals("veggie", StringComparison.OrdinalIgnoreCase))
        {
            pizza = new VeggiePizza(ingredientFactory);
            pizza.Name = "Chicago Style Veggie Pizza";
        }
        else if (item.Equals("clam", StringComparison.OrdinalIgnoreCase))
        {
            pizza = new ClamPizza(ingredientFactory);
            pizza.Name = "Chicago Style Clam Pizza";
        }
        else if (item.Equals("pepperoni", StringComparison.OrdinalIgnoreCase))
        {
            pizza = new PepperoniPizza(ingredientFactory);
            pizza.Name = "Chicago Style Pepperoni Pizza";
        }

        return pizza;
    }
}
