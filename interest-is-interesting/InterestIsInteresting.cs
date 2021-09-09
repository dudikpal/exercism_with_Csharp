using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        return balance switch
        {
            var b when b < 0 => -3.213f,
            var b when 0 <= b && b < 1000 => 0.5f,
            var b when 1000 <= b && b < 5000 => 1.621f,
            var b when 5000 <= b => 2.475f,
            _ => 0
        };
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return balance + Decimal.Multiply(balance, Math.Abs((decimal)InterestRate(balance) / 100));
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int requireYears = 0;        
        while (balance < targetBalance)
        {
            balance = AnnualBalanceUpdate(balance);
            requireYears++;
        }
        
        return requireYears;
    }
}
