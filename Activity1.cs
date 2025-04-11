using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("C# Functions");

        // Calling a function with no parameters and no return value
        HelloWorld();

        // Calling a function with parameters and no return value
        Introduce("Axel");

        // Calling a function with parameters and a return value
        int age = ageCalcu(2025, 2003);
        Console.WriteLine("I'm " + age + " yrs. old");

        // Calling a function that returns a boolean
        bool isTrue = IsTrue(age);
        Console.WriteLine("Is he/she legal age? " + isTrue);
    }

    // Function with no parameters and no return value
    static void HelloWorld()
    {
        Console.WriteLine("Hello World!");
    }

    // Function with parameters and no return value
    static void Introduce(string name)
    {
        Console.WriteLine("I'm " + name + "!");
    }

    // Function with parameters and a return value
    static int ageCalcu(int a, int b)
    {
        return a - b;
    }

    // Function returning a boolean value
    static bool IsTrue(int number)
    {
        return number >= 18;
    }
}
