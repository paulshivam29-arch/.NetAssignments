using System;

namespace Assignment3
{
    public abstract class Abstract
    {
        public abstract double CalculateArea();
        public virtual void Speak()
        {
 
        }
    }
    public class Circle : Abstract
    {
        public double Radius { get; set; }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
        public override void Speak()
        {
            Console.WriteLine("[Circle] Shapes don’t speak.");
        }
    }

    public class Rectangle : Abstract
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public override double CalculateArea()
        {
            return Length * Width;
        }

        public override void Speak()
        {
            Console.WriteLine("[Rectangle] Shapes don’t speak.");
        }
    }
    public class Dog : Abstract
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public override double CalculateArea() => 0;

        public override void Speak()
        {
            Console.WriteLine($"{Name} (Dog, {Age} years old) says: Woof! Woof!");
        }
    }

    public class Cat : Abstract
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override double CalculateArea() => 0;

        public override void Speak()
        {
            Console.WriteLine($"{Name} (Cat, {Age} years old) says: Meow! Meow!");
        }
    }
}
