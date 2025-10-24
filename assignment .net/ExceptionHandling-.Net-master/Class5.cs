using System;

public class InvalidMarksException : Exception
{
    public InvalidMarksException(string message) : base(message) { }
}

public class Class5
{
    public void ValidateMarks()
    {
        try
        {
            Console.Write("Enter student marks (0–100): ");
            int marks = Convert.ToInt32(Console.ReadLine());
            if (marks < 0 || marks > 100)
                throw new InvalidMarksException("Marks should be between 0 and 100 only!");
            Console.WriteLine("Valid marks entered: " + marks);
        }
        catch (InvalidMarksException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
