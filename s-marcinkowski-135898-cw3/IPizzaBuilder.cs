namespace s_marcinkowski_135898_cw3;

public interface IPizzaBuilder
{
    void AddDough(string dough);
    void AddMeat(string meat);
    void AddCheese(string cheese);
    void AddVegetables(string vegetables);
    void AddSpices(string spices);
    Pizza GetPizza();    
}