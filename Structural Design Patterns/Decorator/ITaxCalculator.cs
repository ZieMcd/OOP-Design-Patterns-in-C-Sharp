namespace Decorator;

public interface ITaxCalculator
{
    double CalculateVat(double itemPrice, double taxPercentage);
}