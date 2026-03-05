using System;
using System.Collections.Generic;
using System.Text;

struct RecipeCard
{
    public string Name;
    public int Servings;
    public Ingredient[] Ingredients;

    public RecipeCard(string name, int servings, Ingredient[] ingredients)
    {
        Name = name;
        Servings = servings;
        Ingredients = ingredients;
    }

    public void PrintRecipe()
    {
        Console.WriteLine($"[{Name}] ({Servings}인분)");
        Console.WriteLine("재료:");

        foreach (var item in Ingredients)
        {
            Console.WriteLine($"- {item.Name}: {item.Amount}{item.Unit}");
        }

    }


    public void ScaleRecipe(int newServings)
    {
        for (int i = 0; i < Ingredients.Length; i++)
        {
            Ingredients[i].Amount = (Ingredients[i].Amount / 2) * newServings;
        }

        Servings = newServings;
    }
}