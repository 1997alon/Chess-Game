using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess;

// Abstract class
public abstract class Animal
{
    // Abstract method (no implementation)
    public abstract void MakeSound();

    // Regular method (with implementation)
    public void Eat()
    {
        Console.WriteLine("This animal is eating.");
    }
}

// Derived class
public class Dog : Animal
{
    // Implementation of the abstract method
    public override void MakeSound()
    {
        Console.WriteLine("The dog barks: Woof! Woof!");
    }
}

// Derived class
public class Cat : Animal
{
    // Implementation of the abstract method
    public override void MakeSound()
    {
        Console.WriteLine("The cat meows: Meow!");
    }
}

