using AbstractFactory.TargetObjects;
using AbstractFactory.TargetObjects.Australia;

namespace AbstractFactory.Factories.ConcreteFactories;

public class AustralianTaxCalculatorCreator : TaxCalculatorCreator
{
    public override IncomeTaxCalculator CreateIncomeTaxCalculator()
    {
        return new AustralianIncomeTaxCalculator();
    }

    public override VatCalculator CreateVatCalculator()
    {
        return new AustralianVatCalculator();
    }
}