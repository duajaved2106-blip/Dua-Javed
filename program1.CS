using System;

// Base class
class Animal
{
    public string Name;
    public void Eat()
    {
        Console.WriteLine(Name + " is eating.");
    }
}

// Derived class
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine(Name + " is barking.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog myDog = new Dog();
        myDog.Name = "Buddy";
        myDog.Eat();  // Inherited from Animal
        myDog.Bark(); // Own method
    }
}
