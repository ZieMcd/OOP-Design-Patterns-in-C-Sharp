using Builder.Builders.SouthAfrican;
using Builder.Directors;

var director = new TaxCalculatorDirector();

var taxCalculator = director.BuildTaxCalculator(new SouthAfricanTaxCalculatorBuilder());

Console.WriteLine("What is the price of your item?");
var itemPrice = Convert.ToDouble(Console.ReadLine());
var itemVat = taxCalculator.VatCalculator.CalculateVat(itemPrice);
Console.WriteLine($"Item vat is {itemVat}");

Console.WriteLine("What is your yearly salary?");
var incomeSalary = Convert.ToDouble(Console.ReadLine());
var incomeTax = taxCalculator.IncomeTaxCalculator.CalculateIncomeTax(incomeSalary);
Console.WriteLine($"your income salary is {incomeTax}");