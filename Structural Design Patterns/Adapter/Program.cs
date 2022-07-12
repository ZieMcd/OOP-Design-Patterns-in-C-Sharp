// See https://aka.ms/new-console-template for more information

using Adapter;
using Adapter.Adaptors;

Console.WriteLine("What country are you from \n 1 : South Africa \n 2 : Australia");

var country = Console.ReadLine();

ISouthAfricanVatCalculator vatCalculator; 

switch (country)
{
    case "1":
        vatCalculator = new SouthAfricanVatCalculator();
        break;
    case "2":
        vatCalculator = new AustralianVatCalculatorAdaptor();
        break;
    default:
        throw new Exception("Only South Africa and Australia are supported");
}

var items = vatCalculator.CalculateVatForItems();

foreach (var item in items)
{
    Console.WriteLine($"Item Name: {item.ItemsName}, Item Price: {item.ItemPrice}");
}
