namespace Builder.TargetObjects.Components.SouthAfrica;

public class SouthAfricanVatCalculator : VatCalculator
{
    public override double CalculateVat(double itemPrice)
    {
        return itemPrice * 0.15;
    }
}