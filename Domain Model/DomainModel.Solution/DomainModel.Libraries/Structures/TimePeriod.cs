﻿using DomainModel.Libraries.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Libraries.Structures
{
    /// <summary>
    /// Public structure "TimePeriod"
    /// </summary>
    public struct TimePeriod
    {
        #region Fields and Properties

        /// <summary>
        /// Public int "Period" field
        /// </summary>
        private int period;

        public int Period 
        {
            get { return period; }
            set { period = value; }
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