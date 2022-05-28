using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGeneratorProblemStatements
{
    public class CabInvoiceGenerator
    {
        //RideType rideType;
       public int MIN_FAIR=5;
        public int FAIR_PR_KM=10;
        public int FAIR_PR_MINUTE=1;
        //public CabInvoiceGenerator(RideType rideType)
        //{ 
        //this.rideType = rideType;
        //    try
        //    {
        //        if (rideType.Equals(RideType.NORMAL))
        //        {
        //            this.MIN_FAIR = 10;
        //            this.FAIR_PR_KM = 15;
        //            this.FAIR_PR_MINUTE = 5;
        //        }
        //        else if (rideType.Equals(RideType.PRIME))
        //        {
        //            this.MIN_FAIR = 5;
        //            this.FAIR_PR_KM = 10;
        //            this.FAIR_PR_MINUTE = 2;
        //        }
        //    }
        //    catch (CabInvoiceException)
        //    {
        //        throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_RIDE, "Invalid Ride");
        //    }
        //}
        public double CalculatingFair(int distance, int time)
        {
            double calculateFair = FAIR_PR_KM * distance + time * FAIR_PR_MINUTE;
            return Math.Max(calculateFair, MIN_FAIR);
        }
        public double CalaulateMultipleRides(Ride[] rides)
        {
            double result = 0.0d;
            foreach (var data in rides)
            {
            result+= CalculatingFair((int)data.distance, (int)data.time);
            }
            return result/rides.Length;

        }

    }
}
