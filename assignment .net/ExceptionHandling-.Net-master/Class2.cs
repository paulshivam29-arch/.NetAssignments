using System;

public class Class2
{
    public void MultipleCatchBlocks()
    {
        try
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You entered: " + number);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input format. Please enter a valid integer.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Number is too large or too small for an Int32.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
    }
}
