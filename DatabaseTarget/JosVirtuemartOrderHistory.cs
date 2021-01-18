using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosVirtuemartOrderHistory
    {
        public uint VirtuemartOrderHistoryId { get; set; }
        public uint VirtuemartOrderId { get; set; }
        public string OrderStatusCode { get; set; }
        public bool CustomerNotified { get; set; }
        public string Comments { get; set; }
        public decimal Paid { get; set; }
        public string OHash { get; set; }
        public bool? Published { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
    }
}
