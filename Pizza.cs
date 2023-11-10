public abstract class Pizza
{
    protected string Name;

    protected Dough Dough;
    protected Sauce Sauce;
    protected Veggies[] Veggies;
    protected Cheese Cheese;
    protected Pepperoni Pepperoni;
    protected Clams Clam;

    public abstract void Prepare();

    public void Bake()
    {
        Console.WriteLine("Bake for 25 minutes at 350");
    }

    public void Cut()
    {
        Console.WriteLine("Cutting the pizza into diagonal slices");
    }

    public void Box()
    {
        Console.WriteLine("Place pizza in official PizzaStore box");
    }

    public void SetName(string name)
    {
        Name = name;
    }

    public string GetName()
    {
        return Name;
    }

    public override string ToString()
    {
        var result = new StringBuilder();
        result.Append("---- " + Name + " ----\n");
        if (Dough != null)
        {
            result.Append(Dough);
            result.Append("\n");
        }
        if (Sauce != null)
        {
            result.Append(Sauce);
            result.Append("\n");
        }
        if (Cheese != null)
        {
            result.Append(Cheese);
            result.Append("\n");
        }
        if (Veggies != null)
        {
            for (int i = 0; i < Veggies.Length; i++)
            {
                result.Append(Veggies[i]);
                if (i < Veggies.Length - 1)
                {
                    result.Append(", ");
                }
            }
            result.Append("\n");
        }
        if (Clam != null)
        {
            result.Append(Clam);
            result.Append("\n");
        }
        if (Pepperoni != null)
        {
            result.Append(Pepperoni);
            result.Append("\n");
        }
        return result.ToString();
    }
}
