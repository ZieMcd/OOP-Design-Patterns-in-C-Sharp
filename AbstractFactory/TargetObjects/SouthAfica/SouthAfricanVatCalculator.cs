namespace AbstractFactory.TargetObjects.SouthAfica;

public class SouthAfricanVatCalculator : VatCalculator
{
    public override double CalculateVat(double itemPrice)
    {
        return itemPrice * 0.15;
    }
}