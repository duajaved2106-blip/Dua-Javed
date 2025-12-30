using System;

// Base class
class Animal
{
    public string Name;

    // Base class constructor
    public Animal(string name)
    {
        Name = name;
        Console.WriteLine("Animal constructor called");
    }
}

// Derived class
class Dog : Animal
{
    // Derived class constructor
    public Dog(string name) : base(name)  // Calls base class constructor
    {
        Console.WriteLine("Dog constructor called");
    }

    public void Bark()
    {
        Console.WriteLine(Name + " is barking.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog myDog = new Dog("Buddy");
        myDog.Bark();
    }
}
