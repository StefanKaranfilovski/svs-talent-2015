﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.Repository
{
    public class SearchFilter
    {
        public string Producer { get; set; }

        public string Colour { get; set; }

        public int PageSize { get; set; }

        public int PageIndex { get; set; }
    }
}
