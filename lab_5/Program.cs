using System;

// Abstract class for Deposit
public abstract class Deposit
{
    // Properties
    public decimal Amount { get; protected set; }
    public int Period { get; protected set; }

    // Constructor
    public Deposit(decimal depositAmount, int depositPeriod)
    {
        Amount = depositAmount;
        Period = depositPeriod;
    }

    // Abstract method for calculating income
    public abstract decimal Income();
}

// Regular deposit class
public class BaseDeposit : Deposit
{
    // Constructor
    public BaseDeposit(decimal amount, int period) : base(amount, period) { }

    // Override method for income calculation
    public override decimal Income()
    {
        decimal income = Amount;
        for (int i = 0; i < Period; i++)
        {
            income *= 1.05m; // 5% monthly interest
        }
        return Math.Round(income - Amount, 2);
    }
}

// Special deposit class
public class SpecialDeposit : Deposit
{
    // Constructor
    public SpecialDeposit(decimal amount, int period) : base(amount, period) { }

    // Override method for income calculation
    public override decimal Income()
    {
        decimal income = Amount;
        for (int i = 0; i < Period; i++)
        {
            income += (income * (i + 1) / 100); // 1% in the first month, 2% in the second, and so on
        }
        return Math.Round(income - Amount, 2);
    }
}

// Long-term deposit class
public class LongDeposit : Deposit
{
    // Constructor
    public LongDeposit(decimal amount, int period) : base(amount, period) { }

    // Override method for income calculation
    public override decimal Income()
    {
        decimal income = Amount;
        for (int i = 0; i < Period; i++)
        {
            if (i >= 6)
            {
                income *= 1.15m; // 15% interest after 6 months
            }
        }
        return Math.Round(income - Amount, 2);
    }
}

// Client class
public class Client
{
    // Fields
    private Deposit[] deposits;

    // Constructor
    public Client()
    {
        deposits = new Deposit[10]; // Initialize deposits array
    }

    // Method to add deposit
    public bool AddDeposit(Deposit deposit)
    {
        for (int i = 0; i < deposits.Length; i++)
        {
            if (deposits[i] == null)
            {
                deposits[i] = deposit;
                return true; // Deposit added successfully
            }
        }
        return false; // Deposit limit reached
    }

    // Method to calculate total income
    public decimal TotalIncome()
    {
        decimal totalIncome = 0;
        foreach (var deposit in deposits)
        {
            if (deposit != null)
            {
                totalIncome += deposit.Income();
            }
        }
        return Math.Round(totalIncome, 2);
    }

    // Method to calculate maximum income
    public decimal MaxIncome()
    {
        decimal maxIncome = 0;
        foreach (var deposit in deposits)
        {
            if (deposit != null && deposit.Income() > maxIncome)
            {
                maxIncome = deposit.Income();
            }
        }
        return Math.Round(maxIncome, 2);
    }

    // Method to get income by deposit number
    public decimal GetIncomeByNumber(int number)
    {
        if (number >= 1 && number <= deposits.Length && deposits[number - 1] != null)
        {
            return deposits[number - 1].Income();
        }
        return 0; // Deposit not found
    }
}

// Main class for testing
class Program
{
    static void Main(string[] args)
    {
        // Create client
        Client client = new Client();

        // Add deposits
        client.AddDeposit(new BaseDeposit(1000, 3));
        client.AddDeposit(new SpecialDeposit(1500, 2));
        client.AddDeposit(new LongDeposit(2000, 12));

        // Print total income
        Console.WriteLine("Total Income: $" + client.TotalIncome());

        // Print maximum income
        Console.WriteLine("Maximum Income: $" + client.MaxIncome());

        // Print income by deposit number
        Console.WriteLine("Income from Deposit 1: $" + client.GetIncomeByNumber(1));
    }
}
