using Builder.TargetObjects.Components;

namespace Builder.TargetObjects;

public class TaxCalculator
{
    public IncomeTaxCalculator? IncomeTaxCalculator { get; set; }
    public VatCalculator? VatCalculator { get; set; }
}