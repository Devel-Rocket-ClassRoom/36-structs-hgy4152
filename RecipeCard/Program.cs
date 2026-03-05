using System;
using System.Text;

// README.md를 읽고 코드를 작성하세요.



Console.WriteLine("=== 원본 레시피 ===");
Ingredient[] tomato = new Ingredient[]
{
    new Ingredient("스파게티면", 200, "g"),
    new Ingredient("토마토소스", 150, "ml"),
    new Ingredient("양파", 1, "개"),
    new Ingredient("마늘", 3, "쪽")
};

RecipeCard card = new RecipeCard("토마토 파스타", 2, tomato);
card.PrintRecipe();
Console.WriteLine();
card.ScaleRecipe(4);
card.PrintRecipe();


struct Ingredient
{
    public string Name;
    public double Amount;
    public string Unit;

    public Ingredient(string name, double amount = 0, string unit = null)
    {
        Name = name;
        Amount = amount;
        Unit = unit;
    }
}


struct RecipeCard
{
    public string Name;
    public int Servings;
    public Ingredient[] Ingredients;

    public RecipeCard(string name, int servings, Ingredient[] ingredients)
    {
        Name =name;
        Servings = servings;
        Ingredients = ingredients;
    }

    public void PrintRecipe()
    {
        Console.WriteLine($"[{Name}] ({Servings}인분)");
        Console.WriteLine("재료:");

        foreach ( var item in Ingredients )
        {
            Console.WriteLine($"- {item.Name}: {item.Amount}{item.Unit}");
        }
        
    }


    public void ScaleRecipe(int newServings)
    {
        for (int i = 0; i < Ingredients.Length; i++)
        {
            Ingredients[i].Amount = (Ingredients[i].Amount/2) * newServings;
        }

        Servings = newServings;
    }
}