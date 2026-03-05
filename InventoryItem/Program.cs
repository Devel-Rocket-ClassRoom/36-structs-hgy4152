using System;

// README.md를 읽고 코드를 작성하세요.


InventoryItem[] items = new InventoryItem[5];
items[0] = new InventoryItem("검", 3.5, 1500);
items[1] = new InventoryItem("방패", 5.0, 1200);
items[2] = new InventoryItem("포션", 0.3, 50);
items[3] = new InventoryItem("활", 1.8, 1300);
items[4] = new InventoryItem("투구", 2.0, 800);

Console.WriteLine("=== 인벤토리 목록 ===");

double sumWeight = 0;
int sumPrice = 0;
int maxPrice = int.MinValue;
string maxItemName = null;
double minWeight = double.MaxValue;
string minItemName = null;

foreach (InventoryItem item in items)
{
    sumPrice += item.Price;
    sumWeight += item.Weight;
    Console.WriteLine($"{item.Name} - 무게: {item.Weight}kg, 가격: {item.Price}골드");

    if( item.Price > maxPrice)
    {
        maxPrice = item.Price;
        maxItemName = item.Name;
    }

    if ( item.Weight < minWeight)
    { 
        minWeight = item.Weight; 
        minItemName = item.Name;
    }
}

Console.WriteLine("=== 인벤토리 통계 ===");
Console.WriteLine($"전체 무게: {sumWeight:n1}kg");
Console.WriteLine($"전체 가격: {sumPrice}골드");
Console.WriteLine($"평균 가격: {sumPrice/items.Length:n0}골드");
Console.WriteLine($"가장 비싼 아이템: {maxItemName}");
Console.WriteLine($"가장 가벼운 아이템: {minItemName}");


