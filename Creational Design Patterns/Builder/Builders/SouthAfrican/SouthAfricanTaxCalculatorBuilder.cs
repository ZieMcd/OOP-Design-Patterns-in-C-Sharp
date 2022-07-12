using Builder.TargetObjects;
using Builder.TargetObjects.Components.SouthAfrica;

namespace Builder.Builders.SouthAfrican;

public class SouthAfricanTaxCalculatorBuilder : ITaxCalculatorBuilder
{
    private readonly TaxCalculator _taxCalculator = new TaxCalculator();

    public void AddVatCalculator()
    {
        _taxCalculator.VatCalculator = new SouthAfricanVatCalculator();
    }

    public void AddIncomeTaxCalculator()
    {
        _taxCalculator.IncomeTaxCalculator = new SouthAfricanIncomeTaxCalculator();
    }

    public TaxCalculator BuildTaxCalculator()
    {
        return _taxCalculator;
    }
}