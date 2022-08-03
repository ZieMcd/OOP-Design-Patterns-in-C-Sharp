namespace Flyweight;

public class ShopItem
{
    public string ItemName { get; init; }
    public string ItemCategory { get; init; }
    public double ItemPrice { get; init; }

    public ShopItem(string itemName, string itemCategory, double itemPrice)
    {
        ItemName = itemName;
        ItemCategory = itemCategory;
        ItemPrice = itemPrice;
    }
}