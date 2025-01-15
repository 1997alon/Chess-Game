using Chess;

class Program
{
    static void Main(string[] args)
    {
        // Create objects of the derived classes
        Animal dog = new Dog();
        Animal cat = new Cat();

        // Call methods
        dog.MakeSound(); // "The dog barks: Woof! Woof!"
        dog.Eat();       // "This animal is eating."

        cat.MakeSound(); // "The cat meows: Meow!"
        cat.Eat();       // "This animal is eating."
    }
}
