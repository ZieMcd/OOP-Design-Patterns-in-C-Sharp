namespace Decorator;

public class TaxCalculator : ITaxCalculator
{
    public double CalculateVat(double itemPrice, double taxPercentage)
    {
        return itemPrice * taxPercentage;
    }
}