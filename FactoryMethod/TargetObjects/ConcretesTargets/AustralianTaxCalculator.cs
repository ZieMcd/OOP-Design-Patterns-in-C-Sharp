namespace FactoryMethod.TargetObjects.ConcretesTargets;

public class AustralianTaxCalculator : TaxCalculator
{
   
    public override double CalculateVat(double itemPrice)
    {
        return itemPrice * 0.1;
    }
}