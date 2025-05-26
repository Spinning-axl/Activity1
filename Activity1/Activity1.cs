using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("C# Functions");

        createBranch();

        // Calling a function with no parameters and no return value
        HelloWorld();

        // Calling a function with parameters and no return value
        Introduce("John Axel");

        // Calling a function with parameters and a return value
        int age = ageCalcu(2025, 2003);
        Console.WriteLine("I'm " + age + " yrs. old");

        // Calling a function that returns a boolean
        bool isTrue = IsTrue(age);
        Console.WriteLine("Is he/she legal age? " + isTrue);

        // New functions added in this branch
        DisplayQuote();
        string reversed = ReverseString("Hello C#!");
        Console.WriteLine("Reversed String: " + reversed);

        int sum = AddNumbers(10, 20, 30);
        Console.WriteLine("Sum of numbers: " + sum);

        string status = AgeStatus(age);
        Console.WriteLine("Age Status: " + status);
    }

    static void createBranch()
    {
        Console.WriteLine("Creating a new branch...");
        Console.WriteLine("Branch created successfully!");
    }

    static void HelloWorld()
    {
        Console.WriteLine("Hello, C#! Updated from feature branch.");
    }

    static void Introduce(string name)
    {
        Console.WriteLine("Nice to meet you! I'm " + name + " from the feature branch!");
    }

    static int ageCalcu(int currentYear, int birthYear)
    {
        return currentYear - birthYear;
    }

    static bool IsTrue(int number)
    {
        return number >= 18;
    }

    // New function: Display a motivational quote
    static void DisplayQuote()
    {
        Console.WriteLine("\"The only way to do great work is to love what you do.\" - Steve Jobs");
    }

    // New function: Reverse a string
    static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    // New function: Add multiple numbers
    static int AddNumbers(int a, int b, int c)
    {
        return a + b + c;
    }

    // New function: Return status based on age
    static string AgeStatus(int age)
    {
        if (age < 13)
            return "Child";
        else if (age < 20)
            return "Teenager";
        else if (age < 60)
            return "Adult";
        else
            return "Senior";
    }
}

