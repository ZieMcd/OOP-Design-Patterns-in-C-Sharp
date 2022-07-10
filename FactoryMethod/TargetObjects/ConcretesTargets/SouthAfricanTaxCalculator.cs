namespace FactoryMethod.TargetObjects.ConcretesTargets;

public class SouthAfricanTaxCalculator : TaxCalculator
{
    public override double CalculateVat(double itemPrice)
    {
        return itemPrice * 0.15;
    }
}