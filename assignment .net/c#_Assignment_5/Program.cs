using System;

// Q1
class Class1
{
    private double balance;

    public double Balance
    {
        get { return balance; }
        set { balance += value; } 
    }

    public void Withdraw(double amount)
    {
        if (amount <= balance)
            balance -= amount;
        else
            Console.WriteLine("Insufficient balance!");
    }

    public void Show()
    {
        Balance = 1000; 
        Withdraw(500);
        Console.WriteLine($"Final Balance: {balance}");
    }
}

// Q2
class Class2
{
    private int age;

    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 5 && value <= 25)
                age = value;
            else
                age = 18;
        }
    }

    public void Show()
    {
        Age = 4; Console.WriteLine($"Age (4): {Age}");
        Age = 20; Console.WriteLine($"Age (20): {Age}");
        Age = 30; Console.WriteLine($"Age (30): {Age}");
    }
}

// Q3
class Class3
{
    private double basicSalary;
    public double BasicSalary
    {
        set { basicSalary = value; }
    }

    public double TotalSalary
    {
        get { return basicSalary + (basicSalary * 0.2); }
    }

    public void Show()
    {
        BasicSalary = 30000;
        Console.WriteLine($"Total Salary: {TotalSalary}");
    }
}

// Q4
class Class4
{
    public double Price { get; set; }
    public double Discount { get; set; }

    public double FinalPrice()
    {
        return Price - (Price * Discount / 100);
    }

    public void Show()
    {
        Price = 2000;
        Discount = 10;
        Console.WriteLine($"Final Price: {FinalPrice()}");
    }
}

// Q5
class Class5
{
    private int speed;
    public int Speed
    {
        get { return speed; }
        set
        {
            if (value > 180)
                speed = 180;
            else
                speed = value;
        }
    }

    public void Show()
    {
        Speed = 150;
        Speed = 200;
        Console.WriteLine($"Final Speed: {Speed} km/h");
    }
}

// Q6
delegate int Operation(int a, int b);
class Class6
{
    public static int Add(int a, int b) => a + b;
    public static int Subtract(int a, int b) => a - b;

    public void Show()
    {
        Console.Write("Enter first number: ");
        int n1 = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int n2 = int.Parse(Console.ReadLine());

        Operation op1 = Add;
        Operation op2 = Subtract;

        Console.WriteLine($"Addition: {op1(n1, n2)}");
        Console.WriteLine($"Subtraction: {op2(n1, n2)}");
    }
}

// Q7
delegate string FormatText(string input);
class Class7
{
    public static string ToUpperCase(string s) => s.ToUpper();
    public static string ToLowerCase(string s) => s.ToLower();

    public void Show()
    {
        string input = "Hello World";
        FormatText f1 = ToUpperCase;
        FormatText f2 = ToLowerCase;
        Console.WriteLine($"Uppercase: {f1(input)}");
        Console.WriteLine($"Lowercase: {f2(input)}");
    }
}

// Q8
delegate void BillingOperation(double amount);
class Class8
{
    static double finalAmount;

    public static void ShowTotal(double amt)
    {
        finalAmount = amt;
        Console.WriteLine($"Original Price: ₹{finalAmount}");
    }

    public static void ApplyDiscount(double amt)
    {
        finalAmount -= (amt * 0.10);
        Console.WriteLine($"After 10% Discount: ₹{finalAmount}");
    }

    public static void AddTax(double amt)
    {
        finalAmount += (finalAmount * 0.18);
        Console.WriteLine($"After 18% GST: ₹{finalAmount}");
    }

    public static void FinalBill(double amt)
    {
        Console.WriteLine($"Final Payable Amount: ₹{finalAmount}");
    }

    public void Show()
    {
        double amount = 5000;
        BillingOperation bo = ShowTotal;
        bo += ApplyDiscount;
        bo += AddTax;
        bo += FinalBill;
        bo(amount);
    }
}

// Q9
delegate void ConvertTemperature(double celsius);
class Class9
{
    public static void ToFahrenheit(double c)
    {
        double f = (c * 9 / 5) + 32;
        Console.WriteLine($"{c}°C = {f}°F");
    }

    public static void ToKelvin(double c)
    {
        double k = c + 273.15;
        Console.WriteLine($"{c}°C = {k}K");
    }

    public void Show()
    {
        double temp = 25;
        ConvertTemperature conv = ToFahrenheit;
        conv += ToKelvin;
        conv(temp);
    }
}

// Q10
delegate void Notifier(string msg);
class Class10
{
    public static void SendEmail(string msg)
    {
        Console.WriteLine($"Email Sent: {msg}");
    }

    public static void SendSMS(string msg)
    {
        Console.WriteLine($"SMS Sent: {msg}");
    }

    public void Show()
    {
        Notifier notify = SendEmail;
        notify += SendSMS;
        notify("Assignment Submitted Successfully");
    }
}


class Program
{
    static void Main()
    {
        Console.WriteLine("=== Q1 ==="); new Class1().Show();
        Console.WriteLine("\n=== Q2 ==="); new Class2().Show();
        Console.WriteLine("\n=== Q3 ==="); new Class3().Show();
        Console.WriteLine("\n=== Q4 ==="); new Class4().Show();
        Console.WriteLine("\n=== Q5 ==="); new Class5().Show();
        Console.WriteLine("\n=== Q6 ==="); new Class6().Show();
        Console.WriteLine("\n=== Q7 ==="); new Class7().Show();
        Console.WriteLine("\n=== Q8 ==="); new Class8().Show();
        Console.WriteLine("\n=== Q9 ==="); new Class9().Show();
        Console.WriteLine("\n=== Q10 ==="); new Class10().Show();
        Console.WriteLine("Developed by Aryansh Chaudhary 2484200038");
    }
}
