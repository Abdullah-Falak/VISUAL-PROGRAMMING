using System;

class Program
{
    // Global variable
    static int globalNumber;

    // Constant variable (must be assigned at declaration)
    const double Pi = 3.14159;

    // Readonly variable (can only be assigned in a constructor or at declaration)
    static readonly string AppName;

    // Static constructor to initialize readonly variable
    static Program()
    {
        AppName = "SingleClassDemo";
    }

    static void Main()
    {
        // Local variable
        int localNumber = 10;

        // Assign value to global variable
        globalNumber = 25;

        Console.WriteLine("Local Variable: " + localNumber);
        Console.WriteLine("Global Variable: " + globalNumber);
        Console.WriteLine("Constant Pi: " + Pi);
        Console.WriteLine("Readonly AppName: " + AppName);
    }
}
