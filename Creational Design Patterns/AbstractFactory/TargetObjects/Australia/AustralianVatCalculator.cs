namespace AbstractFactory.TargetObjects.Australia;

public class AustralianVatCalculator : VatCalculator
{
    public override double CalculateVat(double itemPrice)
    {
        return itemPrice * 0.1;
    }
}