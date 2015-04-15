using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpProgrammingBasics.Library.Samples.Exceptions
{
    /// <summary>
    /// Custom exception thrown when a car park is full
    /// </summary>
    public class CarParkFullException : ApplicationException
    {
        /// <summary>
        /// Read only property for the capacity of the carpark
        /// </summary>
        public int CarParkCapacity { get; private set; }

        /// <summary>
        /// Constructor for the CraParkException that allows for specification of the exception message
        /// </summary>
        /// <param name="message"></param>
        /// <param name="capacity"></param>
        public CarParkFullException(string message, int capacity)
            : base(message)
        {
            this.CarParkCapacity = capacity;
        }
    }

}
