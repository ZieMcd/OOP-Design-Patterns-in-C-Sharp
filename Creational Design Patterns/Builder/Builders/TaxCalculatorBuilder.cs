using Builder.TargetObjects;
using Builder.TargetObjects.Components;

namespace Builder.Builders;

public interface ITaxCalculatorBuilder
{
    void AddVatCalculator();
    void AddIncomeTaxCalculator();

    TaxCalculator BuildTaxCalculator();
}