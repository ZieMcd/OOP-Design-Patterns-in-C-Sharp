using Builder.Builders;
using Builder.TargetObjects;

namespace Builder.Directors;

public class TaxCalculatorDirector
{
    public TaxCalculator BuildTaxCalculator(ITaxCalculatorBuilder builder)
    {
        builder.AddVatCalculator();
        builder.AddIncomeTaxCalculator();
        return builder.BuildTaxCalculator();
    }
}