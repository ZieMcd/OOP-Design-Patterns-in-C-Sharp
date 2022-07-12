using Adapter.Models;

namespace Adapter.Adaptors;

public class AustralianVatCalculatorAdaptor : ISouthAfricanVatCalculator
{
    private readonly SouthAfricanPriceService _southAfricanPriceService;
    
    public AustralianVatCalculatorAdaptor()
    {
        _southAfricanPriceService = new SouthAfricanPriceService();
    }
    public IEnumerable<Item> CalculateVatForItems()
    {
        var items = _southAfricanPriceService.GetItems();

        var vat = 0.10;
        
        //Rand to Australian dollar ratio
        var ZARtoAUD = 11.51; 

        return items.Select(x => new Item { ItemsName = x.ItemsName, ItemPrice = (x.ItemPrice + x.ItemPrice *vat) * ZARtoAUD });    
    }
}