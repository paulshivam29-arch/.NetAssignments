using System;
using System.Xml.Linq;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========== ASSIGNMENT 3 DEMO ===========");

            // ------------------- Q1 & Q2: Instance -------------------
            Console.WriteLine("\n===== Instance Class (Q1 & Q2) =====");

            Instance emp = new Instance { Name = "John", Age = 30, Salary = 50000 };
            emp.DisplayEmployeeDetails();

            Instance acc = new Instance { AccountNumber = "12345", Name = "John" };
            acc.Deposit(2000);
            acc.Withdraw(500);
            acc.DisplayAccountDetails();


            // ------------------- Q3 & Q4: Static -------------------
            Console.WriteLine("\n===== Static Class (Q3 & Q4) =====");

            int[] numbers = { 10, 20, 30, 40 };
            Console.WriteLine("Average: " + Static.CalculateAverage(numbers));
            Static.LogMessage("This is a log from Static class.");


            // ------------------- Q5 & Q6: Partial -------------------
            Console.WriteLine("\n===== Partial Class (Q5 & Q6) =====");

            Partial person = new Partial { FirstName = "Aryansh", LastName = "Chaudhary" };
            person.PrintFullName();

            Partial emp2 = new Partial { EmployeeName = "Sam", BaseSalary = 30000 };
            Console.WriteLine($"Employee: {emp2.EmployeeName}, Final Salary: {emp2.CalculateSalary(5000, 2000)}");


            // ------------------- Q7 & Q8: Abstract -------------------
            Console.WriteLine("\n===== Abstract Class (Q7 & Q8) =====");

            Abstract circle = new Circle { Radius = 5 };
            Console.WriteLine("Circle Area: " + circle.CalculateArea());

            Abstract rect = new Rectangle { Length = 4, Width = 6 };
            Console.WriteLine("Rectangle Area: " + rect.CalculateArea());

            Abstract dog = new Dog { Name = "Tommy", Age = 3 };
            dog.Speak();

            Abstract cat = new Cat { Name = "Kitty", Age = 2 };
            cat.Speak();


            // ------------------- Q9 & Q10: Sealed -------------------
            Console.WriteLine("\n===== Sealed Class (Q9 & Q10) =====");

            Car car = new Car();
            car.StartEngine();
            car.Drive();
            car.StopEngine();

            SavingsAccount sa = new SavingsAccount { AccountNumber = "98765", Balance = 10000 };
            Console.WriteLine($"Account: {sa.AccountNumber}, Balance: {sa.Balance}");
            Console.WriteLine("Interest (5%): " + sa.CalculateInterest(5));
        }
    }
}
