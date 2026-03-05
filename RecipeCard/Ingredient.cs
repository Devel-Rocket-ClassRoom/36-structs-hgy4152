using System;
using System.Collections.Generic;
using System.Text;

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

