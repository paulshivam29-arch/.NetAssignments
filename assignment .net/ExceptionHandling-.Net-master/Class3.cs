using System;

public class NegativeSalaryException : Exception
{
    public NegativeSalaryException(string message) : base(message) { }
}

public class Class3
{
    public void CheckSalary()
    {
        try
        {
            Console.Write("Enter salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());
            if (salary < 0)
                throw new NegativeSalaryException("Salary cannot be negative!");
            Console.WriteLine("Valid Salary: " + salary);
        }
        catch (NegativeSalaryException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
