using System;

namespace Assignment3
{
    public class Vehicle
    {
        public void StartEngine() => Console.WriteLine("[Vehicle] Engine started.");
        public void StopEngine() => Console.WriteLine("[Vehicle] Engine stopped.");
    }
    public sealed class Car : Vehicle
    {
        public void Drive() => Console.WriteLine("[Car] Driving on the road...");
    }

    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public double Balance { get; set; }
    }
    public sealed class SavingsAccount : BankAccount
    {
        public double CalculateInterest(double rate)
        {
            return Balance * rate / 100;
        }
    }
}
