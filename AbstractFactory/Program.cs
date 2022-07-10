// See https://aka.ms/new-console-template for more information

// Note for this example we are ignoring currency and data is NOT accurate   

using AbstractFactory.Factories;
using AbstractFactory.Factories.ConcreteFactories;

Console.WriteLine("What country are you from \n 1 : South Africa \n 2 : Australia");

var country = Console.ReadLine();

TaxCalculatorCreator taxCalculatorCreator;
switch (country)
{
    case "1":
        taxCalculatorCreator = new SouthAfricanTaxCalculatorCreator();
        break;
    case "2":
        taxCalculatorCreator = new AustralianTaxCalculatorCreator();
        break;
    default:
        throw new Exception("Only South Africa and Australia are supported");
}

Console.WriteLine("What is the price of your item");

var itemPrice = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Vat for your item is {taxCalculatorCreator.CreateVatCalculator().CalculateVat(itemPrice)}");

Console.WriteLine("What is your yearly salary");

var yearlySalary = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Income tax for salary is {taxCalculatorCreator.CreateIncomeTaxCalculator().CalculateIncomeTax(yearlySalary)}");


