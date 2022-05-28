using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGeneratorProblemStatements
{/// <summary>
/// class for Custom Exception Handling
/// </summary>
    public class CabInvoiceException:Exception
    {
        /// <summary>
        /// enum for Exception Type
        /// </summary>
        public enum ExceptionType
        { 
        INVALID_DISTANCE,INVALID_RIDE,NULL_TIME,INVALID_USER_ID
        }
        public ExceptionType type;

        /// <summary>
        /// Parameter Constructure for for setting exception type and throwing Exception type
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message"></param>
        public CabInvoiceException(ExceptionType type, string message) : base(message)
        { 
        this.type = type;
        }
    }
}
