using System;
using System.Collections.Generic;
using DatabaseTwo.Extensions;

#nullable disable

namespace DatabaseTwo.DatabaseTwo
{
    public partial class JosVirtuemartOrderHistory : EntityUtilities
    {
        public int VirtuemartOrderHistoryId { get; set; }
        public int VirtuemartOrderId { get; set; }
        public string OrderStatusCode { get; set; }
        public int CustomerNotified { get; set; }
        public string Comments { get; set; }
        public int? Published { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
    }
}
