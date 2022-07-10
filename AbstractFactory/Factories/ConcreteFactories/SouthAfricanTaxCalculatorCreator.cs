using AbstractFactory.TargetObjects;
using AbstractFactory.TargetObjects.SouthAfica;

namespace AbstractFactory.Factories.ConcreteFactories;

public class SouthAfricanTaxCalculatorCreator : TaxCalculatorCreator
{
    public override IncomeTaxCalculator CreateIncomeTaxCalculator()
    {
        return new SouthAfricanIncomeTaxCalculator();
    }

    public override VatCalculator CreateVatCalculator()
    {
        return new SouthAfricanVatCalculator();
    }
}