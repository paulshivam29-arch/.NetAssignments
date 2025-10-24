using System;

namespace Assignment3
{
    public class Instance
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public string AccountNumber { get; set; }
        public double Balance { get; private set; }


        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"[Employee] Name: {Name}, Age: {Age}, Salary: {Salary}");
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"[BankAccount] Deposited: {amount}, New Balance: {Balance}");
        }

        public void Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"[BankAccount] Withdrew: {amount}, New Balance: {Balance}");
            }
            else
            {
                Console.WriteLine("[BankAccount] Insufficient Balance!");
            }
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine($"[BankAccount] Account: {AccountNumber}, Holder: {Name}, Balance: {Balance}");
        }
    }
}



