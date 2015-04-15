using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpProgrammingBasics.Library.Samples.Attributes
{
    /// <summary>
    /// <write description here>
    /// </summary>
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
    public class VehicleMetadataAttribute : Attribute
    {
        public string ShortName { get; set; }

        public string Description { get; set; }
    }

}
