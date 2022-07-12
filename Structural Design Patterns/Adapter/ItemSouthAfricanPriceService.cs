using Adapter.Models;

namespace Adapter;

public class SouthAfricanPriceService
{
    private readonly Item[] _items = new[]
    {
        new Item{ItemsName = "Milk", ItemPrice = 10},
        new Item{ItemsName = "Bread", ItemPrice = 15},
        new Item{ItemsName = "Eggs", ItemPrice = 20}
    };

    public IEnumerable<Item> GetItems()
    {
        return _items;
    }
}