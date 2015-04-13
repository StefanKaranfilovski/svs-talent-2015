using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Libraries.Classes
{
    /// <summary>
    /// Custom exeption class that inherits from ApplicationExeption
    /// </summary>
    public class CurrencyMismatchException : ApplicationException
    {
        /// <summary>
        /// Constructor that calls the base class constructor and passes the message parameter
        /// </summary>
        /// <param type=string name="message"></param>
        public CurrencyMismatchException(string message) : base(message)
        {

        }
    }
}
