using FactoryMethod.TargetObjects;
using FactoryMethod.TargetObjects.ConcretesTargets;

namespace FactoryMethod.Factories.ConcreteFactories;

public class SouthAfricanTaxCalculatorCreator : TaxCalculatorCreator
{
    public override TaxCalculator CreateTaxCalculator()
    {
        return new SouthAfricanTaxCalculator();
    }
}