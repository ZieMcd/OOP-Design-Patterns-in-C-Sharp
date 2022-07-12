namespace AbstractFactory.TargetObjects.Australia;

// Note for this example we are ignoring currency and data is NOT accurate  
public class AustralianIncomeTaxCalculator : IncomeTaxCalculator
{
    public override double CalculateIncomeTax(double yearlySalary)
    {
        return yearlySalary switch
        {
            < 250000 => yearlySalary * 0.19,
            <= 520000 => yearlySalary * 0.25,
            _ => yearlySalary * 0.37
        };
    }
}