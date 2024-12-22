using s_marcinkowski_135898_cw3;

PizzaBuilder builder = new PizzaBuilder();
PizzaDirector director = new PizzaDirector();

// Tworzenie pizzy Margherita
director.SetBuilder(builder);
director.BuildMargherita();
Pizza margherita = builder.GetPizza();
Console.WriteLine(margherita);

// Tworzenie pizzy Pepperoni
director.BuildPepperoni();
Pizza pepperoni = builder.GetPizza();
Console.WriteLine(pepperoni);

// Tworzenie pizzy niestandardowej
builder.AddDough("Ciasto grube");
builder.AddMeat("Kebab");
builder.AddCheese("Ser żółty");
builder.AddVegetables("Cebula, papryka");
builder.AddSpices("Czosnek, pieprz");
Pizza customPizza = builder.GetPizza();
Console.WriteLine(customPizza);

// Program zwrócił wynik:
// Pizza ze składnikami: Ciasto klasyczne, Mozzarella, Bazylia
// Pizza ze składnikami: Ciasto klasyczne, Salami pepperoni, Mozzarella, Oregano
// Pizza ze składnikami: Ciasto grube, Kebab, Ser żółty, Cebula, papryka, Czosnek, pieprz
// Builder jest zaimplenetowany poprawnie