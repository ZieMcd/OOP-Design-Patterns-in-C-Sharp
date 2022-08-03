namespace Decorator.Decorators;

public class TaxCalculatorDecorator : ITaxCalculator
{

    private ITaxCalculator _taxCalculator;

    public void SetTaxCalculator(ITaxCalculator taxCalculator)
    {
        _taxCalculator = taxCalculator;
    }
    
    public virtual double CalculateVat(double itemPrice, double taxPercentage)
    {
        if (_taxCalculator is not null)
        {
            return _taxCalculator.CalculateVat(itemPrice, taxPercentage);
        }

        throw new NullReferenceException();
    }
}