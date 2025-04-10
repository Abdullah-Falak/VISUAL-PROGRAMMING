using System;

class TypeCastingExample
{
    static void Main()
    {
        //Implicit Type Casting
        int intNum = 100;
        float floatNum = intNum;
        double doubleNum = floatNum;

        Console.WriteLine("Integer Value: " + intNum);
        Console.WriteLine("Float Value: " + floatNum);
        Console.WriteLine("Double Value: " + doubleNum);

        //Explicit Type Casting
        double largeNum = 99.99;
        float smallFloat = (float)largeNum;
        int smallInt = (int)smallFloat;

        Console.WriteLine("Original Double: " + largeNum);
        Console.WriteLine("Converted to Float: " + smallFloat);
        Console.WriteLine("Converted to Integer: " + smallInt);
    }
}
