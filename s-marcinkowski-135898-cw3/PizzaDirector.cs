namespace s_marcinkowski_135898_cw3;

public class PizzaDirector
{
    private IPizzaBuilder _builder;

    public void SetBuilder(IPizzaBuilder builder)
    {
        _builder = builder;
    }

    public void BuildMargherita()
    {
        _builder.AddDough("Ciasto klasyczne");
        _builder.AddCheese("Mozzarella");
        _builder.AddSpices("Bazylia");
    }

    public void BuildPepperoni()
    {
        _builder.AddDough("Ciasto klasyczne");
        _builder.AddMeat("Salami pepperoni");
        _builder.AddCheese("Mozzarella");
        _builder.AddSpices("Oregano");
    }    
}