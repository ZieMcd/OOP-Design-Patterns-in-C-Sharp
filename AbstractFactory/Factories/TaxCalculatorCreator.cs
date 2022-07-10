using AbstractFactory.TargetObjects;

namespace AbstractFactory.Factories;

public abstract class TaxCalculatorCreator
{
    public abstract IncomeTaxCalculator CreateIncomeTaxCalculator();
    public abstract VatCalculator CreateVatCalculator();
}