using Adapter.Models;

namespace Adapter;

public interface ISouthAfricanVatCalculator
{
    IEnumerable<Item> CalculateVatForItems();
}