public class PepperoniPizza : Pizza
{
    private PizzaIngredientFactory ingredientFactory;

    public PepperoniPizza(PizzaIngredientFactory ingredientFactory)
    {
        this.ingredientFactory = ingredientFactory;
    }

    protected override void Prepare()
    {
        Console.WriteLine("Preparing " + Name);
        Dough = ingredientFactory.CreateDough();
        Sauce = ingredientFactory.CreateSauce();
        Cheese = ingredientFactory.CreateCheese();
        Veggies = ingredientFactory.CreateVeggies();
        Pepperoni = ingredientFactory.CreatePepperoni();
    }
}
