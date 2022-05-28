using System;
using CabInvoiceGeneratorProblemStatements;
public class Program
{
    public static void Main(String[] args)
    {
        CabInvoiceGenerator generator = new CabInvoiceGenerator();
        double result = generator.CalculatingFair(15, 5);
        Console.WriteLine(result);
    }
}