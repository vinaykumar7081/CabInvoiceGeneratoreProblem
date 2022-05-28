using System;
using CabInvoiceGeneratorProblemStatements;
public class Program
{
    public static void Main(String[] args)
    {
        CabInvoiceGenerator generator = new CabInvoiceGenerator();
        double result = generator.CalculatingFair(15, 5);
        Console.WriteLine(result);
        CabInvoiceGenerator invoice = new CabInvoiceGenerator();
        Ride[] rides = { new Ride(2, 3), new Ride(4, 5), new Ride(5, 6) };
        double result1 = invoice.CalaulateMultipleRides(rides);
        Console.WriteLine(result1);

    }
}