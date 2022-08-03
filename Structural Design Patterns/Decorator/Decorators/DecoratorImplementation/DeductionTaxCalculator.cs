namespace Decorator.Decorators.DecoratorImplementation;

public class DeductionTaxCalculator : TaxCalculatorDecorator
{
    private double discount;
    public DeductionTaxCalculator(double discount)
    {
        this.discount = discount;
    }
    public override double CalculateVat(double itemPrice, double taxPercentage)
    {
        var item = base.CalculateVat(itemPrice, taxPercentage);
        return item - (item * discount);
    }
}