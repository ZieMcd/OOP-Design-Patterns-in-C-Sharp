// See https://aka.ms/new-console-template for more information

using Flyweight;

var shopItemFactory = new ShopItemFactory();
var inventory = new List<ShopItem>();

Console.WriteLine("How many milk items would you like to add");
var numMilk = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < numMilk; i++)
{
    inventory.Add(shopItemFactory.GetShopItem("Milk"));
}

Console.WriteLine("How many apple items would you like to add");
var numApples = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < numApples; i++)
{
    inventory.Add(shopItemFactory.GetShopItem("Apples"));
}