using DomainModel.Libraries.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Libraries.Structures
{
    /// <summary>
    /// Public structure "InerestRate"
    /// </summary>
    public struct InterestRate
    {
        #region Fields and Properties

        /// <summary>
        /// Public decimal "Percent" field
        /// </summary>
        private decimal percent;

        public decimal Percent 
        {
            get { return percent; }
            set { percent = value; }
        }

        /// <summary>
        /// Public UnitOfTime "Unit" field
        /// </summary>
        private UnitOfTime unit;

        public UnitOfTime Unit 
        {
            get { return unit; }
            set { unit = value; }
        }

        #endregion
    }
}