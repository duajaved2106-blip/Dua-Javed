using System;

class Calculator
{
    // Method 1: Add two integers
    public int Add(int a, int b)
    {
        return a + b;
    }

    // Method 2: Add three integers (overloaded)
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    // Method 3: Add two doubles (overloaded)
    public double Add(double a, double b)
    {
        return a + b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();
        Console.WriteLine(calc.Add(5, 10));       // 15
        Console.WriteLine(calc.Add(5, 10, 15));   // 30
        Console.WriteLine(calc.Add(5.5, 2.5));    // 8.0
    }
}
