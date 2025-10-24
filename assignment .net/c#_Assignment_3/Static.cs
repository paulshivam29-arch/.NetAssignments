using System;
using System.Linq;

namespace Assignment3
{
    // Combined Static Class for Q3 and Q4
    public static class Static
    {
        // Q3: Method to calculate average
        public static double CalculateAverage(int[] numbers)
        {
            if (numbers.Length == 0) return 0;
            return numbers.Average();
        }

        // Q4: Method to log a message
        public static void LogMessage(string message)
        {
            Console.WriteLine($"[Static Log]: {message}");
        }
    }
}