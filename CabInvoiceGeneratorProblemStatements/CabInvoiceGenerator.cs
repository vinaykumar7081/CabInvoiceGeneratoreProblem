using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGeneratorProblemStatements
{
    public class CabInvoiceGenerator
    {
        RideType rideType;
        private readonly int MIN_FAIR;
        private readonly int FAIR_PR_KM;
        private readonly int FAIR_PR_MINUTE;
        public CabInvoiceGenerator(RideType rideType)
        { 
        this.rideType = rideType;
            try
            {
                if (rideType.Equals(RideType.NORMAL))
                {
                    this.MIN_FAIR = 10;
                    this.FAIR_PR_KM = 15;
                    this.FAIR_PR_MINUTE = 5;
                }
                else if (rideType.Equals(RideType.PRIME))
                {
                    this.MIN_FAIR = 5;
                    this.FAIR_PR_KM = 10;
                    this.FAIR_PR_MINUTE = 2;
                }
            }
            catch (CabInvoiceException)
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_RIDE, "Invalid Ride");
            }
        }
        public double CalculatingFair(int distance, int time)
        {
            double calculateFair = FAIR_PR_KM * distance + time * FAIR_PR_MINUTE;
            return calculateFair;
        }

    }
}
