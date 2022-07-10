using FactoryMethod.TargetObjects;
using FactoryMethod.TargetObjects.ConcretesTargets;

namespace FactoryMethod.Factories.ConcreteFactories;

public class AustraliaTaxCalculatorCreator : TaxCalculatorCreator
{
    public override TaxCalculator CreateTaxCalculator()
    {
        return new AustralianTaxCalculator();
    }
}