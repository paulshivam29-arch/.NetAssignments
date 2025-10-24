using System;

namespace Assignment3
{
    public partial class Partial
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void PrintFullName()
        {
            Console.WriteLine($"[Partial - Person] Full Name: {FirstName} {LastName}");
        }
    }
    public partial class Partial
    {
        public string EmployeeName { get; set; }
        public double BaseSalary { get; set; }

        public double CalculateSalary(double bonus, double deductions)
        {
            return BaseSalary + bonus - deductions;
        }
    }
}

  
   
