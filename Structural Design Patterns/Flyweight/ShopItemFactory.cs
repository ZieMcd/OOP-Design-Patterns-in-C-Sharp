namespace Flyweight;

public class ShopItemFactory
{
    private Dictionary<string, ShopItem> _shopItems;

    public ShopItemFactory()
    {
        _shopItems = new()
        {
            ["Milk"] = new ShopItem("Milk","Dairy",32.10),
            ["Steak"] = new ShopItem("Steak","Meat",132),
            ["Apple"] = new ShopItem("Apple","Fruit",15.50)
        };
    }

    public ShopItem GetShopItem(string itemName)
    {
        return _shopItems[itemName];
    }
}