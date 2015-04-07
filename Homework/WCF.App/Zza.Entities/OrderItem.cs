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
    public partial class OrderItem
    {
        /// <summary>
        /// The [DataMember] attribute marks the properties as serializable members
        /// </summary>
        [DataMember]
        public long Id { get; set; }

        [DataMember]
        public long OrderId { get; set; }

        [DataMember]
        public int ProductId { get; set; }

        [DataMember]
        public int Quantity { get; set; }

        [DataMember]
        public decimal UnitPrice { get; set; }

        [DataMember]
        public decimal TotalPrice { get; set; }
    }
}
