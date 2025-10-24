using System;

public class Program
{
    public static void Main()
    {
        int choice;
        do
        {
            Console.WriteLine("\n--- Exception Handling Menu ---");
            Console.WriteLine("1. Division by Zero");
            Console.WriteLine("2. Multiple Catch Blocks");
            Console.WriteLine("3. Negative Salary Exception");
            Console.WriteLine("4. Banking Scenario");
            Console.WriteLine("5. Student Marks Validation");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice (1–6): ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    new Class1().DivisionByZero();
                    break;
                case 2:
                    new Class2().MultipleCatchBlocks();
                    break;
                case 3:
                    new Class3().CheckSalary();
                    break;
                case 4:
                    new Class4().BankTransaction();
                    break;
                case 5:
                    new Class5().ValidateMarks();
                    break;
                case 6:
                    Console.WriteLine("Exiting program...");
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please try again.");
                    break;
            }

        } while (choice != 6);
        Console.WriteLine("Developed by Aryansh Chaudhary 2484200038");
        Console.WriteLine("1. (B) try");
        Console.WriteLine("2. (C) Executes always, whether exception occurs or not");
        Console.WriteLine("3. (B) Exception");
        Console.WriteLine("4. (A) The program terminates abnormally");
        Console.WriteLine("5. (B) throw");
        Console.WriteLine("6. (C) DivideByZeroException");
        Console.WriteLine("7. (B) More specific exceptions must appear before general ones");
        Console.WriteLine("8. (B) Yes");
        Console.WriteLine("9. (B) Division by zero not allowed | Finally block executed");
        Console.WriteLine("10. (A) IndexOutOfRangeException");
        Console.WriteLine("11. (A) Rethrows the same exception");
        Console.WriteLine("12. (B) Index error End of program");
        Console.WriteLine("13. (B) Used for user-defined exceptions");
        Console.WriteLine("14. (B) Invalid number format");
        Console.WriteLine("15. (C) Catch");
        Console.WriteLine("16. True");
        Console.WriteLine("17. (B) Passing an exception up the call stack until caught");
        Console.WriteLine("18. (D) Both B and C");
        Console.WriteLine("19. (B) finally’s return overrides try’s");
        Console.WriteLine("20. (A) Must inherit from Exception or ApplicationException");
    }
}
