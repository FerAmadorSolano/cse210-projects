using System;

class Program
{
    static void Main(string[] args)
    {
        // General
        Assignment assi1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assi1.GetSummary());

        // Math
        MathAssignment assi2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(assi2.GetSummary());
        Console.WriteLine(assi2.GetHomeworkList());

        // Write
        WriteAssignment assi3 = new WriteAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(assi3.GetSummary());
        Console.WriteLine(assi3.GetWritingInformation());


    }
}