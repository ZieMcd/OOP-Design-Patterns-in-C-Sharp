namespace FactoryMethod.TargetObjects.ConcretesTargets;

public class AustraliaTaxCalculator : TaxCalculator
{
   
    public override double CalculateVat(double itemPrice)
    {
        return itemPrice * 0.1;
    }
}