using FactoryMethod.TargetObjects;

namespace FactoryMethod.Factories;

public abstract class TaxCalculatorCreator
{
    public abstract TaxCalculator CreateTaxCalculator();
}