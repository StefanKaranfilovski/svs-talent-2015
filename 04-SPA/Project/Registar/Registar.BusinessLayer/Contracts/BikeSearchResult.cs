﻿using Registar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.BusinessLayer.Contracts
{
    public class BikeSearchResult : CommandResult
    {
        public IEnumerable<Bike> Result { get; set; }
    }
}
