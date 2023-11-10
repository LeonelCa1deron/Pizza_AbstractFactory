public class ChicagoPizzaIngredientFactory : PizzaIngredientFactory
{
    public Dough CreateDough()
    {
        return new ThickCrustDough();
    }

    public Sauce CreateSauce()
    {
        return new PlumTomatoSauce();
    }

    public Cheese CreateCheese()
    {
        return new MozzarellaCheese();
    }

    public Veggies[] CreateVeggies()
    {
        Veggies[] veggies = { new BlackOlives(), new Spinach(), new Eggplant() };
        return veggies;
    }

    public Pepperoni CreatePepperoni()
    {
        return new SlicedPepperoni();
    }

    public Clams CreateClam()
    {
        return new FrozenClams();
    }
}
