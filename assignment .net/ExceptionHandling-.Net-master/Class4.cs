using System;

public class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message) : base(message) { }
}

public class Class4
{
    public void BankTransaction()
    {
        try
        {
            Console.Write("Enter account balance: ");
            double balance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter withdrawal amount: ");
            double withdraw = Convert.ToDouble(Console.ReadLine());

            if (withdraw > balance)
                throw new InsufficientBalanceException("Insufficient balance to complete transaction!");

            balance -= withdraw;
            Console.WriteLine("Withdrawal successful. Remaining balance: " + balance);
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
