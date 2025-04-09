using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("C# Functions");

        // Calling a function with no parameters and no return value
        testPull();
        
        SayHello();

        // Calling a function with parameters and no return value
        GreetUser("Axel");

        // Calling a function with parameters and a return value
        int sum = AddNumbers(1, 2);
        Console.WriteLine("Sum: " + sum);

        // Calling a function that returns a boolean
        bool isEven = IsEvenNumber(8);
        Console.WriteLine("Is 15 even? " + isEven);
    }

    // Function with no parameters and no return value
    static void testPull()
    {
        Console.WriteLine("Pull")
    }
    
    static void SayHello()
    {
        Console.WriteLine("Hello World!");
    }

    // Function with parameters and no return value
    static void GreetUser(string name)
    {
        Console.WriteLine("Welcome, " + name + "!");
    }

    // Function with parameters and a return value
    static int AddNumbers(int a, int b)
    {
        return a + b;
    }

    // Function returning a boolean value
    static bool IsEvenNumber(int number)
    {
        return number % 2 == 0;
    }
}
