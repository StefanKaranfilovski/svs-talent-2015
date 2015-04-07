using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace WCF.Entities
{
    /// <summary>
    /// The [DataContract] attribute specifies that this class contains serializable members
    /// </summary>
    [DataContract]
    public class Product
    {
        /// <summary>
        /// The [DataMember] attribute marks the properties as serializable members
        /// </summary>
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Type { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }
    }
}
