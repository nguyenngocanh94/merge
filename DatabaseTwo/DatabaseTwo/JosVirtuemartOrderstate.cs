using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTwo.DatabaseTwo
{
    public partial class JosVirtuemartOrderstate
    {
        public byte VirtuemartOrderstateId { get; set; }
        public short VirtuemartVendorId { get; set; }
        public string OrderStatusCode { get; set; }
        public string OrderStatusName { get; set; }
        public string OrderStatusDescription { get; set; }
        public string OrderStockHandle { get; set; }
        public int Ordering { get; set; }
        public bool? Published { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
    }
}
