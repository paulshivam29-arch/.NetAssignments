using System;
public class Class1
{
    public void DivisionByZero()
    {
        try
        {
            Console.Write("Enter numerator: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter denominator: ");
            int den = Convert.ToInt32(Console.ReadLine());

            int result = num / den;
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Division by zero is not allowed.");
        }
        finally
        {
            Console.WriteLine("Execution completed.");
        }
    }
}

