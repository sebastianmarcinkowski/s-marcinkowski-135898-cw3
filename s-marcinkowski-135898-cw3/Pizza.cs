namespace s_marcinkowski_135898_cw3;

public class Pizza
{
    private readonly List<string> _ingredients = new List<string>();

    public void AddIngredient(string ingredient)
    {
        _ingredients.Add(ingredient);
    }

    public override string ToString()
    {
        return $"Pizza ze składnikami: {string.Join(", ", _ingredients)}";
    }    
}