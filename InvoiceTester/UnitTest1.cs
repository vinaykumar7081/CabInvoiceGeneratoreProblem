using CabInvoiceGeneratorProblemStatements;
using NUnit.Framework;

namespace InvoiceTester
{
    public class Tests
    {

        [Test]
        public void InputInInteger_ShouldReturn_TotalFair()
        {
            CabInvoiceGenerator invoice = new CabInvoiceGenerator();
            double result = invoice.CalculatingFair(15, 5);
            Assert.AreEqual(result, 155);
        }
        [Test]
        public void InputInInteger_ShouldReturn_MultipleRides_TotalFair()
        {
            CabInvoiceGenerator invoice = new CabInvoiceGenerator();
            Ride[] rides = { new Ride(2,3), new Ride(4, 5), new Ride(5, 6) };
            double result = invoice.CalaulateMultipleRides(rides);
            Assert.AreEqual(result, 41.333333333333336);
        }
    }
}