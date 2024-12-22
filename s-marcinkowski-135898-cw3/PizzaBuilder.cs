namespace s_marcinkowski_135898_cw3;

public class PizzaBuilder : IPizzaBuilder
{
    private Pizza _pizza;

    public PizzaBuilder()
    {
        Reset();
    }

    public void Reset()
    {
        _pizza = new Pizza();
    }

    public void AddDough(string dough)
    {
        _pizza.AddIngredient(dough);
    }

    public void AddMeat(string meat)
    {
        _pizza.AddIngredient(meat);
    }

    public void AddCheese(string cheese)
    {
        _pizza.AddIngredient(cheese);
    }

    public void AddVegetables(string vegetables)
    {
        _pizza.AddIngredient(vegetables);
    }

    public void AddSpices(string spices)
    {
        _pizza.AddIngredient(spices);
    }

    public Pizza GetPizza()
    {
        Pizza result = _pizza;
        Reset();
        return result;
    }    
}