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
    }
}