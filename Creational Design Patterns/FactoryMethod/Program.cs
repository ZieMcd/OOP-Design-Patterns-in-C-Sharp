using FactoryMethod.Factories;
using FactoryMethod.Factories.ConcreteFactories;

TaxCalculatorCreator taxCalculatorCreator;

Console.WriteLine("What country are you from \n 1 : South Africa \n 2 : Australia");

var country = Console.ReadLine();

switch (country)
{
    case "1":
        taxCalculatorCreator = new SouthAfricanTaxCalculatorCreator();
        break;
    case "2":
        taxCalculatorCreator = new AustraliaTaxCalculatorCreator();
        break;
    default:
        throw new Exception("Only South Africa and Australia are supported");
}

Console.WriteLine("What is the price of your item");

var itemPrice = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Vat for your item is {taxCalculatorCreator.CreateTaxCalculator().CalculateVat(itemPrice)}");

