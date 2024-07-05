using System;

public class BankAccount
{
    private string accountNumber;
    private decimal balance;

    public BankAccount(string accountNumber, decimal initialBalance)
    {
        this.accountNumber = accountNumber;
        balance = initialBalance;
    }
    public string GetAccountNumber()
    {
        return accountNumber;
    }
    public decimal GetBalance()
    {
        return balance;
    }
    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Deposit amount must be positive.");
            return;
        }

        balance += amount;
        Console.WriteLine($"Successfully deposited {amount:C}. New balance is {balance:C}.");
    }
    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdrawal amount must be positive.");
            return;
        }

        if (amount > balance)
        {
            Console.WriteLine("Insufficient funds.");
            return;
        }

        balance -= amount;
        Console.WriteLine($"Successfully withdrew {amount:C}. New balance is {balance:C}.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount("1234567890", 1000.00m);
        Console.WriteLine($"Account Number: {account.GetAccountNumber()}");
        Console.WriteLine($"Current Balance: {account.GetBalance():C}");
        account.Deposit(250.00m);
        Console.WriteLine($"Current Balance: {account.GetBalance():C}");
        account.Withdraw(100.00m);
        Console.WriteLine($"Current Balance: {account.GetBalance():C}");
        account.Withdraw(2000.00m);
    }
}
