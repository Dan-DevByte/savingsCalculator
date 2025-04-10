public class savingsCalculator
{
    public double CalculateSavings(double initialAmount, double percentage)
    {
        return initialAmount * (percentage / 100);
    }

    public double CalculateRemaining(double initialAmount, double percentage)
    {
        return initialAmount - CalculateSavings(initialAmount, percentage);
    }
}