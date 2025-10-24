using System;
using System.Collections.Generic;
public class Storage<T>
{
    private T item;  

    public T Item
    {
        get { return item; }
        set { item = value; }
    }
}
public class Pair<T1, T2>
{
    private T1 first;   
    private T2 second;  

    public T1 First
    {
        get { return first; }
        set { first = value; }
    }

    public T2 Second
    {
        get { return second; }
        set { second = value; }
    }

    public Pair(T1 first, T2 second)
    {
        this.first = first;
        this.second = second;
    }

    public void PrintPair()
    {
        Console.WriteLine($"First: {first}, Second: {second}");
    }
}
public class Calculator<T> where T : struct, IComparable, IConvertible, IFormattable
{
    public double Add(T a, T b) => Convert.ToDouble(a) + Convert.ToDouble(b);
    public double Subtract(T a, T b) => Convert.ToDouble(a) - Convert.ToDouble(b);
    public double Multiply(T a, T b) => Convert.ToDouble(a) * Convert.ToDouble(b);
    public double Divide(T a, T b)
    {
        double divisor = Convert.ToDouble(b);
        if (divisor == 0)
            throw new DivideByZeroException("Division by zero is not allowed.");
        return Convert.ToDouble(a) / divisor;
    }
}
public class MyStack<T>
{
    private List<T> stack;  

    public MyStack()
    {
        stack = new List<T>();
    }

    public void Push(T item) => stack.Add(item);

    public T Pop()
    {
        if (stack.Count == 0)
            throw new InvalidOperationException("Stack is empty.");
        T item = stack[stack.Count - 1];
        stack.RemoveAt(stack.Count - 1);
        return item;
    }
    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= stack.Count)
                throw new IndexOutOfRangeException("Invalid index.");
            return stack[index];
        }
    }

    public int Count => stack.Count; 
}
public class MyQueue<T>
{
    private List<T> queue;
    public MyQueue()
    {
        queue = new List<T>();
    }
    public void Enqueue(T item) => queue.Add(item);

    public T Dequeue()
    {
        if (queue.Count == 0)
            throw new InvalidOperationException("Queue is empty.");
        T item = queue[0];
        queue.RemoveAt(0);
        return item;
    }
    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= queue.Count)
                throw new IndexOutOfRangeException("Invalid index.");
            return queue[index];
        }
    }

    public int Count => queue.Count; 
}