namespace AbstractFactory.TargetObjects.SouthAfica;

// Note for this example we are ignoring currency and data is NOT accurate  
public class SouthAfricanIncomeTaxCalculator : IncomeTaxCalculator
{
    public override double CalculateIncomeTax(double yearlySalary)
    {
        return yearlySalary switch
        {
            < 195850 => yearlySalary * 0.18,
            <= 305850 => yearlySalary * 0.26,
            <= 423300 => yearlySalary * 0.31,
            _ => yearlySalary * 0.36
        };
    }
}