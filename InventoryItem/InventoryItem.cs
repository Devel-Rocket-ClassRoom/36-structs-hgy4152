using System;
using System.Text;

struct InventoryItem
{
    public string Name { get; set; }
    public double Weight;
    public int Price;

    public InventoryItem(string name, double weight, int price)
    {
        Name = name;
        Weight = weight;
        Price = price;
    }

}
