using Adapter.Models;

namespace Adapter;

public class SouthAfricanVatCalculator : ISouthAfricanVatCalculator
{
    private readonly SouthAfricanPriceService _southAfricanPriceService;


    public SouthAfricanVatCalculator()
    {
        _southAfricanPriceService = new SouthAfricanPriceService();
    }

    public IEnumerable<Item> CalculateVatForItems()
    {
        var items = _southAfricanPriceService.GetItems();

        var vat = 0.15;
        return items.Select(x => new Item { ItemsName = x.ItemsName, ItemPrice = x.ItemPrice + x.ItemPrice * vat });
    }
}